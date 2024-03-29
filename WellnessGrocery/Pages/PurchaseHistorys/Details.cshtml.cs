﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly WellnessGrocery.Data.ApplicationDbContext _context;

        public DetailsModel(WellnessGrocery.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public PurchaseHistory PurchaseHistory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PurchaseHistory == null)
            {
                return NotFound();
            }

            var purchasehistory = await _context.PurchaseHistory.FirstOrDefaultAsync(m => m.PurchaseHistoryId == id);
            if (purchasehistory == null)
            {
                return NotFound();
            }
            else 
            {
                PurchaseHistory = purchasehistory;
            }
            return Page();
        }
    }
}
