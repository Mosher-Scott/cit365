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
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk_Mine.Data.MegaDesk_MineContext _context;

        public DetailsModel(MegaDesk_Mine.Data.MegaDesk_MineContext context)
        {
            _context = context;
        }

        public OrderQuotes OrderQuotes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderQuotes = await _context.OrderQuotes.FirstOrDefaultAsync(m => m.ID == id);

            if (OrderQuotes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
