using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Prodcut_Image
    {
        [Key]
        public int ID { get; set; }
        public string Image { get; set; }

        [ForeignKey("Product")]
        public int Product_ID { get; set; }

    }
}
