using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_app
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void Record_LoadHeader_Report()
        {
            lvwUsers.FullRowSelect = true;
            lvwUsers.MultiSelect = false;
            lvwUsers.View = View.Details;
            lvwUsers.Columns.Clear();
            lvwUsers.Items.Clear();
            lvwUsers.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvwUsers.Columns.Add("FIRSTNAME", 100, HorizontalAlignment.Left);
            lvwUsers.Columns.Add("LASTNAME", 100, HorizontalAlignment.Left);
            lvwUsers.Columns.Add("DOB", 100, HorizontalAlignment.Left);
            lvwUsers.Columns.Add("USERNAME", 100, HorizontalAlignment.Left);
            lvwUsers.Columns.Add("PASSWORD", 0, HorizontalAlignment.Left);
        }

        public void LoadReport()
        {
            Record_LoadHeader_Report();

            List<structUser> users = new User().getUser();

            foreach (structUser user in users)
            {
                ListViewItem lv = new ListViewItem(user.id.ToString());
                lv.SubItems.Add(user.firstname);
                lv.SubItems.Add(user.lastname);
                lv.SubItems.Add(user.dob.ToString("dd/MM/yyyy"));
                lv.SubItems.Add(user.username);
                lv.SubItems.Add(user.password);
                lvwUsers.Items.Add(lv);
            }
        }

        private void lvwUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwUsers.SelectedItems.Count == 1)
            {
                txtID.Text = lvwUsers.SelectedItems[0].SubItems[0].Text;
                txtFirstname.Text = lvwUsers.SelectedItems[0].SubItems[1].Text;
                txtLastname.Text = lvwUsers.SelectedItems[0].SubItems[2].Text;
                dtpDOB.Text = lvwUsers.SelectedItems[0].SubItems[3].Text;
                txtUsername.Text = lvwUsers.SelectedItems[0].SubItems[4].Text;
                txtPassword.Text = lvwUsers.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(btnAdd.Text == "ADD NEW")
            {
                clearField();
                btnAdd.Text = "SAVE";
                btnCancel.Enabled = true;
            }
            else
            {
                btnAdd.Text = "ADD NEW";
                btnCancel.Enabled = false;

                // TODO: Make sure to add validation here
                // There should be no blank field
                structUser user = new structUser();
                user.firstname = txtFirstname.Text;
                user.lastname = txtLastname.Text;
                user.dob = DateTime.Parse(dtpDOB.Text);
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;

                bool result = new User().createUser(user);

                if (result) {
                    MessageBox.Show("Details saved!");
                    // Make sure to reload the table and clear the fields
                    LoadReport();
                    clearField();
                }
                else
                {
                    MessageBox.Show("Error saving!");
                }

            }
            
        }

        private void clearField()
        {
            txtID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            dtpDOB.Text = "01/01/1990";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            btnAdd.Text = "ADD NEW";
            btnCancel.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length <= 0)
            {
                MessageBox.Show("Make sure to select an entry to update!");
            }
            else
            {
                // TODO: Make sure to add validation here
                // There should be no blank field
                structUser user = new structUser();
                user.id = Int32.Parse(txtID.Text);
                user.firstname = txtFirstname.Text;
                user.lastname = txtLastname.Text;
                user.dob = DateTime.Parse(dtpDOB.Text);
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;

                bool result = new User().updateUser(user);

                if (result)
                {
                    MessageBox.Show("Details updated!");
                    // Make sure to reload the table and clear the fields
                    LoadReport();
                    clearField();
                }
                else
                {
                    MessageBox.Show("Error updating!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Make sure to select an entry to delete!");
            }
            else
            {
                // TODO: Make sure to add validation here
                // There should be no blank field
                bool result = new User().deleteUser(Int32.Parse(txtID.Text));

                if (result)
                {
                    MessageBox.Show("Entry deleted!");
                    // Make sure to reload the table and clear the fields
                    LoadReport();
                    clearField();
                }
                else
                {
                    MessageBox.Show("Error deleting!");
                }
            }
        }
    }
}
