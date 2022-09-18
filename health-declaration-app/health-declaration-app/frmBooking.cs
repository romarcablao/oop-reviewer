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
    public partial class frmBooking : Form
    {
        private int user_id;

        public frmBooking(int id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            classMisc frm = new classMisc();
            frm.frmNavigate(this, new frmDashboard(this.user_id, null));
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = grpOffice.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string selectedRoom = "";
            try
            {
                switch (checkedButton.Name)
                {
                    case "rtbRoom101":
                        selectedRoom = "Room 101";
                        break;
                    case "rtbRoom102":
                        selectedRoom = "Room 102";
                        break;
                    case "rtbRoom103":
                        selectedRoom = "Room 103";
                        break;
                    case "rtbRoom201":
                        selectedRoom = "Room 201";
                        break;
                    case "rtbRoom202":
                        selectedRoom = "Room 202";
                        break;
                    case "rtbRoom203":
                        selectedRoom = "Room 203";
                        break;
                };

                classConnection dbConnection = new classConnection();
                bool result = dbConnection.bookAppointment(this.user_id, selectedRoom, DateTime.Parse(dtpSchedule.Text));

                if (result)
                {
                    MessageBox.Show("Appointment booked successfully! Please make sure to fillout the health declaration form on the scheduled date.");
                }
                else
                {
                    MessageBox.Show("Error booking an appointment!");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection!");
            }

        }
    }
}
