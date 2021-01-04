using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace EntityLayer
{
    public class ShortyOrder
    {
        private int orderid;
        private string ordername;
        private string orderprice;
        private string orderbarcode;

        public int Orderid { get => orderid; set => orderid = value; }
        public string Ordername { get => ordername; set => ordername = value; }
        public string Orderprice { get => orderprice; set => orderprice = value; }
        public string Orderbarcode { get => orderbarcode; set => orderbarcode = value; }
    }
}
