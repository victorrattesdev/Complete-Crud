using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;

namespace Crud.Pages_Clients
{
    public class DetailsModel : PageModel
    {
        private readonly Crud.Data.ApplicationDbContext _context;

        public DetailsModel(Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Clients Clients { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var clients = await _context.Clients.FirstOrDefaultAsync(m => m.Id == id);
            if (clients == null)
            {
                return NotFound();
            }
            else 
            {
                Clients = clients;
            }
            return Page();
        }
    }
}
