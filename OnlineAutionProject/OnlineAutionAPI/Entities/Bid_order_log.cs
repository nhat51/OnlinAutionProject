using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Bid_order_log
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Bidder_bid_regist")]
        public int Bidder_Bid_Regist_ID { get; set; }
        

    }
}
