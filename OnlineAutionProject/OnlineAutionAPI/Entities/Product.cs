﻿using System;
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

        [ForeignKey("Product_Category")]
        public int Product_Category_ID { get; set; }
        public string Product_Description { get; set; }
        public int Actual_cost_in_curency { get; set; }
    }
}
