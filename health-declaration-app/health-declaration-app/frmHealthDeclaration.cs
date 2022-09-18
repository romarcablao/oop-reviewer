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
    public partial class frmHealthDeclaration : Form
    {
        private int user_id;

        public frmHealthDeclaration(int id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void frmHealthDeclaration_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmDashboard(this.user_id, null));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool q01 = rtbYes1.Checked ? true : false;
            bool q02 = rtbYes2.Checked ? true : false;
            bool q03 = rtbYes3.Checked ? true : false;
            bool q04 = rtbYes4.Checked ? true : false;
            bool q05 = rtbYes5.Checked ? true : false;

            // call a function/method
            classConnection dbConnection = new classConnection();
            bool result = dbConnection.saveHealthDeclarationResponse(this.user_id, q01, q02, q03, q04, q05);

            if (result)
            {
                MessageBox.Show("Response saved!");
            }
            else
            {
                MessageBox.Show("Error in saving!");
            }
        }
    }
}
