using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuctionMVC.Models
{
    public class Bid_order
    {
        public int ID { get; set; }
        public int Product_ID { get; set; }
        public DateTime Bid_Start_Time { get; set; }
        public DateTime Bid_End_Time { get; set; }
        public int Bid_Chair_Cost { get; set; }
        public int Base_Price { get; set; }
        public int Increment_Price_Per_Bid { get; set; }
        public int Cool_Down_Time_Per_Bid { get; set; }
        public Bidder Bidder { get; set; }
    }
}
