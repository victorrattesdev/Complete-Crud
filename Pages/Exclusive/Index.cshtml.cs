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
    public class IndexModel : PageModel
    {
        private readonly Crud.Data.ApplicationDbContext _context;

        public IndexModel(Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Exclusive> Exclusive { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Exclusives != null)
            {
                Exclusive = await _context.Exclusives.ToListAsync();
            }
        }
    }
}
