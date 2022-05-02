
namespace menu
{
    partial class LocationsForm
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
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lblLocationNo = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.pnlAddLocation = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.txtAddLocationName = new System.Windows.Forms.TextBox();
            this.lblAddLocationName = new System.Windows.Forms.Label();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.pnlAddLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLocation
            // 
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.Location = new System.Drawing.Point(28, 27);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(239, 277);
            this.lstLocation.TabIndex = 1;
            // 
            // lblLocationNo
            // 
            this.lblLocationNo.AutoSize = true;
            this.lblLocationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationNo.Location = new System.Drawing.Point(344, 27);
            this.lblLocationNo.Name = "lblLocationNo";
            this.lblLocationNo.Size = new System.Drawing.Size(103, 24);
            this.lblLocationNo.TabIndex = 10;
            this.lblLocationNo.Text = "Locaiton ID";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(310, 114);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblLocationName.TabIndex = 11;
            this.lblLocationName.Text = "Location Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(367, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(453, 114);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(222, 20);
            this.txtLocationName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(453, 205);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 128);
            this.txtAddress.TabIndex = 16;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(602, 362);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(84, 76);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(460, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 76);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(370, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 76);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(280, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 76);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.Location = new System.Drawing.Point(121, 362);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(84, 76);
            this.btnDown.TabIndex = 24;
            this.btnDown.Text = "Down";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.Location = new System.Drawing.Point(22, 362);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(84, 76);
            this.btnUp.TabIndex = 23;
            this.btnUp.Text = "Up";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.Location = new System.Drawing.Point(456, 27);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(0, 24);
            this.lblLocationID.TabIndex = 29;
            // 
            // pnlAddLocation
            // 
            this.pnlAddLocation.Controls.Add(this.btnCancel);
            this.pnlAddLocation.Controls.Add(this.btnSave);
            this.pnlAddLocation.Controls.Add(this.txtAddAddress);
            this.pnlAddLocation.Controls.Add(this.lblAddAddress);
            this.pnlAddLocation.Controls.Add(this.txtAddLocationName);
            this.pnlAddLocation.Controls.Add(this.lblAddLocationName);
            this.pnlAddLocation.Location = new System.Drawing.Point(710, 26);
            this.pnlAddLocation.Name = "pnlAddLocation";
            this.pnlAddLocation.Size = new System.Drawing.Size(481, 306);
            this.pnlAddLocation.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 36;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(347, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 44);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 36;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(242, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 44);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress.Location = new System.Drawing.Point(196, 85);
            this.txtAddAddress.Multiline = true;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(222, 128);
            this.txtAddAddress.TabIndex = 31;
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAddress.Location = new System.Drawing.Point(16, 88);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddAddress.TabIndex = 31;
            this.lblAddAddress.Text = "Address";
            // 
            // txtAddLocationName
            // 
            this.txtAddLocationName.Location = new System.Drawing.Point(196, 42);
            this.txtAddLocationName.Name = "txtAddLocationName";
            this.txtAddLocationName.Size = new System.Drawing.Size(222, 20);
            this.txtAddLocationName.TabIndex = 31;
            // 
            // lblAddLocationName
            // 
            this.lblAddLocationName.AutoSize = true;
            this.lblAddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLocationName.Location = new System.Drawing.Point(16, 37);
            this.lblAddLocationName.Name = "lblAddLocationName";
            this.lblAddLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblAddLocationName.TabIndex = 31;
            this.lblAddLocationName.Text = "Location Name";
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(453, 31);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(222, 20);
            this.txtLocationID.TabIndex = 31;
            // 
            // LocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.pnlAddLocation);
            this.Controls.Add(this.lblLocationID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLocationNo);
            this.Controls.Add(this.lstLocation);
            this.Name = "LocationsForm";
            this.Text = "Locations Management";
            this.pnlAddLocation.ResumeLayout(false);
            this.pnlAddLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Label lblLocationNo;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtAddress;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Panel pnlAddLocation;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.TextBox txtAddLocationName;
        private System.Windows.Forms.Label lblAddLocationName;
        private System.Windows.Forms.TextBox txtLocationID;
    }
}