using Microsoft.AspNetCore.Http;
using OnlineAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.ViewModels
{
    public class CreateAuctionViewModel
    {
        public string Product_Name { get; set; }
        public string ProductDescription { get; set; }
        public List<Category> Categories { get; set; }
        public DateTime EndDate { get; set; }
        public int StartPrice { get; set; }
        public SubCategory Sub_Categories { get; set; }
        public int Duration { get; set; }
        public List<IFormFile> Product_Image { get; set; }
    }
}
