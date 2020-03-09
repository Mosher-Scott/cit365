using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Mine.Models;

namespace MegaDesk_Mine.Data
{
    public class MegaDesk_MineContext : DbContext
    {
        public MegaDesk_MineContext (DbContextOptions<MegaDesk_MineContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_Mine.Models.OrderQuotes> OrderQuotes { get; set; }

        public DbSet<MegaDesk_Mine.Models.OrderDetails> OrderDetails { get; set; }
    }
}
