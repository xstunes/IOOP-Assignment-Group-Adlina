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
    public partial class ChefForm : Form
    {
        public ChefForm()
        {
            InitializeComponent();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            Vieworders order = new Vieworders();
            order.Show();
        }

        private void btnUpdateprofile_Click(object sender, EventArgs e)
        {
            ChefUpdateProfile updateProfile = new ChefUpdateProfile();
            updateProfile.Show();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            ManageInventory manageInventory = new ManageInventory();
            manageInventory.Show();
        }
    }
}
