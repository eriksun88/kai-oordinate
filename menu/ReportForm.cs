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
    public partial class ReportForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private int amountofReportPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;
        public ReportForm(DataModule dm, MainForm mfm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mfm;            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            amountofReportPrinted = 0;
            string strSort = "EventID";
            reportForPrint = DM.dsKaiOordinate.Tables["Event"].Select("",strSort,DataViewRowState.CurrentRows);
            pagesAmountExpected = reportForPrint.Length;
            prvReport.Show();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void printReport_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVisit = reportForPrint[amountofReportPrinted];
            CurrencyManager cmEvent;
            CurrencyManager cmLocation;
            CurrencyManager cmWhanau;
            
            double visitTotal = 0;

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Event"];
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Location"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
            
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            int aEventID = Convert.ToInt32(drVisit["EventID"].ToString());
            cmEvent.Position = DM.eventView.Find(aEventID);
            DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];

            int aLocationID = Convert.ToInt32(drVisit["LocationID"].ToString());
            cmLocation.Position = DM.eventView.Find(aLocationID);
            DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];

            int aWhanauID = Convert.ToInt32(drVisit["WhanauID"].ToString());
            cmWhanau.Position = DM.eventView.Find(aWhanauID);
            DataRow drWhanau = DM.dtWhanau.Rows[cmWhanau.Position];

            g.DrawString("Event ID: " + drEvent["EventID"], headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drEvent["EventName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                               topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drEvent["EventDate"] + "", headingFont, brush, leftMargin +headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drLocation["LocationName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drLocation["Address"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Attendees " + drWhanau["FirstName"]  +" "+ drWhanau["LastName"] + " "+
                 drWhanau["Phone NO."], headingFont, brush, leftMargin +headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;



            visitTotal = 0;
            amountofReportPrinted++;
            if (!(amountofReportPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }

        }
    }
}
