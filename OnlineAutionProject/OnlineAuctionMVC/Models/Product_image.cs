using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuctionMVC.Models
{
    public class Product_image
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public Product Product_ID { get; set; }
    }
}
