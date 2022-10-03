using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Data;
<<<<<<< HEAD
using WellnessGrocery.Models;
=======
using WellnessGrocery.wwwroot.Models;
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0

namespace WellnessGrocery.Pages.Inventorys
{
    public class IndexModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public IndexModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Inventory != null)
            {
                Inventory = await _context.Inventory.ToListAsync();
            }
        }
    }
}
