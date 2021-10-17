using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Bidder_bid_regist
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Bidder")]
        public int Bidder_ID { get; set; }
        public int MyProperty { get; set; }
        public DateTime Regist_Date { get; set; }
        public bool IsActive { get; set; }
    }
}
