using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Category_Name { get; set; }
        public string Category_Image { get; set; }
        public ICollection<SubCategory> Sub_Categories { get; set; }
    }
}
