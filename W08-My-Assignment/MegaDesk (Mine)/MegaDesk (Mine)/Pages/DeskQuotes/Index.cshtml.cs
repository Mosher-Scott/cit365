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
    public class IndexModel : PageModel
    {
        private readonly MegaDesk__Mine_.Data.MegaDesk__Mine_Context _context;

        public IndexModel(MegaDesk__Mine_.Data.MegaDesk__Mine_Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
