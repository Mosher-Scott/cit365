using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk__Mine_.Models
{

    [Table("Table")]
    public class Orders
    {
        // Desk Information that is in the order
        public int Id { get; set; }
        public double deskWidth { get; set; }
        public double deskDepth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }
        public int rushOption { get; set; }
    }
}
