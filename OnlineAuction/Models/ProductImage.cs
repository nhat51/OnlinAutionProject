using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public int ProductID { get; set; }
        public Auction Auction { get; set; }
    }
}
