#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesRanque.Data;
using RazorPagesRanque.models;

namespace RazorPagesRanque.Pages.motorcycles
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesRanque.Data.RazorPagesRanqueContext _context;

        public CreateModel(RazorPagesRanque.Data.RazorPagesRanqueContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public motorcycle motorcycle { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.motorcycle.Add(motorcycle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
