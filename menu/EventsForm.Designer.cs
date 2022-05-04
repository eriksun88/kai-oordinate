
namespace menu
{
    partial class EventsForm
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
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.lblEventNo = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.cboAddLocation = new System.Windows.Forms.ComboBox();
            this.lblAddEventName = new System.Windows.Forms.Label();
            this.txtAddEventName = new System.Windows.Forms.TextBox();
            this.lblAddLocation = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.dtpAddEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblAddEventDate = new System.Windows.Forms.Label();
            this.pnlEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.Location = new System.Drawing.Point(12, 28);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(239, 277);
            this.lstEvent.TabIndex = 0;
            // 
            // lblEventNo
            // 
            this.lblEventNo.AutoSize = true;
            this.lblEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEventNo.Location = new System.Drawing.Point(327, 62);
            this.lblEventNo.Name = "lblEventNo";
            this.lblEventNo.Size = new System.Drawing.Size(80, 24);
            this.lblEventNo.TabIndex = 9;
            this.lblEventNo.Text = "Event ID";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEventName.Location = new System.Drawing.Point(327, 123);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(114, 24);
            this.lblEventName.TabIndex = 10;
            this.lblEventName.Text = "Event Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocation.Location = new System.Drawing.Point(327, 181);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(81, 24);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEventDate.Location = new System.Drawing.Point(327, 242);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(101, 24);
            this.lblEventDate.TabIndex = 12;
            this.lblEventDate.Text = "Event Date";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(449, 120);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(146, 29);
            this.txtEventName.TabIndex = 14;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(449, 178);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(146, 29);
            this.txtLocation.TabIndex = 15;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.Location = new System.Drawing.Point(35, 352);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(84, 76);
            this.btnUp.TabIndex = 17;
            this.btnUp.Text = "Up";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.Location = new System.Drawing.Point(134, 352);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(84, 76);
            this.btnDown.TabIndex = 18;
            this.btnDown.Text = "Down";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(293, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 76);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(383, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 76);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(473, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 76);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(615, 352);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(84, 76);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.Location = new System.Drawing.Point(443, 62);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(0, 24);
            this.lblEventID.TabIndex = 23;
            // 
            // txtEventDate
            // 
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDate.Location = new System.Drawing.Point(449, 239);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(146, 29);
            this.txtEventDate.TabIndex = 27;
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(449, 57);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(146, 29);
            this.txtEventID.TabIndex = 28;
            // 
            // pnlEvent
            // 
            this.pnlEvent.Controls.Add(this.cboAddLocation);
            this.pnlEvent.Controls.Add(this.lblAddEventName);
            this.pnlEvent.Controls.Add(this.txtAddEventName);
            this.pnlEvent.Controls.Add(this.lblAddLocation);
            this.pnlEvent.Controls.Add(this.btnCancel);
            this.pnlEvent.Controls.Add(this.dtpAddEventDate);
            this.pnlEvent.Controls.Add(this.btnSave);
            this.pnlEvent.Controls.Add(this.lblAddEventDate);
            this.pnlEvent.Location = new System.Drawing.Point(280, 19);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(407, 286);
            this.pnlEvent.TabIndex = 29;
            this.pnlEvent.Visible = false;
            // 
            // cboAddLocation
            // 
            this.cboAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAddLocation.FormattingEnabled = true;
            this.cboAddLocation.Location = new System.Drawing.Point(186, 85);
            this.cboAddLocation.Name = "cboAddLocation";
            this.cboAddLocation.Size = new System.Drawing.Size(143, 32);
            this.cboAddLocation.TabIndex = 44;
            // 
            // lblAddEventName
            // 
            this.lblAddEventName.AutoSize = true;
            this.lblAddEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddEventName.Location = new System.Drawing.Point(43, 47);
            this.lblAddEventName.Name = "lblAddEventName";
            this.lblAddEventName.Size = new System.Drawing.Size(114, 24);
            this.lblAddEventName.TabIndex = 40;
            this.lblAddEventName.Text = "Event Name";
            // 
            // txtAddEventName
            // 
            this.txtAddEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEventName.Location = new System.Drawing.Point(186, 43);
            this.txtAddEventName.Name = "txtAddEventName";
            this.txtAddEventName.Size = new System.Drawing.Size(146, 29);
            this.txtAddEventName.TabIndex = 41;
            // 
            // lblAddLocation
            // 
            this.lblAddLocation.AutoSize = true;
            this.lblAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddLocation.Location = new System.Drawing.Point(43, 88);
            this.lblAddLocation.Name = "lblAddLocation";
            this.lblAddLocation.Size = new System.Drawing.Size(81, 24);
            this.lblAddLocation.TabIndex = 39;
            this.lblAddLocation.Text = "Location";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 36;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(284, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 44);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpAddEventDate
            // 
            this.dtpAddEventDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAddEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddEventDate.Location = new System.Drawing.Point(186, 126);
            this.dtpAddEventDate.Name = "dtpAddEventDate";
            this.dtpAddEventDate.Size = new System.Drawing.Size(181, 29);
            this.dtpAddEventDate.TabIndex = 37;
            this.dtpAddEventDate.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 36;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(159, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 44);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddEventDate
            // 
            this.lblAddEventDate.AutoSize = true;
            this.lblAddEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEventDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddEventDate.Location = new System.Drawing.Point(43, 130);
            this.lblAddEventDate.Name = "lblAddEventDate";
            this.lblAddEventDate.Size = new System.Drawing.Size(101, 24);
            this.lblAddEventDate.TabIndex = 38;
            this.lblAddEventDate.Text = "Event Date";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.pnlEvent);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventNo);
            this.Controls.Add(this.lstEvent);
            this.Name = "EventsForm";
            this.Text = "Event Management";
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Label lblEventNo;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtLocation;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.ComboBox cboAddLocation;
        private System.Windows.Forms.Label lblAddEventName;
        private System.Windows.Forms.TextBox txtAddEventName;
        private System.Windows.Forms.Label lblAddLocation;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.DateTimePicker dtpAddEventDate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label lblAddEventDate;
    }
}