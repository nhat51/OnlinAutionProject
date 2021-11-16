using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int BidPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
