using ReportGen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalkPageGen;

namespace WalkingClubAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            HtmlCheckbox.Checked = options.GenerateHtml;
            HtmlSourceFileTextBox.Text = options.HtmlSourceFile;
            HtmlOutputFileTextBox.Text = options.HtmlOutputFile;
            JsonCheckbox.Checked = options.GenerateJson;
            JsonOutputFileTextBox.Text = options.JsonOutputFile;
            MongoDbDatesCheckBox.Checked = options.MongoDbDates;
        }

        private void HtmlSourceBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckPathExists = true,
                Filter = "HTML files|*.html|All files|*.*",
                Title = "Select Source File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                HtmlSourceFileTextBox.Text = dialog.FileName;
            }
        }

        private void HtmlOutputBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "HTML files|*.html|All files|*.*",
                OverwritePrompt = true,
                Title = "Select Html Output File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                HtmlOutputFileTextBox.Text = dialog.FileName;
            }
        }

        private void JsonOutputBrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "JSON files|*.json|All files|*.*",
                OverwritePrompt = true,
                Title = "Select JSON Output File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                JsonOutputFileTextBox.Text = dialog.FileName;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new Options
                {
                    Year = Convert.ToInt32(YearCombo.SelectedItem),
                    GenerateHtml = HtmlCheckbox.Checked,
                    HtmlSourceFile = HtmlSourceFileTextBox.Text,
                    HtmlOutputFile = HtmlOutputFileTextBox.Text,
                    GenerateJson = JsonCheckbox.Checked,
                    JsonOutputFile = JsonOutputFileTextBox.Text,
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

        private void HtmlCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EnableHtmlItems((sender as CheckBox)?.Checked == true);
        }

        private void EnableHtmlItems(bool enabled)
        {
            HtmlSourceFileTextBox.Enabled = enabled;
            HtmlSourceBrowseButton.Enabled = enabled;
            HtmlOutputFileTextBox.Enabled = enabled;
            HtmlOutputBrowseButton.Enabled = enabled;
        }

        private void JsonCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EnableJsonItems((sender as CheckBox)?.Checked == true);
        }

        private void EnableJsonItems(bool enabled)
        {
            JsonOutputBrowseButton.Enabled = enabled;
            JsonOutputFileTextBox.Enabled = enabled;
            MongoDbDatesCheckBox.Enabled = enabled;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var data = new ReportData
            {
                Id = IdTextBox.Text,
                Date = DatePicker.Value.Date,
                Title = titleTextBox.Text,
                Report = ReportTextBox.Text,
                ReportBy = authorTextBox.Text,
                Rating = ratingTextBox.Text,
                CoverPhoto = photoTextBox.Text,
                Photographer = photographerTextBox.Text,
                Captions = captionGrid.Rows
                       .OfType<DataGridViewRow>()
                       .Select(x => x.Cells[0].Value != null ? x.Cells[0].Value.ToString() : "")
                       .ToList()
            };

            try
            {
                data.Validate();
                var report = new Report(data);
                var json = report.ToJson();
                var dialog = new SaveFileDialog
                {
                    DefaultExt = ".json",
                    Filter = "*.json|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, json);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }
    }
}
