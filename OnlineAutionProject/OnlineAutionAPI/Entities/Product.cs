using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Actual_cost_in_curency { get; set; }
        public Sub_category Sub_Category { get; set; }
        public List<Prodcut_Image> Prodcut_Images { get; set; }
    }
}
