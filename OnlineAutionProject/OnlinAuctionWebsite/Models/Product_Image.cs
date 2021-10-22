using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Product_Image
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public Product Product_ID { get; set; }
    }
}
