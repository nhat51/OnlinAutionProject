using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuctionMVC.Models
{
    public class Bidder_bid_regist
    {
        public int ID { get; set; }
        public Bidder Bidder_ID { get; set; }
        public Bid_order Bid_Order_ID { get; set; }
        public DateTime Regist_Date { get; set; }
        public bool IsActive { get; set; }
    }
}
