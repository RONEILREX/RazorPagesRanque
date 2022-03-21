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
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesRanque.Data.RazorPagesRanqueContext _context;

        public DeleteModel(RazorPagesRanque.Data.RazorPagesRanqueContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            motorcycle = await _context.motorcycle.FindAsync(id);

            if (motorcycle != null)
            {
                _context.motorcycle.Remove(motorcycle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8602
#pragma warning restore CS8604
}
