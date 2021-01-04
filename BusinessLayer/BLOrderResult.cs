using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLOrderResult
    {
        public static List<ShortyOrder> BLOrderRes()
        {
            return OrderProgress.get();
        }
    }
 }
