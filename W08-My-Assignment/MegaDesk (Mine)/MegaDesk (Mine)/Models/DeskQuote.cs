using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk__Mine_.Pages
{
    [Table("DeskQuote")]
    public class DeskQuote
    {
        // Order Details
        public int ID { get; set; }
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime submitDate { get; set; }
        public double quoteTotal { get; set; }

        // Desk Information that is in the order
        public double deskWidth { get; set; }
        public double deskDepth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }
        public int rushOption { get; set; }

    }

}
