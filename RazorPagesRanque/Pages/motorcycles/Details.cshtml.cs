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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesRanque.Data.RazorPagesRanqueContext _context;

        public DetailsModel(RazorPagesRanque.Data.RazorPagesRanqueContext context)
        {
            _context = context;
        }

        public motorcycle motorcycle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            motorcycle = await _context.motorcycle.FirstOrDefaultAsync(m => m.ID == id);

            if (motorcycle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
