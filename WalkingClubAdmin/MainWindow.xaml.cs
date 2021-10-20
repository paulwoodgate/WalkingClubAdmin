using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WalkPageGen;
using DocumentFormat.OpenXml.Bibliography;

namespace WalkingClubAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateYears();
            LoadPreviousValues();
        }

        private void PopulateYears()
        {
            for (var year = 2017; year <= DateTime.Now.Year + 1; year++)
            {
                YearComboBox.Items.Add(year);
            }
            YearComboBox.SelectedItem = DateTime.Now.Year+1;
        }

        private void LoadPreviousValues()
        {
            var options = Options.Read();
            YearComboBox.SelectedValue = options.Year;
            HtmlCheckbox.IsChecked = options.GenerateHtml;
            HtmlSourceFileTextBox.Text = options.HtmlSourceFile;
            HtmlOutputFileTextBox.Text = options.HtmlOutputFile;
            JsonCheckbox.IsChecked = options.GenerateJson;
            JsonOutputFileTextBox.Text = options.JsonOutputFile;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var options = new Options
                {
                    Year = Convert.ToInt32(YearComboBox.SelectedValue),
                    GenerateHtml = HtmlCheckbox.IsChecked == true,
                    HtmlSourceFile = HtmlSourceFileTextBox.Text,
                    HtmlOutputFile = HtmlOutputFileTextBox.Text,
                    GenerateJson = JsonCheckbox.IsChecked == true,
                    JsonOutputFile = JsonOutputFileTextBox.Text,
                    MongoDbDates = mongoDBDateCheckbox.IsChecked == true
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

        private void HtmlSourceBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckPathExists = true,
                Filter = "HTML files|*.html|All files|*.*",
                Title = "Select Source File"
            };
            if (dialog.ShowDialog(this).GetValueOrDefault())
            {
                HtmlSourceFileTextBox.Text = dialog.FileName;
            }
        }

        private void HtmlOutputBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "HTML files|*.html|All files|*.*",
                OverwritePrompt = true,
                Title = "Select Html Output File"
            };
            if (dialog.ShowDialog(this).GetValueOrDefault())
            {
                HtmlOutputFileTextBox.Text = dialog.FileName;
            }
        }

        private void JsonOutputBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "JSON files|*.json|All files|*.*",
                OverwritePrompt = true,
                Title = "Select JSON Output File"
            };
            if (dialog.ShowDialog(this).GetValueOrDefault())
            {
                JsonOutputFileTextBox.Text = dialog.FileName;
            }
        }

        private void HtmlCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            if (HtmlOutputFileTextBox != null)
                EnableHtmlItems(true);
        }

        private void HtmlCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            EnableHtmlItems(false);
        }

        private void EnableHtmlItems(bool enabled)
        {
            HtmlSourceFileTextBox.IsEnabled = enabled;
            HtmlSourceBrowseButton.IsEnabled = enabled;
            HtmlOutputFileTextBox.IsEnabled = enabled;
            HtmlOutputBrowseButton.IsEnabled = enabled;
        }

        private void JsonCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            if (JsonOutputFileTextBox != null)
                EnableJsonItems(true);
        }

        private void JsonCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            EnableJsonItems(false);
        }

        private void EnableJsonItems(bool enabled)
        {
            JsonOutputBrowseButton.IsEnabled = enabled;
            JsonOutputFileTextBox.IsEnabled = enabled;
        }
    }
}
