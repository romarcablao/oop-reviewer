using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_app
{
    struct structUser{
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dob { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    class User: Connection
    {
        public bool createUser(structUser user)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tblUsers (firstname, lastname, dob,username, [password]) VALUES (@firstname, @lastname, @dob,@username, @password);";
                cmd.Parameters.AddWithValue("@firstname", user.firstname);
                cmd.Parameters.AddWithValue("@lastname", user.lastname);
                cmd.Parameters.AddWithValue("@dob", user.dob);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);

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

        public bool updateUser(structUser user)
        {
            try
            {
                cmd.CommandText = @"UPDATE tblUsers  SET 
                                       firstname=@firstname,
                                       lastname=@lastname,
                                       dob=@dob,
                                       username=@username, 
                                       [password]=@password
                                       WHERE id=@id";
                cmd.Parameters.AddWithValue("@firstname", user.firstname);
                cmd.Parameters.AddWithValue("@lastname", user.lastname);
                cmd.Parameters.AddWithValue("@dob", user.dob);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@id", user.id);

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

        public bool deleteUser(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM tblUsers WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);

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

        public List<structUser> getUser()
        {
            List<structUser> users = new List<structUser>();
            cmd.CommandText = "SELECT * FROM tblUsers";

            con.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                structUser user = new structUser();
                user.id = Int32.Parse(reader["id"].ToString());
                user.firstname = reader["firstname"].ToString();
                user.lastname = reader["lastname"].ToString();
                user.dob = DateTime.Parse(reader["dob"].ToString());
                user.username = reader["username"].ToString();
                user.password = reader["password"].ToString();
                users.Add(user);
            }

            con.Close();

            return users;
        }

    }
}
