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

        ///<Summary> method: btnGenerateReport_Click
        ///open the report when click
        ///</Summary>
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

        ///<Summary> method: printReport_PrintPage
        ///populate the page data
        ///</Summary>
        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int FirstNameAT = 0, LastNameAT = 150, PhoneAt = 300, HelperAt = 450;
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);           
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;      
            DataRow drEvent = allEvents[amountOfEventsChecked];
            DataRow[] eventRegisterRows = DM.dtEventRegister.Select("EventID = " + drEvent["EventID"]);
            if (eventRegisterRows.Length > 0)
            {
                g.DrawString("Event ID: " + drEvent["EventID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin,
                           topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("Event Name: " + drEvent["EventName"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("Date: " + Convert.ToDateTime(drEvent["EventDate"]).ToString("dd/MM/yyyy"), headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;

                DataRow drLocation = GetLocationByID(drEvent["LocationID"].ToString());
                g.DrawString("Location: " + drLocation["LocationName"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("Address: " + drLocation["Address"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("Attendees:", headingFont, brush, leftMargin + headingLeftMargin,
                           topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;
                g.DrawString("FirstName", headingFont, brush, leftMargin + headingLeftMargin + FirstNameAT, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString("LastName", headingFont, brush, leftMargin + headingLeftMargin + LastNameAT, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString("Phone NO.", headingFont, brush, leftMargin + headingLeftMargin + PhoneAt, topMargin + (linesSoFarHeading * textFont.Height));
                g.DrawString("Helper", headingFont, brush, leftMargin + headingLeftMargin + HelperAt, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading = linesSoFarHeading + 2;

                foreach (DataRow drEventRegister in eventRegisterRows)
                {
                    DataRow drWhanau = GetWhanauByID(drEventRegister["WhanauID"].ToString());
                    g.DrawString(drWhanau["FirstName"].ToString(), textFont, brush, leftMargin + headingLeftMargin + FirstNameAT,
                    topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(drWhanau["LastName"].ToString(), textFont, brush, leftMargin + headingLeftMargin + LastNameAT,
                    topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(drWhanau["Phone"].ToString(), textFont, brush, leftMargin + headingLeftMargin + PhoneAt,
                    topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(drEventRegister["KaiPreparation"].ToString(), textFont, brush, leftMargin + headingLeftMargin + HelperAt,
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
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
            }
        }
        ///<Summary> method: GetLocationByID
        ///get location data by provided ID
        ///</Summary>
        private DataRow GetLocationByID(string locationID)
        {
            DataRow[] LocationRows = DM.dtLocation.Select("LocationID = " + locationID);
            return LocationRows[0];
        }
        ///<Summary> method: GetWhanauByID
        ///get Whanau data by provided ID
        ///</Summary>
        private DataRow GetWhanauByID(string whanauID)
        {
            DataRow[] WhanauRows = DM.dtWhanau.Select("WhanauID = " + whanauID);
            return WhanauRows[0];
        }
        ///<Summary> method: HasRegistration
        ///check whether any event Registration reference to provided event ID
        ///</Summary>
        private bool HasRegistration(string eventID)
        {
            return DM.dtEventRegister.Select("EventID = " + eventID).Length > 0;
        }
        ///<Summary> method: CreateSpace
        ///generate an empty string of provided length
        ///</Summary>
        string CreateSpace(int length)
        {
            return new string(' ', length);
        }
    }
}
