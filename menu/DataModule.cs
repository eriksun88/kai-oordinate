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
    ///<Summary> class: DataModule 
    ///database setup
    ///author: zhiyuan sun
    ///date written: 25/04/2022
    ///</Summary>
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

        ///<Summary> method: DataModule
        ///constructor method to initialize all the component
        ///</Summary>
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
        ///<Summary> method: UpdateKai
        ///update kai table data
        ///</Summary>
        public void UpdateKai()
        {
            daKai.Update(dtKai);
        }
        ///<Summary> method: UpdateEvent
        ///update Event table data
        ///</Summary>
        public void UpdateEvent()
        {
            daEvent.Update(dtEvent);
        }
        ///<Summary> method: UpdateLocation
        ///update Location table data
        ///</Summary>
        public void UpdateLocation()
        {
            daLocation.Update(dtLocation);
        }
        ///<Summary> method: UpdateWhanau
        ///update Whanau table data
        ///</Summary>
        public void UpdateWhanau()
        {
            daWhanau.Update(dtWhanau);
        }
        ///<Summary> method: UpdateEventRegister
        ///update EventRegister table data
        ///</Summary>
        public void UpdateEventRegister()
        {
            daEventRegister.Update(dtEventRegister);
        }
    }
}
