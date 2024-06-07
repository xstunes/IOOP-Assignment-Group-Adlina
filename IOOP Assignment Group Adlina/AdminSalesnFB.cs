using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_Adlina
{
    internal class AdminSalesnFB
    {
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da


    }
}
