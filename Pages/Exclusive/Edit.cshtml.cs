using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;

namespace Crud.Pages_Exclusive
{
    public class EditModel : PageModel
    {
        private readonly Crud.Data.ApplicationDbContext _context;

        public EditModel(Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Exclusive Exclusive { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Exclusives == null)
            {
                return NotFound();
            }

            var exclusive =  await _context.Exclusives.FirstOrDefaultAsync(m => m.Id == id);
            if (exclusive == null)
            {
                return NotFound();
            }
            Exclusive = exclusive;
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

            _context.Attach(Exclusive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExclusiveExists(Exclusive.Id))
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

        private bool ExclusiveExists(Guid id)
        {
          return (_context.Exclusives?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
