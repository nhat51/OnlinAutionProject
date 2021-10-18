using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Sub_category
    {
        public int ID { get; set; }
        public string Sub_Category_Name { get; set; }
        public Product_Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
