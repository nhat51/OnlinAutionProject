using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.Models
{
    public class ViewModel
    {
        public IEnumerable<Product_category> Categories { get; set; }
        public IEnumerable<Sub_category> Sub_Categories { get; set; }

    }
}
