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
    public class DeleteModel : PageModel
    {
        private readonly MegaDesk_Mine.Data.MegaDesk_MineContext _context;

        public DeleteModel(MegaDesk_Mine.Data.MegaDesk_MineContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderDetails OrderDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetails = await _context.OrderDetails.FirstOrDefaultAsync(m => m.ID == id);

            if (OrderDetails == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetails = await _context.OrderDetails.FindAsync(id);

            if (OrderDetails != null)
            {
                _context.OrderDetails.Remove(OrderDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
