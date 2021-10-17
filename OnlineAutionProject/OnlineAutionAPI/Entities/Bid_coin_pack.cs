using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Bid_coin_pack
    {
        public int ID { get; set; }
        public string Pack_Name { get; set; }
        public int Bid_Coins_Value { get; set; }
        public int Bonus_Coin { get; set; }
        public int Cost { get; set; }

    }
}
