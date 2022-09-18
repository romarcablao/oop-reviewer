using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace health_declaration_app
{
    class classConnection
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DICT\health-declaration-app\database\health-declaration-db.mdb"; 

        public classConnection()
        {
            // Initialize connection params
            con.ConnectionString = connectionString;
            cmd.Connection = con;
        }

        // We want to query the users together with all of their booking appointments
        public List<structReportView> getListOfAppointments(int id = 0)
        {
            List<structReportView> appointments = new List<structReportView>();
            if(id == 0)
            {
                cmd.CommandText = "SELECT tblBooking.ID, tblBooking.date, tblUsers.name, tblBooking.room_no FROM (tblBooking INNER JOIN tblUsers ON tblBooking.user_id = tblUsers.ID)";
            }
            else
            {
                cmd.CommandText = "SELECT tblBooking.ID, tblBooking.date, tblUsers.name, tblBooking.room_no FROM (tblBooking INNER JOIN tblUsers ON tblBooking.user_id = tblUsers.ID) WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_id", id);
            }

            con.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                structReportView appointment = new structReportView();
                appointment.id = Int32.Parse(reader["id"].ToString());
                appointment.name = reader["name"].ToString();
                appointment.room_no = reader["room_no"].ToString();
                appointment.date = DateTime.Parse(reader["date"].ToString());

                appointments.Add(appointment);
            }

            con.Close();

            return appointments;
        }

        // We want to save user details in the database
        public bool userRegistration(string name, DateTime dob, string username, string password)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tblUsers (name, dob,username, [password]) VALUES (@name, @dob,@username, @password);";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
            }
            return false;
        }

        // We want to validate user whenever they login
        public structUser userLogin(string username, string password)
        {
            structUser structUser = new structUser();
            try
            {
                cmd.CommandText = "SELECT * FROM tblUsers WHERE username=@username and [password]=@password;";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();

                reader = cmd.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    structUser.id = Int32.Parse(reader["id"].ToString()); 
                    structUser.name = reader["name"].ToString();
                    count++;

                }

                if(count == 1)
                {
                    return structUser;
                }

            }
            catch
            {
                con.Close();
            }

            return structUser;
        }

        // We want to save the appointment
        public bool bookAppointment(int user_id, string room_no, DateTime date)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tblBooking (user_id, room_no, [date]) VALUES (@user_id, @room_no, @date);";
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@room_no", room_no);
                cmd.Parameters.AddWithValue("@date", date);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
            }
            return false;
        }

        // We want to save the health declaration response
        public bool saveHealthDeclarationResponse(int user_id, bool q01, bool q02, bool q03, bool q04, bool q05)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tblResponse (user_id, question_01, question_02, question_03, question_04, question_05) VALUES (@user_id, @q01, @q02, @q03, @q04, @q05);";
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@q01", q01);
                cmd.Parameters.AddWithValue("@q02", q02);
                cmd.Parameters.AddWithValue("@q03", q03);
                cmd.Parameters.AddWithValue("@q04", q04);
                cmd.Parameters.AddWithValue("@q05", q05);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                con.Close();
            }
            return false;
        }
    }
}
