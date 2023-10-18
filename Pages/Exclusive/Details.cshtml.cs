using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;

namespace Crud.Pages_Exclusive
{
    public class DetailsModel : PageModel
    {
        private readonly Crud.Data.ApplicationDbContext _context;

        public DetailsModel(Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Exclusive Exclusive { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Exclusives == null)
            {
                return NotFound();
            }

            var exclusive = await _context.Exclusives.FirstOrDefaultAsync(m => m.Id == id);
            if (exclusive == null)
            {
                return NotFound();
            }
            else 
            {
                Exclusive = exclusive;
            }
            return Page();
        }
    }
}
