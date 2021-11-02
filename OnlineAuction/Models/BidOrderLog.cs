using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class BidOrderLog
    {
        public int ID { get; set; }
        
        public BidderBidRegist Bidder_Bid_Regist_ID { get; set; }

    }
}
