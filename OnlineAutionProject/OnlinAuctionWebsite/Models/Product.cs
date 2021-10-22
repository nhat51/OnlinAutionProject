using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Actual_cost_in_curency { get; set; }
        public Sub_Category Sub_Category { get; set; }
        public List<Product_Image> Prodcut_Images { get; set; }
    }
}
