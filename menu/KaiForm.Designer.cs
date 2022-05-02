
namespace menu
{
    partial class KaiForm
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
            this.lstKai = new System.Windows.Forms.ListBox();
            this.lblKaiNo = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblServingQuantity = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lblKaiID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKaiID = new System.Windows.Forms.TextBox();
            this.txtPreparationRequired = new System.Windows.Forms.TextBox();
            this.txtPreparationTime = new System.Windows.Forms.TextBox();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.pnlAddKai = new System.Windows.Forms.Panel();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.nudAddServingQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudAddPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.cbxAddPreparationRequired = new System.Windows.Forms.CheckBox();
            this.txtAddKaiName = new System.Windows.Forms.TextBox();
            this.cboAddEvent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAddKai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddServingQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPreparationTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lstKai
            // 
            this.lstKai.FormattingEnabled = true;
            this.lstKai.Location = new System.Drawing.Point(21, 28);
            this.lstKai.Name = "lstKai";
            this.lstKai.Size = new System.Drawing.Size(242, 277);
            this.lstKai.TabIndex = 0;
            // 
            // lblKaiNo
            // 
            this.lblKaiNo.AutoSize = true;
            this.lblKaiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiNo.Location = new System.Drawing.Point(432, 41);
            this.lblKaiNo.Name = "lblKaiNo";
            this.lblKaiNo.Size = new System.Drawing.Size(58, 24);
            this.lblKaiNo.TabIndex = 1;
            this.lblKaiNo.Text = "Kai ID";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(432, 90);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 24);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event";
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiName.Location = new System.Drawing.Point(398, 136);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(92, 24);
            this.lblKaiName.TabIndex = 3;
            this.lblKaiName.Text = "Kai Name";
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparation.Location = new System.Drawing.Point(296, 184);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(194, 24);
            this.lblPreparation.TabIndex = 4;
            this.lblPreparation.Text = "Preparation Required ";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTime.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPreparationTime.Location = new System.Drawing.Point(343, 233);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTime.TabIndex = 5;
            this.lblPreparationTime.Text = "Preparation Time";
            // 
            // lblServingQuantity
            // 
            this.lblServingQuantity.AutoSize = true;
            this.lblServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQuantity.Location = new System.Drawing.Point(343, 281);
            this.lblServingQuantity.Name = "lblServingQuantity";
            this.lblServingQuantity.Size = new System.Drawing.Size(147, 24);
            this.lblServingQuantity.TabIndex = 6;
            this.lblServingQuantity.Text = "Serving Quantity";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(527, 95);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(146, 20);
            this.txtEvent.TabIndex = 8;
            // 
            // txtKaiName
            // 
            this.txtKaiName.Location = new System.Drawing.Point(527, 141);
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.Size = new System.Drawing.Size(146, 20);
            this.txtKaiName.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(470, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 76);
            this.btnDelete.TabIndex = 18;
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
            this.btnUpdate.Location = new System.Drawing.Point(380, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 76);
            this.btnUpdate.TabIndex = 17;
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
            this.btnAdd.Location = new System.Drawing.Point(290, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 76);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.Location = new System.Drawing.Point(617, 349);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(84, 76);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.Location = new System.Drawing.Point(121, 349);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(84, 76);
            this.btnDown.TabIndex = 14;
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
            this.btnUp.Location = new System.Drawing.Point(21, 349);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(84, 76);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Up";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblKaiID
            // 
            this.lblKaiID.AutoSize = true;
            this.lblKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiID.Location = new System.Drawing.Point(523, 41);
            this.lblKaiID.Name = "lblKaiID";
            this.lblKaiID.Size = new System.Drawing.Size(0, 24);
            this.lblKaiID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // txtKaiID
            // 
            this.txtKaiID.Location = new System.Drawing.Point(527, 41);
            this.txtKaiID.Name = "txtKaiID";
            this.txtKaiID.Size = new System.Drawing.Size(146, 20);
            this.txtKaiID.TabIndex = 25;
            // 
            // txtPreparationRequired
            // 
            this.txtPreparationRequired.Location = new System.Drawing.Point(527, 184);
            this.txtPreparationRequired.Name = "txtPreparationRequired";
            this.txtPreparationRequired.Size = new System.Drawing.Size(146, 20);
            this.txtPreparationRequired.TabIndex = 26;
            // 
            // txtPreparationTime
            // 
            this.txtPreparationTime.Location = new System.Drawing.Point(527, 238);
            this.txtPreparationTime.Name = "txtPreparationTime";
            this.txtPreparationTime.Size = new System.Drawing.Size(146, 20);
            this.txtPreparationTime.TabIndex = 27;
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.Location = new System.Drawing.Point(527, 286);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.Size = new System.Drawing.Size(146, 20);
            this.txtServingQuantity.TabIndex = 28;
            // 
            // pnlAddKai
            // 
            this.pnlAddKai.Controls.Add(this.lblMinutes);
            this.pnlAddKai.Controls.Add(this.btnCancel);
            this.pnlAddKai.Controls.Add(this.btnSave);
            this.pnlAddKai.Controls.Add(this.nudAddServingQuantity);
            this.pnlAddKai.Controls.Add(this.nudAddPreparationTime);
            this.pnlAddKai.Controls.Add(this.cbxAddPreparationRequired);
            this.pnlAddKai.Controls.Add(this.txtAddKaiName);
            this.pnlAddKai.Controls.Add(this.cboAddEvent);
            this.pnlAddKai.Controls.Add(this.label2);
            this.pnlAddKai.Controls.Add(this.label3);
            this.pnlAddKai.Controls.Add(this.label4);
            this.pnlAddKai.Controls.Add(this.label5);
            this.pnlAddKai.Controls.Add(this.label6);
            this.pnlAddKai.Location = new System.Drawing.Point(743, 28);
            this.pnlAddKai.Name = "pnlAddKai";
            this.pnlAddKai.Size = new System.Drawing.Size(447, 307);
            this.pnlAddKai.TabIndex = 29;
            this.pnlAddKai.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(352, 164);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(76, 24);
            this.lblMinutes.TabIndex = 35;
            this.lblMinutes.Text = "minutes";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 36;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(308, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 44);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 36;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(203, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 44);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudAddServingQuantity
            // 
            this.nudAddServingQuantity.Location = new System.Drawing.Point(244, 212);
            this.nudAddServingQuantity.Name = "nudAddServingQuantity";
            this.nudAddServingQuantity.Size = new System.Drawing.Size(86, 20);
            this.nudAddServingQuantity.TabIndex = 33;
            // 
            // nudAddPreparationTime
            // 
            this.nudAddPreparationTime.Location = new System.Drawing.Point(244, 164);
            this.nudAddPreparationTime.Name = "nudAddPreparationTime";
            this.nudAddPreparationTime.Size = new System.Drawing.Size(86, 20);
            this.nudAddPreparationTime.TabIndex = 32;
            // 
            // cbxAddPreparationRequired
            // 
            this.cbxAddPreparationRequired.AutoSize = true;
            this.cbxAddPreparationRequired.Location = new System.Drawing.Point(237, 111);
            this.cbxAddPreparationRequired.Name = "cbxAddPreparationRequired";
            this.cbxAddPreparationRequired.Size = new System.Drawing.Size(15, 14);
            this.cbxAddPreparationRequired.TabIndex = 31;
            this.cbxAddPreparationRequired.UseVisualStyleBackColor = true;
            // 
            // txtAddKaiName
            // 
            this.txtAddKaiName.Location = new System.Drawing.Point(238, 66);
            this.txtAddKaiName.Name = "txtAddKaiName";
            this.txtAddKaiName.Size = new System.Drawing.Size(146, 20);
            this.txtAddKaiName.TabIndex = 30;
            // 
            // cboAddEvent
            // 
            this.cboAddEvent.FormattingEnabled = true;
            this.cboAddEvent.Location = new System.Drawing.Point(238, 19);
            this.cboAddEvent.Name = "cboAddEvent";
            this.cboAddEvent.Size = new System.Drawing.Size(155, 21);
            this.cboAddEvent.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Serving Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(68, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preparation Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preparation Required ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kai Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Event";
            // 
            // KaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1335, 450);
            this.Controls.Add(this.pnlAddKai);
            this.Controls.Add(this.txtServingQuantity);
            this.Controls.Add(this.txtPreparationTime);
            this.Controls.Add(this.txtPreparationRequired);
            this.Controls.Add(this.txtKaiID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKaiID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtKaiName);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblServingQuantity);
            this.Controls.Add(this.lblPreparationTime);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.lblKaiName);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblKaiNo);
            this.Controls.Add(this.lstKai);
            this.Name = "KaiForm";
            this.Text = "0";
            this.pnlAddKai.ResumeLayout(false);
            this.pnlAddKai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddServingQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPreparationTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKai;
        private System.Windows.Forms.Label lblKaiNo;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblServingQuantity;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtKaiName;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label lblKaiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKaiID;
        private System.Windows.Forms.TextBox txtPreparationRequired;
        private System.Windows.Forms.TextBox txtPreparationTime;
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.Panel pnlAddKai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxAddPreparationRequired;
        private System.Windows.Forms.TextBox txtAddKaiName;
        private System.Windows.Forms.ComboBox cboAddEvent;
        private System.Windows.Forms.Label lblMinutes;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.NumericUpDown nudAddServingQuantity;
        private System.Windows.Forms.NumericUpDown nudAddPreparationTime;
    }
}