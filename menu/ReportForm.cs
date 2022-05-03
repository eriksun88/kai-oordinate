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
    ///<Summary> class: ReportForm 
    ///This form displays the ReportForm, allows the user to print out the report
    ///author: zhiyuan sun
    ///date written: 23/04/2022
    ///</Summary>
    public partial class ReportForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private int amountOfEventsChecked, totalEventsCount;
        private DataRow[] allEvents;

        ///<Summary> method: ReportForm
        ///constructor method to initialize all the component
        ///</Summary>
        public ReportForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            amountOfEventsChecked = 0;
            string strSort = "EventID";
            allEvents = DM.dsKaiOordinate.Tables["Event"].Select("", strSort, DataViewRowState.CurrentRows);
            totalEventsCount = allEvents.Length;
            prvReport.Show();
        }

        ///<Summary> method: btnReturn_Click
        ///close current form when click
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);           
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            DataRow drEvent = allEvents[amountOfEventsChecked];
            DataRow[] eventRegisterRows = DM.dtEventRegister.Select("EventID = " + drEvent["EventID"]);
            if (eventRegisterRows.Length > 0)
            {
                g.DrawString("Event ID: " + drEvent["EventID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin,
                           topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Event Name: " + drEvent["EventName"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Date: " + drEvent["EventDate"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                DataRow drLocation = GetLocationByID(drEvent["LocationID"].ToString());
                g.DrawString("Location: " + drLocation["LocationName"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString("Address: " + drLocation["Address"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("Attendees:", headingFont, brush, leftMargin + headingLeftMargin,
                           topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("FirstName" + CreateSpace(20) + "LastName" + CreateSpace(20) + "Phone NO." + CreateSpace(20) + "Helper", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;

                foreach (DataRow drEventRegister in eventRegisterRows)
                {
                    DataRow drWhanau = GetWhanauByID(drEventRegister["WhanauID"].ToString());
                    g.DrawString(drWhanau["FirstName"] + CreateSpace(20) + drWhanau["LastName"] + CreateSpace(20) +
             drWhanau["Phone"] + CreateSpace(20) + drEventRegister["KaiPreparation"], textFont, brush, leftMargin + headingLeftMargin,
            topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
                amountOfEventsChecked++;
                if (amountOfEventsChecked != totalEventsCount-1)
                {
                    if (HasRegistration(allEvents[amountOfEventsChecked]["EventID"].ToString())) 
                    {
                        e.HasMorePages = true;
                    }                   
                }
            }
        }

        private DataRow GetLocationByID(string locationID)
        {
            DataRow[] LocationRows = DM.dtLocation.Select("LocationID = " + locationID);
            return LocationRows[0];
        }

        private DataRow GetWhanauByID(string whanauID)
        {
            DataRow[] WhanauRows = DM.dtWhanau.Select("WhanauID = " + whanauID);
            return WhanauRows[0];
        }

        private bool HasRegistration(string eventID)
        {
            return DM.dtEventRegister.Select("EventID = " + eventID).Length > 0;
        }

        string CreateSpace(int length)
        {
            return new string(' ', length);
        }
    }
}
