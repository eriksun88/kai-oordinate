using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    ///<Summary> class: WhanauForm 
    ///This form displays the WhanauForm, allows the user to edit the records in the Whanau table
    ///author: zhiyuan sun
    ///date written: 21/04/2022
    ///</Summary>
    public partial class WhanauForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        ///<Summary> method: WhanauForm
        ///constructor method to initialize all the component
        ///</Summary>
        public WhanauForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
            BindControls();
        }

        ///<Summary> method: BindControls
        ///binding data module with form elements
        ///</Summary>
        public void BindControls()
        {
            txtWhanauID.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.LastName");
            txtEmail.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Email");
            txtPhone.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Phone");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Address");
            txtWhanauID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            dgvFullName.DataSource = DM.dsKaiOordinate;
            dgvFullName.DataMember = "Whanau";      
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
        }
        ///<Summary> method: btnReturn_Click
        ///close current form when click
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method: btnUp_Click
        ///move to select the upper element in the list when click
        ///</Summary>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        ///<Summary> method: btnDown_Click
        ///move to select the lower element in the list when click
        ///</Summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvFullName.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            txtAddFirstName.Text = "";
            txtAddLastName.Text = "";
            txtAddEmail.Text = "";
            txtAddPhone.Text = "";
            txtAddAddress.Text = "";
            pnlAddWhanau.Show();
        }

        ///<Summary> method: btnUpdate_Click
        ///update element to the list when click
        ///</Summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvFullName.Visible = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            txtAddFirstName.Text = txtFirstName.Text;
            txtAddLastName.Text = txtLastName.Text;
            txtAddEmail.Text = txtEmail.Text;
            txtAddPhone.Text = txtPhone.Text;
            txtAddAddress.Text = txtAddress.Text;
            pnlAddWhanau.Show();
        }

        ///<Summary> method: hasEventRegister
        ///check whether the event to be delete reference to any EventRegister
        ///</Summary>
        private bool hasEventRegister(string whanauID)
        {
            DataRow[] EventRegisterRow = DM.dtEventRegister.Select("WhanauID = " + whanauID);
            if (EventRegisterRow.Length == 0)
            {
                return false;
            }
            return true;
        }

        ///<Summary> method: btnDelete_Click
        ///delete element from the list when click
        ///</Summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            if (hasEventRegister(txtWhanauID.Text))
            {
                MessageBox.Show("You may only delete Whanau that are not allocated to Event Register", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try 
                    {
                        deleteWhanauRow.Delete();
                        DM.UpdateWhanau();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to delete Whanau", "Error");
                    }                   
                }
            }
        }
        ///<Summary> method: AddWhanau
        ///add Whanau object to DB
        ///</Summary>
        private void AddWhanau()
        {
            DataRow newWhanauRow = DM.dtWhanau.NewRow();
            newWhanauRow["FirstName"] = txtAddFirstName.Text;
            newWhanauRow["LastName"] = txtAddLastName.Text;
            newWhanauRow["Email"] = txtAddEmail.Text;
            newWhanauRow["Phone"] = txtAddPhone.Text;
            newWhanauRow["Address"] = txtAddAddress.Text;
            DM.dtWhanau.Rows.Add(newWhanauRow);
            DM.UpdateWhanau();
            MessageBox.Show("Whanau added successfully", "Success");
        }

        ///<Summary> method: UpdateWhanau
        ///Update Whanau object to DB
        ///</Summary>
        private void UpdateWhanau()
        {
            DataRow updateWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            updateWhanauRow["FirstName"] = txtAddFirstName.Text;
            updateWhanauRow["LastName"] = txtAddLastName.Text;
            updateWhanauRow["Email"] = txtAddEmail.Text;
            updateWhanauRow["Phone"] = txtAddPhone.Text;
            updateWhanauRow["Address"] = txtAddAddress.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateWhanau();
            MessageBox.Show("Whanau updated successfully", "Success");
        }

        ///<Summary> method: InitView
        ///initialize the form view to hide the panel and enable buttons 
        ///</Summary>
        private void InitView()
        {
            pnlAddWhanau.Hide();
            dgvFullName.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnReturn.Enabled = true;
        }

        ///<Summary> method: btnCancel_Click
        ///cancel 
        ///</Summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitView();
        }

        ///<Summary> method: btnSave_Click
        ///save element to the list when click
        ///</Summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidWhanau())
            {
                if (btnAdd.Enabled)
                {
                    try
                    {
                        AddWhanau();
                        currencyManager.Position = currencyManager.Count;
                        InitView();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to add Whanau", "Error");
                    }
                }
                else
                {
                    try
                    {
                        UpdateWhanau();
                        InitView();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Whanau", "Error");
                    }
                }
            }
        }
        ///<Summary> method: IsValidKai
        ///check the user input is valid or not
        ///</Summary>
        private bool IsValidWhanau()
        {           
            if (!Regex.IsMatch(txtAddFirstName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("You must enter a valid First name", "Error");
                return false;
            }
            if (!Regex.IsMatch(txtAddLastName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("You must enter a valid Last name", "Error");
                return false;
            }
            if (!Regex.IsMatch(txtAddEmail.Text, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z"))
            {
                MessageBox.Show("You must enter a valid Email Address", "Error");
                return false;
            }
            if (!Regex.IsMatch(txtAddPhone.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("You must enter a valid Phone Number", "Error");
                return false;
            }
            if (txtAddAddress.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a valid Address", "Error");
                return false;
            }
            return true;
        }
    }
}
