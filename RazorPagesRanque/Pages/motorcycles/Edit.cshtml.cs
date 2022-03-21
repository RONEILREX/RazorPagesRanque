#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesRanque.Data;
using RazorPagesRanque.models;

namespace RazorPagesRanque.Pages.motorcycles
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesRanque.Data.RazorPagesRanqueContext _context;

        public EditModel(RazorPagesRanque.Data.RazorPagesRanqueContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(motorcycle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!motorcycleExists(motorcycle.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool motorcycleExists(int id)
        {
            return _context.motorcycle.Any(e => e.ID == id);
        }
    }
}
