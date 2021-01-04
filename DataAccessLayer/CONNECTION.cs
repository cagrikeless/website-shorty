using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class CONNECTION
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-OL0BNDU\\" +
            "SQLEXPRESS;Initial Catalog=entitySignupwebformDB;Integrated Security=True");
    }
}
