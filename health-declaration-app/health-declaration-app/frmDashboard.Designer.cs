namespace health_declaration_app
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lvwReport = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnSubmitHealthDeclaration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDownloadReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwReport
            // 
            this.lvwReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.RoomNo});
            this.lvwReport.Location = new System.Drawing.Point(298, 52);
            this.lvwReport.Name = "lvwReport";
            this.lvwReport.Size = new System.Drawing.Size(637, 345);
            this.lvwReport.TabIndex = 3;
            this.lvwReport.UseCompatibleStateImageBehavior = false;
            this.lvwReport.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Appointments";
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(45, 230);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(209, 37);
            this.btnBookAppointment.TabIndex = 5;
            this.btnBookAppointment.Text = "Book an Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnSubmitHealthDeclaration
            // 
            this.btnSubmitHealthDeclaration.Location = new System.Drawing.Point(45, 273);
            this.btnSubmitHealthDeclaration.Name = "btnSubmitHealthDeclaration";
            this.btnSubmitHealthDeclaration.Size = new System.Drawing.Size(209, 37);
            this.btnSubmitHealthDeclaration.TabIndex = 6;
            this.btnSubmitHealthDeclaration.Text = "Submit Health Declaration";
            this.btnSubmitHealthDeclaration.UseVisualStyleBackColor = true;
            this.btnSubmitHealthDeclaration.Click += new System.EventHandler(this.btnSubmitHealthDeclaration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnDownloadReports
            // 
            this.btnDownloadReports.Location = new System.Drawing.Point(45, 316);
            this.btnDownloadReports.Name = "btnDownloadReports";
            this.btnDownloadReports.Size = new System.Drawing.Size(209, 37);
            this.btnDownloadReports.TabIndex = 9;
            this.btnDownloadReports.Text = "Download Reports";
            this.btnDownloadReports.UseVisualStyleBackColor = true;
            this.btnDownloadReports.Click += new System.EventHandler(this.btnDownloadReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(45, 360);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(209, 37);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDownloadReports);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmitHealthDeclaration);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwReport);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwReport;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader RoomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnSubmitHealthDeclaration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDownloadReports;
        private System.Windows.Forms.Button btnLogout;
    }
}