
namespace menu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.btnLocations = new FontAwesome.Sharp.IconButton();
            this.btnWhanau = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnKai = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::menu.Properties.Resources.cover_500;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 148);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(582, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 99);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.Location = new System.Drawing.Point(200, 396);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(160, 99);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistration.IconColor = System.Drawing.Color.Black;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.Location = new System.Drawing.Point(12, 396);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(160, 99);
            this.btnRegistration.TabIndex = 12;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnLocations.IconColor = System.Drawing.Color.Black;
            this.btnLocations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocations.Location = new System.Drawing.Point(582, 224);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(160, 99);
            this.btnLocations.TabIndex = 11;
            this.btnLocations.Text = "LOCATIONS";
            this.btnLocations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnWhanau
            // 
            this.btnWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhanau.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnWhanau.IconColor = System.Drawing.Color.Black;
            this.btnWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhanau.Location = new System.Drawing.Point(392, 224);
            this.btnWhanau.Name = "btnWhanau";
            this.btnWhanau.Size = new System.Drawing.Size(160, 99);
            this.btnWhanau.TabIndex = 10;
            this.btnWhanau.Text = "WHANAU";
            this.btnWhanau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWhanau.UseVisualStyleBackColor = true;
            this.btnWhanau.Click += new System.EventHandler(this.btnWhanau_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvents.IconColor = System.Drawing.Color.Black;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.Location = new System.Drawing.Point(200, 224);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(160, 99);
            this.btnEvents.TabIndex = 9;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnKai
            // 
            this.btnKai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnKai.IconColor = System.Drawing.Color.Black;
            this.btnKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKai.Location = new System.Drawing.Point(12, 224);
            this.btnKai.Name = "btnKai";
            this.btnKai.Size = new System.Drawing.Size(160, 99);
            this.btnKai.TabIndex = 8;
            this.btnKai.Text = "KAI";
            this.btnKai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKai.UseVisualStyleBackColor = true;
            this.btnKai.Click += new System.EventHandler(this.btnKai_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(763, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnWhanau);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnKai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnKai;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnWhanau;
        private FontAwesome.Sharp.IconButton btnLocations;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

