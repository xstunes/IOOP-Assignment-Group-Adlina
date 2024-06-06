using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IOOP_Assignment_Group_Adlina
{
    internal class Chef
    {
        private string username;
        private string email;
        private string password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ToString());

        public Chef(string name)
        {
            username = name;
            email = null;
            password = null;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        
        public string updateP(string em, string p)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update userData set Email=@e, Password=@p where Username=@nm", con);
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", p);
            cmd.Parameters.AddWithValue("@nm", username);

            int i = cmd .ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Unable to update";
            con.Close();
            return status;
        }

        public static void viewP(Chef o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand ("select * from userData where Username = @a", con);
            cmd.Parameters.AddWithValue("@a", o1.username);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()) 
            {
                o1.email = rd.GetString(2);
                o1.password = rd.GetString(3);
            }
            con.Close();
        }
    }
}
