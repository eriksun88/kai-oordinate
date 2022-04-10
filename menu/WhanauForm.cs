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
    public partial class WhanauForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;
        public WhanauForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
            BindControls();
        }
        public void BindControls()
        {
            lblWhanauID.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.LastName");
            txtEmail.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Email");
            txtPhone.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Phone");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Address");

            dgvFullName.DataSource = DM.dsKaiOordinate;
            dgvFullName.DataMember ="Whanau";
           
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WhanauForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWhanauID.Text = null;
            DataRow newWhanauRow = DM.dtWhanau.NewRow();
            if ((txtFirstName.Text == "") || (txtLastName.Text == "")|| (txtEmail.Text == "")|| (txtPhone.Text == "")|| (txtAddress.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }

            newWhanauRow["FirstName"] = txtFirstName.Text;
            newWhanauRow["LastName"] = txtLastName.Text;
            newWhanauRow["Email"] = txtEmail.Text;
            newWhanauRow["Phone"] = txtPhone.Text;
            newWhanauRow["Address"] = txtAddress.Text;
            DM.dtWhanau.Rows.Add(newWhanauRow);
            DM.UpdateWhanau();
            MessageBox.Show("Whanau added successfully", "Success");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtEmail.Text == "") || (txtPhone.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must type in a FirstName, LastName,  Email, Phone and Address", "Error");
                return;
            }
            updateWhanauRow["FirstName"] = txtFirstName.Text;
            updateWhanauRow["LastName"] = txtLastName.Text;
            updateWhanauRow["Email"] = txtEmail.Text;
            updateWhanauRow["Phone"] = txtPhone.Text;
            updateWhanauRow["Address"] = txtAddress.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateWhanau();
            MessageBox.Show("Whanau updated successfully", "Success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            DataRow[] EventRegisterRow = DM.dtEventRegister.Select("WhanauID = " + lblWhanauID.Text);
            if (EventRegisterRow.Length != 0)
            {
                MessageBox.Show("You may only delete Whanau that are not allocated to Event Register", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
                {  
                    deleteWhanauRow.Delete();
                    DM.UpdateWhanau();
                }
            }
            
        }

        private void lstWhanau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvFullName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
