using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    internal class UserClass
    {
        public string username, email, password, role;
        private static string Connectionstring = "IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString";
        private SqlDataReader dr;

        public UserClass(string username, string email, string password, string role)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        private string Signup(string username, string email, string password, string role)
        {
            string status = null;
            SqlConnection CheckUser = new SqlConnection(Connectionstring);
            CheckUser.Open();

            if (username != null || email != null || password != null || role != null)
            {

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM userTable where username = @a and email =@b", CheckUser);
                cmd.Parameters.AddWithValue("@a", username);
                cmd.Parameters.AddWithValue("@b", email);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("User already exist.");
                }

                else
                {
                    dr.Close ();
                    SqlCommand Addnew = new SqlCommand("INSERT INTO userTable (Username, Email, Password, Role) VALUES (@a, @b, @c, @d)", CheckUser);
                    Addnew.Parameters.AddWithValue("@a", username);
                    Addnew.Parameters.AddWithValue("@b", email);
                    Addnew.Parameters.AddWithValue("@c", password);
                    Addnew.Parameters.AddWithValue("@d", role);

                    Addnew.ExecuteNonQuery();
                    MessageBox.Show("Account created. You can login now.");
                }
            }
            else
            {
                status = "Please fill in all boxes.";
            }
            CheckUser.Close();
            return status;
        }


    }

}
