using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Bid_Order_Log
    {
        public int ID { get; set; }
        public Bidder_Bid_Regist Bidder_Bid_Regist_ID { get; set; }

    }
}
