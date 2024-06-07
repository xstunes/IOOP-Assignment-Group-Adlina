﻿using System;
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
    public partial class FormChangeroleus : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd

        private void EmptyAll()
        {
            TbUserID.Text = string.Empty;
            CbRoles1.Text = string.Empty;
        }

        public FormChangeroleus()
        {
            InitializeComponent();
        }

        private void ChangeUserRole_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = UserClass.UpdateRole(CbRoles1.Text, TbUserID.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            EmptyAll();
        }
    }
}
