using System;
using System.Windows.Forms;
using WalkPageGen;

namespace WalkingClubAdmin
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
