using System;
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
    public partial class CustomerMainMenu : Form
    {
        public CustomerMainMenu()
        {
            InitializeComponent();
        }

        private void CustomerMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mf = new MenuForm();
            mf.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            RsvReportForm rsvReportForm = new RsvReportForm();
            rsvReportForm.ShowDialog();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCustomerInfo updateCustomerInfo = new UpdateCustomerInfo();
            updateCustomerInfo.ShowDialog();
        }
    }
}
