using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Orders
    {
        public int OrderID { get; set; }
        public ML.OrderDetails OrderDetails { get; set; }
        public ML.Customers Customers { get; set; }
        public string OrderDate { get; set; }
        public List<object> Orderes { get; set; }

    }
}
