using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crud.Data;
using Crud.Models;

namespace Crud.Pages_Exclusive
{
    public class CreateModel : PageModel
    {
        private readonly Crud.Data.ApplicationDbContext _context;

        public CreateModel(Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Exclusive Exclusive { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Exclusives == null || Exclusive == null)
            {
                return Page();
            }

            _context.Exclusives.Add(Exclusive);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
