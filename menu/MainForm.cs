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
    ///<Summary> class: MainForm 
    ///This form displays the menu, allows the user to access all the forms 
    ///and the reports in the system and exit the application
    ///author: zhiyuan sun
    ///date written: 18/04/2022
    ///</Summary>
    public partial class MainForm : Form
    {
        KaiForm kaiForm;
        LocationsForm locationsForm;
        EventsForm eventsForm;
        WhanauForm whanauForm;
        RegistrationForm registrationForm;
        ReportForm reportForm;
        DataModule DM;

        ///<Summary> method: MainForm
        ///constructor method to initialize all the component
        ///</Summary>
        public MainForm()
        {
            InitializeComponent();
        }
        ///<Summary> method: btnKai_Click
        ///open the kai form when click
        ///</Summary>
        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiForm == null)
                kaiForm = new KaiForm(DM, this);
            kaiForm.ShowDialog();
        }
        ///<Summary> method: mainform_Load
        ///generate datamodule when loading the form
        ///</Summary>
        private void mainform_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }
        ///<Summary> method: btnLocations_Click
        ///open the Locations form when click
        ///</Summary>
        private void btnLocations_Click(object sender, EventArgs e)
        {
            if (locationsForm == null)
                locationsForm = new LocationsForm(DM, this);
            locationsForm.ShowDialog();
        }
        ///<Summary> method: btnRegistration_Click
        ///open the Registration form when click
        ///</Summary>
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (registrationForm == null)
                registrationForm = new RegistrationForm(DM, this);
            registrationForm.ShowDialog();
        }
        ///<Summary> method: btnReport_Click
        ///open the Report form when click
        ///</Summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
                reportForm = new ReportForm(DM, this);
            reportForm.ShowDialog();
        }
        ///<Summary> method: btnExit_Click
        ///exit the application when click
        ///</Summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method: btnWhanau_Click
        ///open the Whanau form when click
        ///</Summary>
        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (whanauForm == null)
                whanauForm = new WhanauForm(DM, this);
            whanauForm.ShowDialog();
        }
        ///<Summary> method: btnEvents_Click
        ///open the Events form when click
        ///</Summary>
        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (eventsForm == null)
                eventsForm = new EventsForm(DM, this);
            eventsForm.ShowDialog();
        }
    }
}
