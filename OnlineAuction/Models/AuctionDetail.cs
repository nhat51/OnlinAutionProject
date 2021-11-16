using OnlineAuction.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class AuctionDetail
    {
        public int ID { get; set; }
        public int AuctionID { get; set; }
        public int BidderID { get; set; }
        public Auction Auction { get; set; }
        public OnlineAuctionUser Bidders { get; set; }
        public int BidPrice { get; set; }
        
    }
}
