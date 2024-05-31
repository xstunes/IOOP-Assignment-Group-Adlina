﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void RbtnManageAdmin_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void ManAllUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUserForm mu = new ManageUserForm();
            mu.ShowDialog();
        }

        private void BtnViewFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFBForm fb = new ViewFBForm();
            fb.ShowDialog();
        }

        private void BtnViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm ss = new SalesForm();
            ss.ShowDialog();
        }

        private void BtnManProfile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfileForm up = new UpdateProfileForm();
            up.ShowDialog();
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
