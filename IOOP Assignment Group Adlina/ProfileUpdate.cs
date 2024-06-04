using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    internal class ProfileUpdate
    {
        string username, email, password;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(Connectionstring); //SqlConnection is assigned to con
        SqlCommand cmd; //SqlCommand is assigned to cmd
        //SqlDataReader dr; //SqlDataReader assigned to dr

        //Constructor with three parameters  
        public ProfileUpdate(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }

        //Constructor with one parameter
        public ProfileUpdate(string username)
        {
            this.username = username;
        }

        public string updateUser(string un)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE userData SET Username =@nm WHERE Username LIKE @ou;", con);
            cmd.Parameters.AddWithValue("@nm", un);
            cmd.Parameters.AddWithValue("@ou", username);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close();
            return status;
        }

        public string updateEm(string em)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE userData SET Email =@em WHERE Username LIKE @ou;", con);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@ou", username);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close();
            return status;
        }

        public string updatePass(string pa)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE userData SET Password =@pa WHERE Username LIKE @ou;", con);
            cmd.Parameters.AddWithValue("@pa", pa);
            cmd.Parameters.AddWithValue("@ou", username);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close();
            return status;
        }
    }
}
