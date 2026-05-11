using System.Windows.Forms;

namespace TWC.Admin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddTabPages();
        }

        private void AddTabPages()
        {
            var reportForm = new ReportForm();
            var eventsForm = new EventsForm();
            var convertForm = new ConvertForm();
            reportsTabPage.Controls.Add(reportForm);
            eventsTabPage.Controls.Add(eventsForm);
            convertTabPage.Controls.Add(convertForm);
        }
    }
}
