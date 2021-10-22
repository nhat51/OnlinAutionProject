using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Bid_Coin_Pack
    {
        public int ID { get; set; }
        public string Pack_Name { get; set; }
        public int Bid_Coins_Value { get; set; }
        public int Bonus_Coin { get; set; }
        public int Cost { get; set; }
    }
}
