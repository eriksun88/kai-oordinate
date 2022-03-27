using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class MainForm : Form
    {
        KaiForm kaiForm;
        LocationsForm locationsForm;
        EventsForm eventsForm;
        WhanauForm whanauForm;
        RegistrationForm registrationForm;
        ReportForm reportForm;
        DataModule DM;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiForm == null)
                kaiForm = new KaiForm(DM, this);
            kaiForm.ShowDialog();
        }

        

        private void mainform_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            if(locationsForm == null)
             locationsForm = new LocationsForm(DM, this);
            locationsForm.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (registrationForm == null)
                registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
                reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (whanauForm == null)
                whanauForm = new WhanauForm();
            whanauForm.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (eventsForm == null)
                eventsForm = new EventsForm(DM, this);
            eventsForm.ShowDialog();
        }
    }
}
