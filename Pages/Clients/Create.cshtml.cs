using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crud.Data;
using Crud.Models;

namespace Crud.Pages_Clients
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
        public Clients Clients { get; set; } = default!;
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Clients == null || Clients == null)
            {
                return Page();
            }

            _context.Clients.Add(Clients);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
