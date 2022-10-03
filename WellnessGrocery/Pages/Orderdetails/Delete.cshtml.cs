using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Data;
using WellnessGrocery.Models;

namespace WellnessGrocery.Pages.Orderdetails
{
    public class DeleteModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public DeleteModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Orderdetail Orderdetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Orderdetail == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.Orderdetail.FirstOrDefaultAsync(m => m.Id == id);

            if (orderdetail == null)
            {
                return NotFound();
            }
            else 
            {
                Orderdetail = orderdetail;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Orderdetail == null)
            {
                return NotFound();
            }
            var orderdetail = await _context.Orderdetail.FindAsync(id);

            if (orderdetail != null)
            {
                Orderdetail = orderdetail;
                _context.Orderdetail.Remove(Orderdetail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
