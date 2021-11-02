using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class BidCoinTransLog
    {
        public int ID { get; set; }
        public int Bid_Coin_Pack_ID { get; set; }
        public int Bidder_ID { get; set; }
        public int Bid_Order_Log_ID { get; set; }
        public DateTime Transaction_Date { get; set; }
        public int Coin_Count { get; set; }
    }
}
