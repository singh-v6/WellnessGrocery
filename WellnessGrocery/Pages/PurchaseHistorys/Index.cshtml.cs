using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Data;
using WellnessGrocery.wwwroot.Models;

namespace WellnessGrocery.Pages.PurchaseHistorys
{
    public class IndexModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public IndexModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PurchaseHistory> PurchaseHistory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PurchaseHistory != null)
            {
                PurchaseHistory = await _context.PurchaseHistory.ToListAsync();
            }
        }
    }
}
