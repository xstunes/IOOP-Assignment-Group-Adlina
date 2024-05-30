﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
namespace IOOP_Assignment_Group_Adlina
{
    public class UserClass
    {
        public int id;
        public string username, email, password, role;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr

        public UserClass(string username, string email, string password, string role)
        {
            this.username = username;
            this.email = email; 
            this.password = password;   
            this.role = role;
        }

        public UserClass()
        {

        }
        public UserClass(int id)
        {
            this.id = id;
        }

        public static string Registernew(string username, string email, string password, string role)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                if (username != string.Empty || email != string.Empty || password != string.Empty || role != string.Empty) //checking if the user exist or not
                {
                    cmd = new SqlCommand("SELECT * FROM userData WHERE username = @a", con);
                    cmd.Parameters.AddWithValue("@a", username);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("User exist. Try another username.");
                    }
                    else //if not exist, continue adding data into db
                    {
                        dr.Close();
                        cmd = new SqlCommand("INSERT INTO userData VALUES (@username, @email, @password, @role)", con);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User added. Please login.");
                    }
                }
                else
                    status = "Please fill in all the fields.";
                con.Close();
                return status;
            }

        }


        public static string Login(string username,string password)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM userData WHERE (username = @a or email = @a) and password = @b", con);
                cmd.Parameters.AddWithValue("@a", username);
                cmd.Parameters.AddWithValue("@b", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    cmd = new SqlCommand("SELECT Role FROM userData WHERE (username = @a or email = @a) and password = @b", con);
                    cmd.Parameters.AddWithValue("@a", username);
                    cmd.Parameters.AddWithValue("@b", password);

                    string userRole = cmd.ExecuteScalar().ToString();

                    if (userRole == "Admin")
                    {
                        FormLogin login = new FormLogin();
                        AdminMenuForm admin =new AdminMenuForm();
                        login.Hide();
                        admin.ShowDialog();
                    }
                    else if (userRole == "Manager")
                    {
                        FormLogin login = new FormLogin();
                        ManagerForm manager = new ManagerForm(username);
                        login.Hide();
                        manager.ShowDialog();
                    }
                    else if (userRole == "Chef")
                    {
                        FormLogin login = new FormLogin();
                        //AdminMenuForm admin = new AdminMenuForm();
                        login.Hide();
                        login.ShowDialog();
                    }
                    else if (userRole == "Customer")
                    {
                        FormLogin login = new FormLogin();
                        CustomerMainMenu customer = new CustomerMainMenu();
                        login.Hide();
                        customer.ShowDialog();
                    }

                }

                else if (username == string.Empty || password == string.Empty)
                {
                    status = "Please fill in all fields.";
                }

                else
                {
                    status = "Incorrect username/email or password.";
                }

                con.Close();
                return status;
            } 

        }

        public static string DeleteUser(int id)
        {
            string status = null;
            using(con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM userData WHERE userID = @a", con);
                cmd.Parameters.AddWithValue("a", id);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd = new SqlCommand("DELETE FROM userData WHERE userID = @a", con);
                    cmd.Parameters.AddWithValue("a", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully deleted.");
                }
                else
                {
                    status = "Error : User does not exist.";
                }
            }
            con.Close();
            return status;

        }
    
        public static List<UserClass> GetUsers()
        {
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("SELECT Username, Email, Role FROM userTable", con);
                dr = cmd.ExecuteReader();
                List<UserClass> users = new List<UserClass>();

                while (dr.Read())
                {
                    UserClass user = new UserClass
                    {
                        username = dr[0].ToString(),
                        email = dr[1].ToString(),
                        role = dr[2].ToString(),
                    };

                    users.Add(user);

                }
                con.Close();
                return users;
            }
        }
    }

}
