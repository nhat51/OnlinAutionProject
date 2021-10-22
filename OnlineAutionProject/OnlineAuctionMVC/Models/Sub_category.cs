using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuctionMVC.Models
{
    public class Sub_category
    {
        public int ID { get; set; }
        public string Sub_Category_Name { get; set; }
        public Product_category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
