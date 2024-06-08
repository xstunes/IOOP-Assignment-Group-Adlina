using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class AddUserForm : Form
    {
        private UserClass user;
        private PasswordGen generateranpass;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da

        public AddUserForm()
        {
            InitializeComponent();
        }
        private void EmptyAll()
        {
            TbUsernameAdmin.Text = string.Empty;
            TbEmailAdmin.Text = string.Empty;
            CbRoleAdmin.Text = string.Empty;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void LblKL_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string user = TbUsernameAdmin.Text;
            string password = null;
            if (PasswordGen.AunthenticateUser(user))
            {
                MessageBox.Show("Error : user exist.");
            }
            else
            {
                password = PasswordGen.GenRandomPassword(TbUsernameAdmin.Text, TbEmailAdmin.Text, CbRoleAdmin.Text, 5);
                LblGenPass.Text = password;
                MessageBox.Show("User added successfully.");
            }
            UserClass.ValidateEmail(TbEmailAdmin.Text);

        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUserForm muf = new ManageUserForm();
            muf.ShowDialog();
        }
    }
}
