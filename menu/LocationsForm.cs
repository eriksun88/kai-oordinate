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
            txtLocationID.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.Address");
            txtLocationID.Enabled = false;
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
            txtAddLocationName.Text = "";
            txtAddAddress.Text = "";
            pnlAddLocation.Show();
        }

        ///<Summary> method: IsValidLocation
        ///check the user input is valid or not
        ///</Summary>
        private bool IsValidLocation ()
        {                      
            if (!Regex.IsMatch(txtAddLocationName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("You must enter a valid Location name", "Error");
                return false;
            }
            if (txtAddAddress.Text.Trim() == "")
            {
                MessageBox.Show("You must enter an valid Address", "Error");
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
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            txtAddLocationName.Text = txtLocationName.Text;
            txtAddAddress.Text = txtAddress.Text;
            pnlAddLocation.Show();
        }
        ///<Summary> method: hasEvent
        ///check whether the location to be delete reference to any event
        ///</Summary>
        private bool hasEvent(string locationID)
        {
            DataRow[] EventRow = DM.dtEvent.Select("LocationID = " + locationID);
            if (EventRow.Length == 0)
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
            DataRow deleteLocationRow = DM.dtLocation.Rows[currencyManager.Position];           
            if (hasEvent(txtLocationID.Text))
            {
                MessageBox.Show("You may only delete locations that have no events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        deleteLocationRow.Delete();
                        DM.UpdateLocation();
                        MessageBox.Show("Location delete successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Failed to delete Location", "Error");
                    }
                }
            }
        }
        ///<Summary> method: AddLocation
        ///add Location object to DB
        ///</Summary>
        private void AddLocation()
        {
            DataRow newLocationRow = DM.dtLocation.NewRow();
            newLocationRow["LocationName"] = txtAddLocationName.Text;
            newLocationRow["Address"] = txtAddAddress.Text;
            DM.dtLocation.Rows.Add(newLocationRow);
            DM.UpdateLocation();
            MessageBox.Show("Location added successfully", "Success");
        }

        ///<Summary> method: UpdateLocation
        ///Update Location object to DB
        ///</Summary>
        private void UpdateLocation()
        {
            DataRow updateLocation = DM.dtLocation.Rows[currencyManager.Position];
            updateLocation["LocationName"] = txtAddLocationName.Text;
            updateLocation["Address"] = txtAddAddress.Text;
            currencyManager.EndCurrentEdit();
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
                        currencyManager.Position = currencyManager.Count;
                        InitView();
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
                        InitView();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Location", "Error");
                    }
                }
            }
        }

        ///<Summary> method: InitView
        ///initialize the form view to hide the panel and enable buttons 
        ///</Summary>
        private void InitView()
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

        ///<Summary> method: btnCancel_Click
        ///cancel 
        ///</Summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitView();
        }
    }
}
