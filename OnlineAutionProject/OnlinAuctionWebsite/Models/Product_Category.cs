using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinAuctionWebsite.Models
{
    public class Product_Category
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Cat_Image { get; set; }
        public List<Sub_Category> Sub_Categories { get; set; }

    }
}
