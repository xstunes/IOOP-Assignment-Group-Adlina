using System;
using System.Collections;
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
    public partial class Vieworders : Form
    {
        public Vieworders()
        {
            InitializeComponent();
        }

        private void Vieworders_Load(object sender, EventArgs e)
        {
            ArrayList order = new ArrayList();
            order = Orders.viewAll();
            foreach (var i in order) 
            { 
                listOrder.Items.Add(i);
            }
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateorder_Click(object sender, EventArgs e)
        {
            Orders obj1 = new Orders();
        }
    }
}
