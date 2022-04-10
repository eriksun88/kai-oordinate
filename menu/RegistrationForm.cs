﻿using System;
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
    public partial class RegistrationForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        
        private CurrencyManager cmEvents;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistrations;
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
    

        private void registrationform_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void BindControls()
        {
            dgvEvents.DataSource = DM.dsKaiOordinate;
            dgvEvents.DataMember = "Event";
            dgvWhanau.DataSource = DM.dsKaiOordinate;
            dgvWhanau.DataMember = "Whanau";
            dgvRegistrations.DataSource = DM.dsKaiOordinate;
            dgvRegistrations.DataMember = "EventRegister";

        }
    }
}
