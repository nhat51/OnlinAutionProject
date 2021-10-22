using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Bidder_Bid_Regist
    {
        public int ID { get; set; }
        public Bidder Bidder_ID { get; set; }
        public int MyProperty { get; set; }
        public DateTime Regist_Date { get; set; }
        public bool IsActive { get; set; }
        
    }
}
