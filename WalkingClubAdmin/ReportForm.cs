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

namespace WalkingClubAdmin
{
    public partial class ReportForm : UserControl
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void SubjectTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectTypeCombobox.Text == "Group")
            {
                EndDatePicker.Enabled = true;
                ParentTextBox.Enabled = true;
                ReportTextBox.Enabled = false;
                AuthorTextBox.Enabled = false;
                RatingTextBox.Enabled = false;
                PhotosGrid.Enabled = false;
            }
            else
            {
                EndDatePicker.Enabled = false;
                ParentTextBox.Enabled = false;
                ReportTextBox.Enabled = true;
                AuthorTextBox.Enabled = true;
                RatingTextBox.Enabled = true;
                PhotosGrid.Enabled = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "";
            DatePicker.Value = DateTime.Today;
            EndDatePicker.Value = DateTime.Today;
            ParentTextBox.Text = "";
            TitleTextBox.Text = "";
            SubjectTypeCombobox.Text = "Walk";
            ReportTextBox.Text = "";
            AuthorTextBox.Text = "";
            RatingTextBox.Text = "";
            PhotoTextBox.Text = "";
            PhotosGrid.Rows.Clear();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ReportData data = GetFormValues();

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

        private ReportData GetFormValues()
        {
            var photographers = new List<string>();
            var files = new List<string>();
            var captions = new List<string>();

#pragma warning disable S3267 // Loops should be simplified with "LINQ" expressions
            foreach (var row in PhotosGrid.Rows.OfType<DataGridViewRow>())
            {
                if (!string.IsNullOrWhiteSpace((string)row.Cells[1].Value))
                {
                    photographers.Add(row.Cells[0].Value?.ToString());
                    files.Add(row.Cells[1].Value?.ToString());
                    captions.Add(row.Cells[2].Value?.ToString());
                }
            }
#pragma warning restore S3267 // Loops should be simplified with "LINQ" expressions

            var data = new ReportData(photographers, files, captions)
            {
                Id = IdTextBox.Text,
                Date = DatePicker.Value.Date,
                EndDate = EndDatePicker.Value.Date,
                Title = TitleTextBox.Text,
                SubjectType = SubjectTypeCombobox.Text,
                Report = ReportTextBox.Text,
                ReportBy = AuthorTextBox.Text,
                Rating = RatingTextBox.Text,
                CoverPhoto = PhotoTextBox.Text,
            };
            return data;
        }

        private void MarkDownButton_Click(object sender, EventArgs e)
        {
            ReportData data = GetFormValues();

            try
            {
                data.Validate();
                var report = new Report(data);
                var markDown = report.ToMarkDown();
                var dialog = new SaveFileDialog
                {
                    DefaultExt = ".md",
                    Filter = "*.md|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, markDown);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error");
            }
        }
    }
}
