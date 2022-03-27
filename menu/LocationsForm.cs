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
    public partial class LocationsForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;
        public LocationsForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
            BindControls();
        }
        public void BindControls()
        {
            lblLocationID.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.Address");
            lstLocation.DataSource = DM.dsKaiOordinate;
            lstLocation.DisplayMember = "Location.LocationName";
            lstLocation.ValueMember = "Location.LocationName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Location"];
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void LocationsForm_Load(object sender, EventArgs e)
        {

        }
        private void lblServingQuantity_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblLocationID.Text = null;
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
            MessageBox.Show("Location added successfully", "Success");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            if ((txtLocationName.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must type in a LocationName and Address", "Error");
                return;
            }
            updateLocationRow["LocationName"] = txtLocationName.Text;
            updateLocationRow["Address"] = txtAddress.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateLocation();
            MessageBox.Show("Location updated successfully", "Success");
        }

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
    }
}
