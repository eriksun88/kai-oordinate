
namespace menu
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnGenerateReport = new FontAwesome.Sharp.IconButton();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.prvReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(477, 172);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 109);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnGenerateReport.IconColor = System.Drawing.Color.Black;
            this.btnGenerateReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateReport.Location = new System.Drawing.Point(211, 172);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(98, 109);
            this.btnGenerateReport.TabIndex = 31;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // prvReport
            // 
            this.prvReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prvReport.Document = this.printReport;
            this.prvReport.Enabled = true;
            this.prvReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prvReport.Icon")));
            this.prvReport.Name = "prvReport";
            this.prvReport.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnReturn);
            this.Name = "ReportForm";
            this.Text = "Report Preview";
            
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnGenerateReport;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog prvReport;
    }
}