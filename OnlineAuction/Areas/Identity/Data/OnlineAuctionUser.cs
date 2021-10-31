using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlineAuction.Models;

namespace OnlineAuction.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the OnlineAuctionUser class
    public class OnlineAuctionUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string First_Name { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Last_Name { get; set; }


        [PersonalData]
        [Column(TypeName = "varchar(20)")]
        public string Identity_Card_Number { get; set; }

        [PersonalData]
        [Column(TypeName = "date")]
        public DateTime Date_of_birth { get; set; }

        [PersonalData]
        [Column(TypeName = "varchar(6)")]
        public string Gender { get; set; }

        public int Current_bid_coins { get; set; }
        public int Locked_bid_coins { get; set; }
        public List<Bid_order> Bid_Orders { get; set; }
        public List<Bidder_bid_regist> Bidder_Bid_Regists { get; set; }
    }
}
