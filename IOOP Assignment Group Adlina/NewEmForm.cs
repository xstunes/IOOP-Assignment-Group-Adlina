using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class NewEmForm : Form
    {
        private ProfileUpdate updateUser;

        public NewEmForm(string olusername)
        {
            InitializeComponent();
            updateUser = new ProfileUpdate(olusername);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = updateUser.updateEm(TbNewEmail.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            
        }
    }
}
