using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_declaration_app
{
    public partial class frmSaveReport : Form
    {
        private int user_id;
        public frmSaveReport(int id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void frmSaveReport_Load(object sender, EventArgs e)
        {
            LoadReport();
            txtLocation.Text = "D:\\DICT\\health-declaration-app\\reports";
        }
        public void Record_LoadHeader_Report()
        {
            lvwReport.FullRowSelect = true;
            lvwReport.MultiSelect = false;
            lvwReport.View = View.Details;
            lvwReport.Columns.Clear();
            lvwReport.Items.Clear();
            lvwReport.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvwReport.Columns.Add("NAME", 200, HorizontalAlignment.Left);
            lvwReport.Columns.Add("OFFICE ROOM NO", 200, HorizontalAlignment.Left);
            lvwReport.Columns.Add("DATE", 200, HorizontalAlignment.Left);
        }

        public void LoadReport()
        {
            Record_LoadHeader_Report();

            classConnection dbConnection = new classConnection();
            List<structReportView> items = dbConnection.getListOfAppointments(this.user_id);

            foreach (structReportView item in items)
            {
                ListViewItem lv = new ListViewItem(item.id.ToString());
                lv.SubItems.Add(item.name);
                lv.SubItems.Add(item.room_no);
                lv.SubItems.Add(item.date.ToString("dd/MM/yyyy"));
                lvwReport.Items.Add(lv);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmDashboard(this.user_id, null));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = txtLocation.Text + "\\report-" + this.user_id.ToString() + ".csv";
            classConnection dbConnection = new classConnection();
            List<structReportView> report = dbConnection.getListOfAppointments(this.user_id);

            if (Directory.Exists(Path.GetDirectoryName(file)))
            {
                using (var data = new StreamWriter(file, true))
                {
                    data.WriteLine("ID, Name, Room, Date");
                    foreach(structReportView item in report)
                    {
                        data.WriteLine(item.id.ToString() + ", " + item.name + ", " + item.room_no + ", " + item.date);
                    }
                }

                Process.Start(file);
            }
            else
            {
                MessageBox.Show("File not exists!");
            }
        }
    }
}
