using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_Adlina
{
    internal class Orders
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ToString());
        public static ArrayList viewAll()
        { 
            ArrayList o = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select orderID, foodItem from order", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                o.Add(rd.GetString(0));
            }
            con.Close();
            return o;
        }
    }
}
