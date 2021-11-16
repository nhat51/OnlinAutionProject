using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory Sub_Category { get; set; }  
        public ICollection<ProductImage> Prodcut_Images { get; set; }
    }
}
