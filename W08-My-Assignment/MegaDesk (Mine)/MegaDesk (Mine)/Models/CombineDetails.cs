using MegaDesk__Mine_.Pages;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk__Mine_.Models
{
    public class CombineDetails
    {
        public DbSet<DeskQuote> Quotes { get; set; }
        public DbSet<Orders> OrderDetails { get; set; }

    }
}
