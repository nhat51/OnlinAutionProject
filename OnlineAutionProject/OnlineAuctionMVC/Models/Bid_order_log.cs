using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuctionMVC.Models
{
    public class Bid_order_log
    {
        public int ID { get; set; }
        
        public Bidder_bid_regist Bidder_Bid_Regist_ID { get; set; }

    }
}
