﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vendor_Product_Revenue_Web_app.Business;
using Vendor_Product_Revenue_Web_app.Models;

namespace Vendor_Product_Revenue_Web_app.Pages.Revenues
{
    public class DetailsModel : PageModel
    {
        private readonly Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext _context;

        public DetailsModel(Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext context)
        {
            _context = context;
        }

        public Revenue Revenue { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Revenue = await _context.Revenue
                .Include(r => r.Product)
                .Include(r => r.StoreFront).FirstOrDefaultAsync(m => m.Id == id);

            if (Revenue == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
