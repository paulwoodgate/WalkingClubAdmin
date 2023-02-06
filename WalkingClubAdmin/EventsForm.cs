using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalkPageGen;

namespace WalkingClubAdmin
{
    public partial class EventsForm : UserControl
    {
        public EventsForm()
        {
            InitializeComponent();
            PopulateYears();
            LoadPreviousValues();
        }

        private void PopulateYears()
        {
            for (var year = 2017; year <= DateTime.Now.Year + 1; year++)
            {
                YearCombo.Items.Add(year);
            }
            YearCombo.SelectedItem = DateTime.Now.Year + 1;
        }

        private void LoadPreviousValues()
        {
            var options = Options.Read();
            YearCombo.SelectedItem = options.Year;
            if (options.ReadFromGoogle)
                GoogleRadioButton.Checked = true;
            else
                ExcelRadioButton.Checked = true;
            ExcelSourceFileTextBox.Text = options.ExcelSourceFile;
            OutputFileTextBox.Text = options.OutputFile;
            MongoDbDatesCheckBox.Checked = options.MongoDbDates;
        }

        private void GoogleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableExcelItems((sender as RadioButton)?.Checked == false);
        }

        private void EnableExcelItems(bool enabled)
        {
            ExcelSourceFileTextBox.Enabled = enabled;
            ExcelSourceBrowseButton.Enabled = enabled;
        }

        private void ExcelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableExcelItems((sender as RadioButton)?.Checked == true);
        }

        private void ExcelSourceBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckPathExists = true,
                Filter = "Excel files|*.xlsx|All files|*.*",
                Title = "Select Excel File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ExcelSourceFileTextBox.Text = dialog.FileName;
            }
        }

        private void OutputFileBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "JSON files|*.json|All files|*.*",
                OverwritePrompt = true,
                Title = "Select JSON Output File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                OutputFileTextBox.Text = dialog.FileName;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new Options
                {
                    Year = Convert.ToInt32(YearCombo.SelectedItem),
                    ReadFromGoogle = GoogleRadioButton.Checked,
                    ExcelSourceFile = ExcelSourceFileTextBox.Text,
                    OutputFile = OutputFileTextBox.Text,
                    MongoDbDates = MongoDbDatesCheckBox.Checked
                };

                options.Validate();
                options.Save();
                GeneratorController.GeneratePage(options);
                MessageBox.Show($"The walks for {options.Year} have been successfully generated");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
