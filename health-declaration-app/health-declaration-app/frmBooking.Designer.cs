namespace health_declaration_app
{
    partial class frmBooking
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
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbRoom101 = new System.Windows.Forms.RadioButton();
            this.rtbRoom102 = new System.Windows.Forms.RadioButton();
            this.rtbRoom103 = new System.Windows.Forms.RadioButton();
            this.rtbRoom203 = new System.Windows.Forms.RadioButton();
            this.rtbRoom202 = new System.Windows.Forms.RadioButton();
            this.rtbRoom201 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.grpOffice = new System.Windows.Forms.GroupBox();
            this.grpOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(794, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbRoom101
            // 
            this.rtbRoom101.AutoSize = true;
            this.rtbRoom101.Location = new System.Drawing.Point(24, 37);
            this.rtbRoom101.Name = "rtbRoom101";
            this.rtbRoom101.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom101.TabIndex = 7;
            this.rtbRoom101.TabStop = true;
            this.rtbRoom101.Text = "OFFICE 1 - RM 101";
            this.rtbRoom101.UseVisualStyleBackColor = true;
            // 
            // rtbRoom102
            // 
            this.rtbRoom102.AutoSize = true;
            this.rtbRoom102.Location = new System.Drawing.Point(24, 82);
            this.rtbRoom102.Name = "rtbRoom102";
            this.rtbRoom102.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom102.TabIndex = 8;
            this.rtbRoom102.TabStop = true;
            this.rtbRoom102.Text = "OFFICE 1 - RM 102";
            this.rtbRoom102.UseVisualStyleBackColor = true;
            // 
            // rtbRoom103
            // 
            this.rtbRoom103.AutoSize = true;
            this.rtbRoom103.Location = new System.Drawing.Point(24, 132);
            this.rtbRoom103.Name = "rtbRoom103";
            this.rtbRoom103.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom103.TabIndex = 9;
            this.rtbRoom103.TabStop = true;
            this.rtbRoom103.Text = "OFFICE 1 - RM 103";
            this.rtbRoom103.UseVisualStyleBackColor = true;
            // 
            // rtbRoom203
            // 
            this.rtbRoom203.AutoSize = true;
            this.rtbRoom203.Location = new System.Drawing.Point(324, 132);
            this.rtbRoom203.Name = "rtbRoom203";
            this.rtbRoom203.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom203.TabIndex = 12;
            this.rtbRoom203.TabStop = true;
            this.rtbRoom203.Text = "OFFICE 2 - RM 203";
            this.rtbRoom203.UseVisualStyleBackColor = true;
            // 
            // rtbRoom202
            // 
            this.rtbRoom202.AutoSize = true;
            this.rtbRoom202.Location = new System.Drawing.Point(324, 82);
            this.rtbRoom202.Name = "rtbRoom202";
            this.rtbRoom202.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom202.TabIndex = 11;
            this.rtbRoom202.TabStop = true;
            this.rtbRoom202.Text = "OFFICE 2 - RM 202";
            this.rtbRoom202.UseVisualStyleBackColor = true;
            // 
            // rtbRoom201
            // 
            this.rtbRoom201.AutoSize = true;
            this.rtbRoom201.Location = new System.Drawing.Point(324, 37);
            this.rtbRoom201.Name = "rtbRoom201";
            this.rtbRoom201.Size = new System.Drawing.Size(151, 21);
            this.rtbRoom201.TabIndex = 10;
            this.rtbRoom201.TabStop = true;
            this.rtbRoom201.Text = "OFFICE 2 - RM 201";
            this.rtbRoom201.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Schedule a Visit";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(603, 404);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(176, 37);
            this.btnBook.TabIndex = 15;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(542, 116);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(247, 22);
            this.dtpSchedule.TabIndex = 16;
            // 
            // grpOffice
            // 
            this.grpOffice.Controls.Add(this.rtbRoom101);
            this.grpOffice.Controls.Add(this.rtbRoom102);
            this.grpOffice.Controls.Add(this.rtbRoom103);
            this.grpOffice.Controls.Add(this.rtbRoom201);
            this.grpOffice.Controls.Add(this.rtbRoom202);
            this.grpOffice.Controls.Add(this.rtbRoom203);
            this.grpOffice.Location = new System.Drawing.Point(217, 152);
            this.grpOffice.Name = "grpOffice";
            this.grpOffice.Size = new System.Drawing.Size(572, 180);
            this.grpOffice.TabIndex = 17;
            this.grpOffice.TabStop = false;
            this.grpOffice.Text = "Please select the office to visit";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.grpOffice);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking An Appointment";
            this.grpOffice.ResumeLayout(false);
            this.grpOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rtbRoom101;
        private System.Windows.Forms.RadioButton rtbRoom102;
        private System.Windows.Forms.RadioButton rtbRoom103;
        private System.Windows.Forms.RadioButton rtbRoom203;
        private System.Windows.Forms.RadioButton rtbRoom202;
        private System.Windows.Forms.RadioButton rtbRoom201;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.GroupBox grpOffice;
    }
}