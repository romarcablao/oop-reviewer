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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmLogin());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // call a function/method
            classConnection dbConnection = new classConnection();
            bool result = dbConnection.userRegistration(txtName.Text, DateTime.Parse(dtpDateOfBirth.Text), txtUsername.Text, txtPassword.Text);
            if (result) {
                MessageBox.Show("User Details Saved Successfully!");
                classMisc frm = new classMisc();
                frm.frmNavigate(this, new frmLogin());
            }
            else
            {
                MessageBox.Show("There is an error saving!");
            }
        }
    }
}
