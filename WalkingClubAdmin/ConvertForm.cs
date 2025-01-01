using ReportGen;
using System;
using System.Windows.Forms;

namespace WalkingClubAdmin
{
    public partial class ConvertForm : UserControl
    {
        public ConvertForm()
        {
            InitializeComponent();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckPathExists = true,
                Filter = "Json files|*.json|All files|*.*",
                Title = "Select Json File"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                FileTextBox.Text = dialog.FileName;
            }
        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                InitialDirectory = "C:\\Users\\paulw\\OneDrive\\Documents\\Walking Club\\Website\\Reports",
                UseDescriptionForTitle = true,
                Description = "Select Folder to Convert"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                FolderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                InitialDirectory = "C:\\dev\\twc-astro\\src\\content\\reports",
                UseDescriptionForTitle = true,
                Description = "Select Output Folder"

            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                OutputTextBox.Text = dialog.SelectedPath;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var options = new ConvertOptions
            {
                ConvertFolder = FolderRadioButton.Checked,
                FileName = FileTextBox.Text,
                FolderPath = FolderTextBox.Text,
                OutputPath = OutputTextBox.Text
            };

            try
            {
                options.Validate();
                var converter = new ReportConverter(options);
                converter.Convert();
                MessageBox.Show(this, "Conversion Successful", "Success");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(this, ex.Message, "An Error has occurred");
            }
        }
    }
}
