﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WellnessGrocery.Data;
using WellnessGrocery.Models;

namespace WellnessGrocery.Pages.Orderdetails
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
        ViewData["OrderID"] = new SelectList(_context.Order, "Id", "Id");
        ViewData["ProductID"] = new SelectList(_context.Product, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Orderdetail Orderdetail { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orderdetail.Add(Orderdetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}