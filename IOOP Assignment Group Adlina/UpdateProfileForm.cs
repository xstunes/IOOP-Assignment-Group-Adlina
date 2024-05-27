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
    public partial class UpdateProfileForm : Form
    {
        string olusername;
        public UpdateProfileForm(string olUsername)
        {
            this.olusername = olUsername;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerProfileUpdate obj1 = new ManagerProfileUpdate(olusername);
            MessageBox.Show(obj1.updateProfile(txtUsername.Text, txtEmail.Text, txtPassword.Text));
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
