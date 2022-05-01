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
            lblKaiID.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.EventID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiName");
            cbxPreparationRequired.DataBindings.Add("Checked", DM.dsKaiOordinate, "Kai.PreparationRequired");
            nudServingQuantity.DataBindings.Add("Value", DM.dsKaiOordinate, "Kai.ServeQuantity");
            nudPreparationTime.DataBindings.Add("Value", DM.dsKaiOordinate, "Kai.PreparationMinutes");
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
        ///<Summary> method: btnAdd_Click
        ///add element to the list when click
        ///</Summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblKaiID.Text = null;
            DataRow newKaiRow = DM.dtKai.NewRow();
            if ((txtEvent.Text == "") || (txtKaiName.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
                return;
            }
            if (nudPreparationTime.Value <= 0 || nudServingQuantity.Value <= 0)
            {
                MessageBox.Show("You must enter a valid Preparation Minutess and Serving Quantity that greater than 0", "Error");
                return;
            }
            if (!IsValidEvent(Convert.ToInt32(txtEvent.Text)))
            {
                MessageBox.Show("You may only add Kai to an exist Event", "Error");
                return;
            }
            newKaiRow["EventID"] = Convert.ToInt32(txtEvent.Text);
            newKaiRow["KaiName"] = txtKaiName.Text;
            newKaiRow["PreparationRequired"] = cbxPreparationRequired.Checked;
            newKaiRow["PreparationMinutes"] = Convert.ToInt32(nudPreparationTime.Value); ;
            newKaiRow["ServeQuantity"] = Convert.ToInt32(nudServingQuantity.Value);
            DM.dtKai.Rows.Add(newKaiRow);
            DM.UpdateKai();
            MessageBox.Show("Kai added successfully", "Success");
        }

        private bool IsValidEvent(int eventID)
        {
            DataRow[] eventRow = DM.dtEvent.Select("EventID = " + eventID);
            if (eventRow.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if ((txtEvent.Text == "") || (txtKaiName.Text == ""))
            {
                MessageBox.Show("You must type in a EventID and  KaiName", "Error");
                return;
            }
            if (nudPreparationTime.Value <= 0 || nudServingQuantity.Value <= 0)
            {
                MessageBox.Show("You must enter a valid Preparation Minutess and Serving Quantity that greater than 0", "Error");
                return;
            }
            if (!IsValidEvent(Convert.ToInt32(txtEvent.Text)))
            {
                MessageBox.Show("You may only add Kai to an exist Event", "Error");
                return;
            }
            updateKaiRow["EventID"] = Convert.ToInt32(txtEvent.Text);
            updateKaiRow["KaiName"] = txtKaiName.Text;
            updateKaiRow["PreparationRequired"] = cbxPreparationRequired.Checked;
            updateKaiRow["PreparationMinutes"] = Convert.ToInt32(nudPreparationTime.Value);
            updateKaiRow["ServeQuantity"] = Convert.ToInt32(nudServingQuantity.Value);
            currencyManager.EndCurrentEdit();
            DM.UpdateKai();
            MessageBox.Show("Kai updated successfully", "Success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow deleteKaiRow = DM.dtKai.Rows[currencyManager.Position];
                deleteKaiRow.Delete();
                DM.UpdateEvent();
            }
        }
    }
}
