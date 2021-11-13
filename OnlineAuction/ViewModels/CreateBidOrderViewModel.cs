using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.ViewModels
{
    public class CreateBidOrderViewModel
    {
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public List<IFormFile> Product_Image { get; set; }
        public int Actual_cost_in_curency { get; set; }
        public DateTime Bid_Start_Time { get; set; }
        public DateTime Bid_End_Time { get; set; }
        public int Base_Price { get; set; }
        public int MyProperty { get; set; }

    }
}
