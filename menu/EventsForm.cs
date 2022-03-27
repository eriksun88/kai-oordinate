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
    public partial class EventsForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public EventsForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
            BindControls();
        }
        public void BindControls()
        {
            lblEventID.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.LocationID");
            txtEventDate.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventDate");
            lstEvent.DataSource = DM.dsKaiOordinate;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EVENT"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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
            lblEventID.Text = null;
            DataRow newEventRow = DM.dtEvent.NewRow();
            if ((txtEventName.Text == "") || (txtLocation.Text == "") || (txtEventDate.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            if (!IsValidLocation(Convert.ToInt32(txtLocation.Text)))
            {
                MessageBox.Show("You may only add Event to an exist location", "Error");
                return;
            }
            newEventRow["EventName"] = txtEventName.Text;
            newEventRow["LocationID"] = Convert.ToInt32(txtLocation.Text);
            newEventRow["EventDate"] = Convert.ToDateTime(txtEventDate.Text);
            DM.dtEvent.Rows.Add(newEventRow);
            DM.UpdateEvent();
            MessageBox.Show("Event added successfully", "Success");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            if ((txtEventName.Text == "") || (txtLocation.Text == "")||(txtEventDate.Text == ""))
            {
                MessageBox.Show("You must type in a EventName description, Location and EventDate", "Error");
                return;
            }
            if (!IsValidLocation(Convert.ToInt32(txtLocation.Text)))
            {
                MessageBox.Show("You may only add Event to an exist location", "Error");
                return;
            }

            updateEventRow["EventName"] = txtEventName.Text;
            updateEventRow["LocationID"] = Convert.ToInt32(txtLocation.Text);
            updateEventRow["EventDate"] = Convert.ToDateTime(txtEventDate.Text);
            currencyManager.EndCurrentEdit();
            DM.UpdateEvent();
            MessageBox.Show("Event updated successfully", "Success");           
        }

        private bool IsValidLocation(int locationID)
        {
            DataRow[] LocationRow = DM.dtLocation.Select("LocationID = " + locationID);
            if (LocationRow.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] EventRegisterRow = DM.dtEventRegister.Select("EventID = " + lblEventID.Text);
            DataRow[] KaiRow = DM.dtKai.Select("EventID = " + lblEventID.Text);
            if (EventRegisterRow.Length != 0 && KaiRow.Length != 0)
            {
                MessageBox.Show("You may only delete Event that are not allocated to Register and Kai", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.UpdateEvent();
                }
            }
        }
    }
}
