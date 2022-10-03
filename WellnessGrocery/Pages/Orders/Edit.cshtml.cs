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
<<<<<<< HEAD
using WellnessGrocery.Models;
=======
using WellnessGrocery.wwwroot.Models;
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375

namespace WellnessGrocery.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public EditModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var order =  await _context.Order.FirstOrDefaultAsync(m => m.Id == id);
=======
<<<<<<< HEAD
            var order =  await _context.Order.FirstOrDefaultAsync(m => m.Id == id);
=======
            var order =  await _context.Order.FirstOrDefaultAsync(m => m.OrderId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
            if (order == null)
            {
                return NotFound();
            }
            Order = order;
<<<<<<< HEAD
           ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
=======
<<<<<<< HEAD
           ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
=======
           ViewData["OrderCustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
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

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
<<<<<<< HEAD
                if (!OrderExists(Order.Id))
=======
<<<<<<< HEAD
                if (!OrderExists(Order.Id))
=======
                if (!OrderExists(Order.OrderId))
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
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

        private bool OrderExists(int id)
        {
<<<<<<< HEAD
          return _context.Order.Any(e => e.Id == id);
=======
<<<<<<< HEAD
          return _context.Order.Any(e => e.Id == id);
=======
          return _context.Order.Any(e => e.OrderId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
        }
    }
}
