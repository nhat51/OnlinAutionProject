using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAutionAPI.Entities
{
    public class Bidder
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public string Identity_Card_Number { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public int Current_bid_coins { get; set; }
        public int Locked_bid_coins { get; set; }
        public List<Bid_order> Bid_Orders { get; set; }

    }
}
