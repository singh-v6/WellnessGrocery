using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Data;
using WellnessGrocery.wwwroot.Models;

namespace WellnessGrocery.Pages.PurchaseHistorys
{
    public class EditModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public EditModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PurchaseHistory PurchaseHistory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PurchaseHistory == null)
            {
                return NotFound();
            }

            var purchasehistory =  await _context.PurchaseHistory.FirstOrDefaultAsync(m => m.PurchaseHistoryId == id);
            if (purchasehistory == null)
            {
                return NotFound();
            }
            PurchaseHistory = purchasehistory;
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

            _context.Attach(PurchaseHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseHistoryExists(PurchaseHistory.PurchaseHistoryId))
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

        private bool PurchaseHistoryExists(int id)
        {
          return _context.PurchaseHistory.Any(e => e.PurchaseHistoryId == id);
        }
    }
}
