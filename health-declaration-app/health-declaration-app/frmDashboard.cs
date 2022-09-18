using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_declaration_app
{
    public partial class frmDashboard : Form
    {
        private int user_id;
        private string user_name;

        public frmDashboard(int id, string name)
        {
            InitializeComponent();
            this.user_id = id;
            this.user_name = name;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadReport();
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

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmBooking(this.user_id));
        }

        private void btnSubmitHealthDeclaration_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmHealthDeclaration(this.user_id));
        }

        private void btnDownloadReports_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmSaveReport(this.user_id));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmLogin());
        }
    }
}
