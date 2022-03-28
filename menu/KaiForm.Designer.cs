
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
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lblKaiID = new System.Windows.Forms.Label();
            this.cbxPreparationRequired = new System.Windows.Forms.CheckBox();
            this.nudPreparationTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).BeginInit();
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
            this.lblServingQuantity.Click += new System.EventHandler(this.lblServingQuantity_Click);
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
            // txtServingQuantity
            // 
            this.txtServingQuantity.Location = new System.Drawing.Point(527, 286);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.Size = new System.Drawing.Size(146, 20);
            this.txtServingQuantity.TabIndex = 12;
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
            // cbxPreparationRequired
            // 
            this.cbxPreparationRequired.AutoSize = true;
            this.cbxPreparationRequired.Location = new System.Drawing.Point(530, 191);
            this.cbxPreparationRequired.Name = "cbxPreparationRequired";
            this.cbxPreparationRequired.Size = new System.Drawing.Size(15, 14);
            this.cbxPreparationRequired.TabIndex = 20;
            this.cbxPreparationRequired.UseVisualStyleBackColor = true;
            // 
            // nudPreparationTime
            // 
            this.nudPreparationTime.Location = new System.Drawing.Point(527, 233);
            this.nudPreparationTime.Name = "nudPreparationTime";
            this.nudPreparationTime.Size = new System.Drawing.Size(120, 20);
            this.nudPreparationTime.TabIndex = 21;
            // 
            // KaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudPreparationTime);
            this.Controls.Add(this.cbxPreparationRequired);
            this.Controls.Add(this.lblKaiID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtServingQuantity);
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
            this.Text = "Kai Management";
            this.Load += new System.EventHandler(this.KaiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPreparationTime)).EndInit();
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
        private System.Windows.Forms.TextBox txtServingQuantity;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label lblKaiID;
        private System.Windows.Forms.CheckBox cbxPreparationRequired;
        private System.Windows.Forms.NumericUpDown nudPreparationTime;
    }
}