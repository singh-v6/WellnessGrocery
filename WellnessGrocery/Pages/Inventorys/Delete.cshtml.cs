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
    public class DeleteModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public DeleteModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Inventory Inventory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var inventory = await _context.Inventory.FirstOrDefaultAsync(m => m.Id == id);
=======
            var inventory = await _context.Inventory.FirstOrDefaultAsync(m => m.InventoryId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0

            if (inventory == null)
            {
                return NotFound();
            }
            else 
            {
                Inventory = inventory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }
            var inventory = await _context.Inventory.FindAsync(id);

            if (inventory != null)
            {
                Inventory = inventory;
                _context.Inventory.Remove(Inventory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
