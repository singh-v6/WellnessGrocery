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

namespace WellnessGrocery.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public EditModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product =  await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
=======
            var product =  await _context.Product.FirstOrDefaultAsync(m => m.ProductId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
            if (product == null)
            {
                return NotFound();
            }
            Product = product;
<<<<<<< HEAD
           ViewData["InventoryId"] = new SelectList(_context.Set<Inventory>(), "Id", "Id");
=======
           ViewData["ProductInventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId");
           ViewData["ProductOrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
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

            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
<<<<<<< HEAD
                if (!ProductExists(Product.Id))
=======
                if (!ProductExists(Product.ProductId))
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

        private bool ProductExists(int id)
        {
<<<<<<< HEAD
          return _context.Product.Any(e => e.Id == id);
=======
          return _context.Product.Any(e => e.ProductId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
        }
    }
}
