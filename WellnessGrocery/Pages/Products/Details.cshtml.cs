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
<<<<<<< HEAD
using WellnessGrocery.Models;
=======
using WellnessGrocery.wwwroot.Models;
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375

namespace WellnessGrocery.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public DetailsModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
=======
<<<<<<< HEAD
            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
=======
            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductId == id);
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
