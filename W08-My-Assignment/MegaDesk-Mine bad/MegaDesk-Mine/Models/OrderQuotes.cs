using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Mine.Models
{
    public class OrderQuotes
    {
        // Order Details
        public int ID { get; set; }
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime submitDate { get; set; }
        public double quoteTotal { get; set; }

    }

    public class OrderDetails
    {
        // Desk Information that is in the order
        public int ID { get; set; }
        public double deskWidth { get; set; }
        public double deskDepth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }
        public int rushOption { get; set; }
    }
}
