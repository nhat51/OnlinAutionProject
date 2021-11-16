using OnlineAuction.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class Auction
    {
        public int ID { get; set; }        
        public string ProductName { get; set; }
        public string Description { get; set; }
        public SubCategory Sub_Category { get; set; }
        public int SubCategoryID { get; set; }
        public OnlineAuctionUser Owner { get; set; }
        public ICollection<AuctionDetail> AuctionDetails { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public DateTime EndDate { get; set; }
        public int StartPrice { get; set; }
        public bool Status { get; set; }
    }
}
