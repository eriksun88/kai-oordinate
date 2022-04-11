using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace menu
{
    public partial class DataModule : Form
    {
        public DataTable dtEvent;
        public DataTable dtEventRegister;
        public DataTable dtKai;
        public DataTable dtLocation;
        public DataTable dtWhanau;
       
        public DataView eventView;
        public DataView eventRigisterView;
        public DataView kaiView;
        public DataView locationView;
        public DataView whanauView;
        
        public DataModule()
        {
            InitializeComponent();
            dsKaiOordinate.EnforceConstraints = false;
            daEvent.Fill(dsKaiOordinate);
            daEventRegister.Fill(dsKaiOordinate);
            daKai.Fill(dsKaiOordinate);
            daLocation.Fill(dsKaiOordinate);
            daWhanau.Fill(dsKaiOordinate);
            dtEvent = dsKaiOordinate.Tables["Event"];
            dtEventRegister = dsKaiOordinate.Tables["EventRegister"];
            dtKai = dsKaiOordinate.Tables["Kai"];
            dtLocation = dsKaiOordinate.Tables["Location"];
            dtWhanau = dsKaiOordinate.Tables["Whanau"];
            eventView = new DataView(dtEvent);
            eventView.Sort = "EventID";
            eventRigisterView = new DataView(dtEventRegister);
            eventRigisterView.Sort = "RegistrationID";
            kaiView = new DataView(dtKai);
            kaiView.Sort = "KaiID";
            locationView = new DataView(dtLocation);
            locationView.Sort = "LocationID";
            whanauView = new DataView(dtWhanau);
            whanauView.Sort = "WhanauID";
            dsKaiOordinate.EnforceConstraints = true;
        }
        public void UpdateKai()
        {
            daKai.Update(dtKai);
        }
        public void UpdateEvent()
        {
            daEvent.Update(dtEvent);
        }
        public void UpdateLocation()
        {
            daLocation.Update(dtLocation);
        }
        public void UpdateWhanau()
        {
            daWhanau.Update(dtWhanau);
        }
        public void UpdateEventRegister()
        {
            daEventRegister.Update(dtEventRegister);
        }
        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daEvent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }
    }
}
