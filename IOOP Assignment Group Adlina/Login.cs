using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //importing the system data sql client. 
using System.Configuration;//importing the system configuration
using System.Runtime.Remoting.Messaging; 

namespace IOOP_Assignment_Group_Adlina
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public string LoginAuth(string un)
        {
            String status = null;//check login pass

            //connect to database, via sqlconnection
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString());
            con.Open(); //open connection

            SqlCommand cmd = new SqlCommand("select count(*) from userData where (Username=@a or Email=@a) and (Password=@b)", con);
            cmd.Parameters.AddWithValue("@a", getUsernameEmail());
            cmd.Parameters.AddWithValue("@b", getPassword());

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0) //if found user in database, count > 0
            {
                //to authenticate role of user and assign them to their respective pages
                SqlCommand cmd2 = new SqlCommand("select Role from userData where (Username=@a or Email=@a) and (Password=@b)", con);
                cmd2.Parameters.AddWithValue("@a", getUsernameEmail());
                cmd2.Parameters.AddWithValue("@b", getPassword());
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "Admin")
                {
                    //redirect to Admin page
                    AdminMenuForm amf = new AdminMenuForm();
                    amf.Show();
                    this.Hide();
                }
                else if (userRole == "Manager")
                {
                    //redirect to Manager page
                    ManagerForm mf = new ManagerForm();
                    mf.Show();
                    this.Hide();
                }
                else if (userRole == "Chef")
                {
                    //redirect to Chef page
                    MenuForm mff = new MenuForm();  //replace later
                    mff.Show();
                    this.Hide();
                }
                else if (userRole == "Customer")
                {
                    //redirect to Customer page
                    On9PayForm op = new On9PayForm();
                    op.Show();
                    this.Hide();
                }
                else

                    status = ("Incorrect Username/Email or Password.");

            }                
            con.Close();
            return status;
        }

        public string getUsernameEmail()
        {
            return TbLoginUserEmail.Text;
        }

        public string getPassword()
        {
            return TbLoginPass.Text;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e) //When clicking login
        {
            string stat;
            UserClass obj = new UserClass(TbLoginUserEmail.Text, TbLoginPass.Text);
            stat = LoginAuth(TbLoginUserEmail.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);

            }
            TbLoginUserEmail.Text = string.Empty;
            TbLoginPass.Text = string.Empty;

        }
    }
}
