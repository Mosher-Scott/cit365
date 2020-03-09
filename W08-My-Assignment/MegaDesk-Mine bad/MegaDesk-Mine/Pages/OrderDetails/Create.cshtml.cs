using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_Mine.Data;
using MegaDesk_Mine.Models;

namespace MegaDesk_Mine
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_Mine.Data.MegaDesk_MineContext _context;

        public CreateModel(MegaDesk_Mine.Data.MegaDesk_MineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OrderDetails OrderDetails { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderDetails.Add(OrderDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
