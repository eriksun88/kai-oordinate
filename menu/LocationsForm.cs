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
    ///<Summary> class: LocationsForm 
    ///This form displays the LocationsForm, allows the user to edit the records in the Locations table
    ///author: zhiyuan sun
    ///date written: 23/04/2022
    ///</Summary>
    public partial class LocationsForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        ///<Summary> method: LocationsForm
        ///constructor method to initialize all the component
        ///</Summary>
        public LocationsForm(DataModule dm, MainForm mfm)
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
            
            txtLocationName.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.Address");
            txtLocationName.Enabled = false;
            txtAddress.Enabled = false;
            lstLocation.DataSource = DM.dsKaiOordinate;
            lstLocation.DisplayMember = "Location.LocationName";
            lstLocation.ValueMember = "Location.LocationName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Location"];
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

        private void LoadLocation()
        { 
        }

        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstLocation.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            txtAddLocationName.Text = null;
            txtAddAddress.Text = null;
            pnlAddLocation.Show();
            LoadLocation();
            /*lblLocationID.Text = null;
            DataRow newLocationRow = DM.dtLocation.NewRow();
            if ((txtLocationName.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            
            newLocationRow["LocationName"] = txtLocationName.Text;
            newLocationRow["Address"] = txtAddress.Text;            
            DM.dtLocation.Rows.Add(newLocationRow);
            DM.UpdateLocation();
            MessageBox.Show("Location added successfully", "Success");*/
        }

        ///<Summary> method: IsValidKai
        ///
        ///</Summary>
        private bool IsValidLocation ()
        {                      
            if (txtAddLocationName.Text == "")
            {
                MessageBox.Show("You must enter a Location name", "Error");
                return false;
            }
            if (txtAddAddress.Text == "")
            {
                MessageBox.Show("You must enter an Address", "Error");
                return false;
            }
            return true;
        }

        ///<Summary> method: btnUpdate_Click
        ///update element to the list when click
        ///</Summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstLocation.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            txtAddLocationName.Text = null;
            txtAddAddress.Text = null;
            pnlAddLocation.Show();
            LoadLocation();
            DataRow updateLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            //cboAddEvent.SelectedValue = updateKaiRow["EventID"];
            txtAddLocationName.Text = updateLocationRow["LocationName"].ToString();
            txtAddAddress.Text = updateLocationRow["Addres"].ToString();
            /*DataRow updateLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            if ((txtLocationName.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must type in a LocationName and Address", "Error");
                return;
            }
            updateLocationRow["LocationName"] = txtLocationName.Text;
            updateLocationRow["Address"] = txtAddress.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateLocation();
            MessageBox.Show("Location updated successfully", "Success");*/
        }

        ///<Summary> method: btnDelete_Click
        ///delete element from the list when click
        ///</Summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            DataRow[] EventRow = DM.dtEvent.Select("LocationID = " + lblLocationID.Text);            
            if (EventRow.Length != 0)
            {
                MessageBox.Show("You may only delete Location that are not allocated to Event", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteLocationRow.Delete();
                    DM.UpdateLocation();
                }
            }
        }
        ///<Summary> method: AddLocation
        ///
        ///</Summary>
        private void AddLocation()
        {
            lblLocationID.Text = null;
            DataRow newLocationRow = DM.dtKai.NewRow();
            newLocationRow["LocationName"] = txtAddLocationName.Text;
            newLocationRow["Address"] = txtAddAddress.Text;
            DM.dtLocation.Rows.Add(newLocationRow);
            DM.UpdateLocation();
            MessageBox.Show("Location added successfully", "Success");
        }

        ///<Summary> method: UpdateLocation
        ///
        ///</Summary>
        private void UpdateLocation()
        {
            DataRow newLocationRow = DM.dtKai.NewRow();
            newLocationRow["LocationName"] = txtAddLocationName.Text;
            newLocationRow["Address"] = txtAddAddress.Text;
            DM.dtLocation.Rows.Add(newLocationRow);
            DM.UpdateLocation();
            MessageBox.Show("Location uppdate successfully", "Success");
        }

        ///<Summary> method: btnSave_Click
        ///save element to the list when click
        ///</Summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidLocation())
            {
                if (btnAdd.Enabled)
                {
                    try
                    {
                        AddLocation();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to add Location", "Error");
                    }
                }
                else
                {
                    try
                    {
                        UpdateLocation();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Location", "Error");
                    }
                }
            }
        }

        ///<Summary> method: btnCancel_Click
        ///cancel 
        ///</Summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddLocation.Hide();
            lstLocation.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnReturn.Enabled = true;
        }
    }
}
