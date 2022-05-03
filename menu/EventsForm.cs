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
    ///<Summary> class: EventsForm 
    ///This form displays the EventsForm, allows the user to edit the records in the Events table
    ///author: zhiyuan sun
    ///date written: 20/04/2022
    ///</Summary>
    public partial class EventsForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        ///<Summary> method: EventsForm
        ///constructor method to initialize all the component
        ///</Summary>
        public EventsForm(DataModule dm, MainForm mfm)
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
            txtEventID.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.LocationID");
            txtEventDate.DataBindings.Add("text", DM.dsKaiOordinate, "Event.EventDate");
            txtEventID.Enabled = false;
            txtEventName.Enabled = false;
            txtLocation.Enabled = false;
            txtEventDate.Enabled = false;
            lstEvent.DataSource = DM.dsKaiOordinate;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EVENT"];
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

        ///<Summary> method: btnReturn_Click
        ///close current form when click
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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
        ///<Summary> method: LoadLocation
        ///load location list
        ///</Summary>
        private void LoadLocation()
        {
            cboAddLocation.DataSource = DM.dsKaiOordinate;
            cboAddLocation.DisplayMember = "Location.LocationName";
            cboAddLocation.ValueMember = "Location.LocationID";
        }

        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstEvent.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            LoadLocation();
            txtAddEventName.Text = "";
            cboAddLocation.Text = "";
            dtpAddEventDate.Value = DateTime.Now;
            pnlEvent.Show();            
        }

        ///<Summary> method: btnUpdate_Click
        ///update element to the list when click
        ///</Summary>      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstEvent.Visible = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;           
            LoadLocation();
            cboAddLocation.Text = txtLocation.Text;
            txtAddEventName.Text = txtEventName.Text;
            dtpAddEventDate.Text = txtEventDate.Text;
            pnlEvent.Show();
        }

        ///<Summary> method: IsValidEvent
        ///check the user input is valid or not
        ///</Summary>
        private bool IsValidEvent()
        {
            if (cboAddLocation.Text == "")
            {
                MessageBox.Show("You must choose an Location name");
                return false;
            }
            if (txtAddEventName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a Event name");
                return false;
            }
            if (dtpAddEventDate.Text == "")
            {
                MessageBox.Show("You must enter a valid Event Date");
                return false;
            }            
            return true;
        }

        ///<Summary> method: hasRegisterOrKai
        ///check whether the event to be delete reference to any Register or Kai
        ///</Summary>
        private bool hasRegisterOrKai(string eventID)
        {
            DataRow[] EventRegisterRow = DM.dtEventRegister.Select("EventID = " + eventID);
            DataRow[] KaiRow = DM.dtKai.Select("EventID = " + eventID);
            if (EventRegisterRow.Length == 0 && KaiRow.Length == 0)
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
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            if (hasRegisterOrKai(txtEventID.Text))
            {
                MessageBox.Show("You may only delete an event that has no kai");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        deleteEventRow.Delete();
                        DM.UpdateEvent();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to delete Event");
                    }                   
                }
            }
        }

        ///<Summary> method: AddEvent
        ///add Event object to DB
        ///</Summary>
        private void AddEvent()
        {            
            DataRow newEventRow = DM.dtEvent.NewRow();
            newEventRow["EventName"] = txtAddEventName.Text;
            newEventRow["LocationID"] = Convert.ToInt32(cboAddLocation.SelectedValue);
            newEventRow["EventDate"] = dtpAddEventDate.Text;
            DM.dtEvent.Rows.Add(newEventRow);
            DM.UpdateEvent();
            MessageBox.Show("Event added successfully");
        }

        ///<Summary> method: UpdateEvent
        ///Update Event object to DB
        ///</Summary>
        private void UpdateEvent()
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            updateEventRow["EventName"] = txtAddEventName.Text;
            updateEventRow["LocationID"] = Convert.ToInt32(cboAddLocation.SelectedValue);
            updateEventRow["EventDate"] = dtpAddEventDate.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateEvent();
            MessageBox.Show("Event updated successfully");
        }

        ///<Summary> method: btnSave_Click
        ///save element to the list when click
        ///</Summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidEvent())
            {
                if (btnAdd.Enabled)
                {
                    try
                    {
                        AddEvent();
                        currencyManager.Position = currencyManager.Count;
                        InitView();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to add Event", "Error");
                    }
                }
                else
                {
                    try
                    {
                        UpdateEvent();
                        InitView();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Event", "Error");
                    }
                }
            }
        }

        ///<Summary> method: InitView
        ///initialize the form view to hide the panel and enable buttons 
        ///</Summary>
        private void InitView()
        {
            pnlEvent.Hide();
            lstEvent.Visible = true;
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
