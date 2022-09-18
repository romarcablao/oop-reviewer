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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void navigate(Form frm)
        {
            this.Hide();
            frm.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            navigate(new frmRegistration());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // call login function/method
            classConnection dbConnection = new classConnection();
            structUser user = dbConnection.userLogin(txtUsername.Text, txtPassword.Text);

            if (user.id > 0)
            {
                navigate(new frmDashboard(user.id, user.name));
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
    }
}
