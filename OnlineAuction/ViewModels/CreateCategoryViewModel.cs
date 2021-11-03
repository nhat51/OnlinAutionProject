using Microsoft.AspNetCore.Http;
using OnlineAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.ViewModels
{
    public class CreateCategoryViewModel
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }
        public List<IFormFile> Category_Image { get; set; }
    }
}
