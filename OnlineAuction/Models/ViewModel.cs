using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class ViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<SubCategory> Sub_Categories { get; set; }

    }
}
