using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class SubCategory
    {
        public int ID { get; set; }
        public string Sub_Category_Name { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
