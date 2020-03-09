using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk__Mine_.Data;
using MegaDesk__Mine_.Pages;

namespace MegaDesk__Mine_
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk__Mine_.Data.MegaDesk__Mine_Context _context;

        public DetailsModel(MegaDesk__Mine_.Data.MegaDesk__Mine_Context context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
