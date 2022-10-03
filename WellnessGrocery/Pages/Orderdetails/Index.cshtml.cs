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
    public class IndexModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public IndexModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Orderdetail> Orderdetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orderdetail != null)
            {
                Orderdetail = await _context.Orderdetail
                .Include(o => o.Order)
                .Include(o => o.Product).ToListAsync();
            }
        }
    }
}
