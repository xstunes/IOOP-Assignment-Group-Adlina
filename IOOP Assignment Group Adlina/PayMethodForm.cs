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
    public partial class PayMethodForm : Form
    {
        public PayMethodForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnlinePayForm onlinePayForm = new OnlinePayForm();
            onlinePayForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PayatCounter payatCounter = new PayatCounter();
            payatCounter.Show();
        }
    }
}
