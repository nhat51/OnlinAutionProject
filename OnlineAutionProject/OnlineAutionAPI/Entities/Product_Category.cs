using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Product_Category
    {
        [Key]
        public int ID { get; set; }
        public string Category { get; set; }
        public string Cat_Image { get; set; }
    }
}
