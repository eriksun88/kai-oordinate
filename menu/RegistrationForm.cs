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
    ///<Summary> class: RegistrationForm 
    ///This form displays the RegistrationForm, allows the user to see the records in the Registration table
    ///author: zhiyuan sun
    ///date written: 24/04/2022
    ///</Summary>
    public partial class RegistrationForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;       
        private CurrencyManager cmEvents;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistrations;

        ///<Summary> method: RegistrationForm
        ///constructor method to initialize all the component
        ///</Summary>
        public RegistrationForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
            cmEvents = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Event"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
            cmRegistrations = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EventRegister"];
            BindControls();
        }

        ///<Summary> method: btnReturn_Click
        ///close current form when click
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        ///<Summary> method: BindControls
        ///binding data module with form elements
        ///</Summary>
        public void BindControls()
        {
            dgvEvents.DataSource = DM.dsKaiOordinate;
            dgvEvents.DataMember = "Event";
            dgvWhanau.DataSource = DM.dsKaiOordinate;
            dgvWhanau.DataMember = "Whanau";
            dgvRegistrations.DataSource = DM.dsKaiOordinate;
            dgvRegistrations.DataMember = "EventRegister";

        }

        ///<Summary> method: hasRegistration
        ///check whether the Registration reference to any exist Registration
        ///</Summary>
        private bool hasRegistration(string whanauID, string eventID)
        {
            DataRow[] registrationtRow = DM.dtEventRegister.Select("WhanauID = " + whanauID + " and EventID = " + eventID);
            if (registrationtRow.Length == 0)
            {
                return false;
            }
            return true;
        }
        ///<Summary> method: AddRegistration
        ///add Registration object to DB
        ///</Summary>
        private void AddRegistration()
        {

            DataRow newRegistration = DM.dtEventRegister.NewRow();
            newRegistration["EventID"] = dgvEvents["EventID", cmEvents.Position].Value;
            newRegistration["WhanauID"] = dgvWhanau["WhanauID", cmWhanau.Position].Value;
            newRegistration["KaiPreparation"] = ckbKaiPreparationAssitant.Checked;
            DM.dsKaiOordinate.Tables["EventRegister"].Rows.Add(newRegistration);
            DM.UpdateEventRegister();
            MessageBox.Show("Entry added successfully");
        }
        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (hasRegistration(dgvWhanau["WhanauID", cmWhanau.Position].Value.ToString(), dgvEvents["EventID", cmEvents.Position].Value.ToString()))
            {
                MessageBox.Show("Whanau can only be registered to an event once", "Error");
            }
            else
            {
                try
                {
                    AddRegistration();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to add", "Error");
                }
            }
            
        }

        ///<Summary> method: btnDelete_Click
        ///delete element from the list when click
        ///</Summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Registration?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRow deleteRegistrationRow = DM.dtEventRegister.Rows[cmRegistrations.Position];
                    deleteRegistrationRow.Delete();
                    DM.UpdateEvent();
                    MessageBox.Show("Entry removed successfully");
                }
                catch
                {
                    MessageBox.Show("Failed to delete Registration");
                }
                
            }
        }
    }
}
