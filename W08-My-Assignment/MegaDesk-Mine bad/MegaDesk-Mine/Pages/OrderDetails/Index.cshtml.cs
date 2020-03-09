using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Mine.Data;
using MegaDesk_Mine.Models;

namespace MegaDesk_Mine
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_Mine.Data.MegaDesk_MineContext _context;

        public IndexModel(MegaDesk_Mine.Data.MegaDesk_MineContext context)
        {
            _context = context;
        }

        public IList<OrderDetails> OrderDetails { get;set; }

        public async Task OnGetAsync()
        {
            OrderDetails = await _context.OrderDetails.ToListAsync();
        }
    }
}
