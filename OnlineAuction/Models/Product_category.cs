using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class Product_category
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Cat_Image { get; set; }
        public List<Sub_category> Sub_Categories { get; set; }
    }
}
