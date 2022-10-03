using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Data;
<<<<<<< HEAD
using WellnessGrocery.Models;
=======
using WellnessGrocery.wwwroot.Models;
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0

namespace WellnessGrocery.Pages.Inventorys
{
    public class EditModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public EditModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inventory Inventory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Inventory == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var inventory =  await _context.Inventory.FirstOrDefaultAsync(m => m.Id == id);
=======
            var inventory =  await _context.Inventory.FirstOrDefaultAsync(m => m.InventoryId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
            if (inventory == null)
            {
                return NotFound();
            }
            Inventory = inventory;
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

            _context.Attach(Inventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
<<<<<<< HEAD
                if (!InventoryExists(Inventory.Id))
=======
                if (!InventoryExists(Inventory.InventoryId))
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
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

        private bool InventoryExists(int id)
        {
<<<<<<< HEAD
          return _context.Inventory.Any(e => e.Id == id);
=======
          return _context.Inventory.Any(e => e.InventoryId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
        }
    }
}
