using OnlineAuction.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int AuctionID { get; set; }
        public int TotalPrice { get; set; }
        public OnlineAuctionUser Bidder { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
