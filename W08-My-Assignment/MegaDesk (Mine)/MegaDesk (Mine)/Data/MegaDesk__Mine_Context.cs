using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk__Mine_.Pages;

namespace MegaDesk__Mine_.Data
{
    public class MegaDesk__Mine_Context : DbContext
    {
        public MegaDesk__Mine_Context (DbContextOptions<MegaDesk__Mine_Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk__Mine_.Pages.DeskQuote> DeskQuote { get; set; }
    }
}
