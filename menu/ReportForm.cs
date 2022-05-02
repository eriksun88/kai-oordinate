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
        private int amountofReportPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;

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
            amountofReportPrinted = 0;
            string strSort = "EventID";
            reportForPrint = DM.dsKaiOordinate.Tables["Event"].Select("", strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = reportForPrint.Length;
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
            g.DrawString(drEvent["EventDate"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drLocation["LocationName"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drLocation["Address"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                              topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Attendees " + drWhanau["\nFirstName"] + " " + drWhanau["LastName"] + " " +
                 drWhanau["Phone NO."], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            visitTotal += Convert.ToDouble(drWhanau[""]);


            /*DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);
            if (drTreatments.Length == 0)
            {
                g.DrawString("This visit has no treatments", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drVisitTreatment in drTreatments)
                {
                    string treatmentText = "";
                    int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                    cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                    DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];
                    double treatmentCost;
                    treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                    Convert.ToDouble(drTreatment["Cost"]);
                    visitTotal += treatmentCost;
                    txtInvoices.Text += treatmentText;
                    g.DrawString("tTreatment Description: " + drTreatment["Description"]
                    + "tQuantity: " + drVisitTreatment["Quantity"]
                    + "tTreatment Cost: " + Convert.ToString(treatmentCost), headingFont, brush,
                    leftMargin + headingLeftMargin, topMargin +
                    (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;

                }
                linesSoFarHeading++;
                g.DrawString("Gross Due: " + Convert.ToString(visitTotal), headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            visitTotal = 0;
            amountofReportPrinted++;
            if (!(amountofReportPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }*/
        }
    }
}
