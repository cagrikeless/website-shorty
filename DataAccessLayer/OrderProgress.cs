using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class OrderProgress
    {
        public static List<ShortyOrder> getProducts()
        {
            List<ShortyOrder> degerler = new List<ShortyOrder>();
            SqlCommand cmd = new SqlCommand("Select * FROM TBLORDERINFO", connection: CONNECTION.con);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ShortyOrder e = new ShortyOrder();
                e.Orderid = int.Parse(dr["ORDERID"].ToString());
                e.Ordername = dr["ORDERNAME"].ToString();
                e.Orderprice = dr["ORDERPRICE"].ToString();
                e.Orderbarcode = dr["ORDERBARCODE"].ToString();

                degerler.Add(e);
            }
            dr.Close();
            return degerler;
        }
    }
}
