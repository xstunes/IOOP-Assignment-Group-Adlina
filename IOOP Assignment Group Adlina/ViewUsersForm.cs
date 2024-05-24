using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class ViewUsersForm : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();

        public ViewUsersForm()
        {
            InitializeComponent();
        }
        private void ViewUsersForm_Load(object sender, EventArgs e)
        {

        }



        private void BtnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm admin = new AdminMenuForm();
            admin.ShowDialog();
        }

        private void LviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
