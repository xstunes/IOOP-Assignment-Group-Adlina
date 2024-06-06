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
    public partial class ViewFBForm : Form
    {
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da
        public ViewFBForm()
        {
            InitializeComponent();
        }

        private void LblKL_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm amf = new AdminMenuForm();
            amf.ShowDialog();
        }

        private void ViewFBForm_Load(object sender, EventArgs e)
        {

        }
    }
}
