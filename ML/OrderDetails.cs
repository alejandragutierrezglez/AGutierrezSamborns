using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class OrderDetails
    {
        public ML.Orders  Orders { get; set; }
        public ML.Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
       

    }
}
