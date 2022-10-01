using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WellnessGrocery.Data;
using WellnessGrocery.wwwroot.Models;

namespace WellnessGrocery.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public CreateModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductInventoryId"] = new SelectList(_context.Inventory, "InventoryId", "InventoryId");
        ViewData["ProductOrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
