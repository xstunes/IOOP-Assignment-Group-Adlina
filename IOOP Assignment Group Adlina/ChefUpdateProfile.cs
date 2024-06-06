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
    public partial class ChefUpdateProfile : Form
    {
        public static string name;
        public ChefUpdateProfile()
        {
            InitializeComponent();
        }

        public ChefUpdateProfile(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void ChefUpdateProfile_Load(object sender, EventArgs e)
        {
            Chef obj1 = new Chef(name);

            Chef.viewP(obj1);

            txtEmail.Text = obj1.Email;
            txtPassword.Text = obj1.Password;
        }

        private void btnUpdtP_Click(object sender, EventArgs e)
        {
            Chef obj1 = new Chef(name);
            MessageBox.Show(obj1.updateP(txtEmail.Text, txtPassword.Text));
        }
    }
}
