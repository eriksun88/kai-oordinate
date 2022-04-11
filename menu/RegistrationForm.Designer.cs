
namespace menu
{
    partial class RegistrationForm
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
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblWhanau = new System.Windows.Forms.Label();
            this.lblRegistrations = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.lblKaiPreparationAssitant = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.dgvWhanau = new System.Windows.Forms.DataGridView();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.ckbKaiPreparationAssitant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.White;
            this.lblEvents.Location = new System.Drawing.Point(163, 9);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(67, 24);
            this.lblEvents.TabIndex = 11;
            this.lblEvents.Text = "Events";
            // 
            // lblWhanau
            // 
            this.lblWhanau.AutoSize = true;
            this.lblWhanau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhanau.ForeColor = System.Drawing.Color.White;
            this.lblWhanau.Location = new System.Drawing.Point(569, 9);
            this.lblWhanau.Name = "lblWhanau";
            this.lblWhanau.Size = new System.Drawing.Size(81, 24);
            this.lblWhanau.TabIndex = 12;
            this.lblWhanau.Text = "Whanau";
            // 
            // lblRegistrations
            // 
            this.lblRegistrations.AutoSize = true;
            this.lblRegistrations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrations.ForeColor = System.Drawing.Color.White;
            this.lblRegistrations.Location = new System.Drawing.Point(134, 240);
            this.lblRegistrations.Name = "lblRegistrations";
            this.lblRegistrations.Size = new System.Drawing.Size(117, 24);
            this.lblRegistrations.TabIndex = 13;
            this.lblRegistrations.Text = "Registrations";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(734, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 76);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(846, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 76);
            this.btnDelete.TabIndex = 28;
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
            this.btnReturn.Location = new System.Drawing.Point(968, 362);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(84, 76);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblKaiPreparationAssitant
            // 
            this.lblKaiPreparationAssitant.AutoSize = true;
            this.lblKaiPreparationAssitant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiPreparationAssitant.ForeColor = System.Drawing.Color.White;
            this.lblKaiPreparationAssitant.Location = new System.Drawing.Point(846, 295);
            this.lblKaiPreparationAssitant.Name = "lblKaiPreparationAssitant";
            this.lblKaiPreparationAssitant.Size = new System.Drawing.Size(206, 24);
            this.lblKaiPreparationAssitant.TabIndex = 30;
            this.lblKaiPreparationAssitant.Text = "Kai Preparation Assitant";
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(12, 53);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(470, 150);
            this.dgvEvents.TabIndex = 31;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvWhanau
            // 
            this.dgvWhanau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWhanau.Location = new System.Drawing.Point(558, 53);
            this.dgvWhanau.Name = "dgvWhanau";
            this.dgvWhanau.Size = new System.Drawing.Size(677, 150);
            this.dgvWhanau.TabIndex = 32;
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Location = new System.Drawing.Point(12, 288);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.Size = new System.Drawing.Size(457, 150);
            this.dgvRegistrations.TabIndex = 33;
            // 
            // ckbKaiPreparationAssitant
            // 
            this.ckbKaiPreparationAssitant.AutoSize = true;
            this.ckbKaiPreparationAssitant.Location = new System.Drawing.Point(825, 305);
            this.ckbKaiPreparationAssitant.Name = "ckbKaiPreparationAssitant";
            this.ckbKaiPreparationAssitant.Size = new System.Drawing.Size(15, 14);
            this.ckbKaiPreparationAssitant.TabIndex = 34;
            this.ckbKaiPreparationAssitant.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1375, 494);
            this.Controls.Add(this.ckbKaiPreparationAssitant);
            this.Controls.Add(this.dgvRegistrations);
            this.Controls.Add(this.dgvWhanau);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.lblKaiPreparationAssitant);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRegistrations);
            this.Controls.Add(this.lblWhanau);
            this.Controls.Add(this.lblEvents);
            this.Name = "RegistrationForm";
            this.Text = "Registration Maintenance";
            this.Load += new System.EventHandler(this.registrationform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWhanau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblWhanau;
        private System.Windows.Forms.Label lblRegistrations;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label lblKaiPreparationAssitant;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridView dgvWhanau;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.CheckBox ckbKaiPreparationAssitant;
    }
}