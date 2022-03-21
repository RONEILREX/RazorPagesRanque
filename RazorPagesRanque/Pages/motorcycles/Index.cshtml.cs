#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesRanque.Data;
using RazorPagesRanque.models;

namespace RazorPagesRanque.Pages.motorcycles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRanque.Data.RazorPagesRanqueContext _context;

        public IndexModel(RazorPagesRanque.Data.RazorPagesRanqueContext context)
        {
            _context = context;
        }

        public IList<motorcycle> motorcycle { get;set; }

        public async Task OnGetAsync()
        {
            motorcycle = await _context.motorcycle.ToListAsync();
        }
    }
}
