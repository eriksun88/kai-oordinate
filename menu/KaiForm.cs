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
    ///<Summary> class: KaiForm 
    ///This form displays the KaiForm, allows the user to edit the records in the kai table
    ///author: zhiyuan sun
    ///date written: 19/04/2022
    ///</Summary>
    public partial class KaiForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        ///<Summary> method: KaiForm
        ///constructor method to initialize all the component
        ///</Summary>
        public KaiForm(DataModule dm, MainForm mfm)
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
            txtKaiID.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.EventID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiName");
            txtPreparationRequired.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationRequired");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.ServeQuantity");
            txtPreparationTime.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationMinutes");
            txtKaiID.Enabled = false;
            txtEvent.Enabled = false;
            txtKaiName.Enabled = false;
            txtPreparationRequired.Enabled = false;
            txtServingQuantity.Enabled = false;
            txtPreparationTime.Enabled = false;
            lstKai.DataSource = DM.dsKaiOordinate;
            lstKai.DisplayMember = "Kai.KaiName";
            lstKai.ValueMember = "Kai.KaiName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Kai"];
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
        ///<Summary> method: LoadKai
        ///load kai information
        ///</Summary>
        private void LoadKai()
        {
            cboAddEvent.DataSource = DM.dsKaiOordinate;
            cboAddEvent.DisplayMember = "Event.EventName";
            cboAddEvent.ValueMember = "Event.EventID";
        }
        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstKai.Visible = false;
            btnUpdate.Enabled = false;  
            btnDelete.Enabled = false;  
            btnUp.Enabled = false;  
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            cboAddEvent.Text = "";
            txtAddKaiName.Text = null;
            cbxAddPreparationRequired.Checked = false;
            nudAddPreparationTime.Value = 0;
            nudAddServingQuantity.Value = 0;
            pnlAddKai.Show();
            LoadKai();
        }

        ///<Summary> method: hasEvent
        ///
        ///</Summary>
        private bool hasEvent(int eventID)
        {
            DataRow[] eventRow = DM.dtEvent.Select("EventID = " + eventID);
            if (eventRow.Length == 0)
            {
                return false;
            }
            return true;
        }

        ///<Summary> method: IsValidKai
        ///
        ///</Summary>
        private bool IsValidKai()
        {
            if (cboAddEvent.Text == "")
            {
                MessageBox.Show("You must choose an Event name", "Error");
                return false;
            }
            if (txtAddKaiName.Text == "")
            {
                MessageBox.Show("You must enter a Kai name", "Error");
                return false;
            }
            if (cbxAddPreparationRequired.Checked && nudAddPreparationTime.Value <= 0)
            {
                MessageBox.Show("You must enter a valid Preparation Minutess that greater than 0", "Error");
                return false;
            }
            if (nudAddServingQuantity.Value <= 0)
            {
                MessageBox.Show("You must enter a valid Serving Quantity that greater than 0", "Error");
                return false;
            }
            return true;
        }

        ///<Summary> method: btnUpdate_Click
        ///update element to the list when click
        ///</Summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstKai.Visible = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddKai.Show();
            LoadKai();
            DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
            //cboAddEvent.SelectedValue = updateKaiRow["EventID"];
            txtAddKaiName.Text = updateKaiRow["KaiName"].ToString();
            cbxAddPreparationRequired.Checked = Convert.ToBoolean(updateKaiRow["PreparationRequired"]);
            nudAddPreparationTime.Value = Convert.ToInt32(updateKaiRow["PreparationMinutes"]);
            nudAddServingQuantity.Value = Convert.ToInt32(updateKaiRow["ServeQuantity"]);
        }

        ///<Summary> method: btnDelete_Click
        ///delete element from the list when click
        ///</Summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if (!hasEvent(Convert.ToInt32(deleteKaiRow["EventID"])))
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        deleteKaiRow.Delete();
                        DM.UpdateEvent();
                        MessageBox.Show("Kai deleted successfully", "Success");
                    }
                    catch
                    {
                        MessageBox.Show("Failed to delete Kai", "Error");
                    }                    
                }
            }
            else
            {
                MessageBox.Show("You may only delete kai that have no event relation", "Error");
            }
        }

        ///<Summary> method: AddKai
        ///
        ///</Summary>
        private void AddKai()
        {
            lblKaiID.Text = null;
            DataRow newKaiRow = DM.dtKai.NewRow();
            newKaiRow["EventID"] = Convert.ToInt32(cboAddEvent.SelectedValue);
            newKaiRow["KaiName"] = txtAddKaiName.Text;
            newKaiRow["PreparationRequired"] = cbxAddPreparationRequired.Checked;
            newKaiRow["PreparationMinutes"] = Convert.ToInt32(nudAddPreparationTime.Value);
            newKaiRow["ServeQuantity"] = Convert.ToInt32(nudAddServingQuantity.Value);
            DM.dtKai.Rows.Add(newKaiRow);
            DM.UpdateKai();
            MessageBox.Show("Kai added successfully", "Success");
        }

        ///<Summary> method: UpdateKai
        ///
        ///</Summary>
        private void UpdateKai()
        {
            DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
            updateKaiRow["EventID"] = Convert.ToInt32(cboAddEvent.SelectedValue);
            updateKaiRow["KaiName"] = txtAddKaiName.Text;
            updateKaiRow["PreparationRequired"] = cbxAddPreparationRequired.Checked;
            updateKaiRow["PreparationMinutes"] = Convert.ToInt32(nudAddPreparationTime.Value);
            updateKaiRow["ServeQuantity"] = Convert.ToInt32(nudAddServingQuantity.Value);
            currencyManager.EndCurrentEdit();
            DM.UpdateKai();
            MessageBox.Show("Kai updated successfully", "Success");
        }

        ///<Summary> method: btnSave_Click
        ///save element to the list when click
        ///</Summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidKai())
            {
                if (btnAdd.Enabled)
                {
                    try
                    {
                        AddKai();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to add Kai", "Error");
                    }
                }
                else
                {
                    try
                    {
                        UpdateKai();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to update Kai", "Error");
                    }
                }
            }                   
        }

        ///<Summary> method: btnCancel_Click
        ///cancel 
        ///</Summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddKai.Hide();
            lstKai.Visible = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnReturn.Enabled = true;
        }
    }
}
