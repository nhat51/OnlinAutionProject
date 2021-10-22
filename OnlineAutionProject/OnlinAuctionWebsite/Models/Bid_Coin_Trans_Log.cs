using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Bid_Coin_Trans_Log
    {
        public int ID { get; set; }
        public Bid_Coin_Pack Bid_Coin_Pack_ID { get; set; }
        public Bidder Bidder_ID { get; set; }
        public Bid_Order_Log Bid_Order_Log_ID { get; set; }
        public DateTime Transaction_Date { get; set; }
        public int Coin_Count { get; set; }
    }
}
