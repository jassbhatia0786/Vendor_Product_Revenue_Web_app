﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vendor_Product_Revenue_Web_app.Business;
using Vendor_Product_Revenue_Web_app.Models;

namespace Vendor_Product_Revenue_Web_app.Pages.Vendors
{
    public class IndexModel : PageModel
    {
        private readonly Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext _context;

        public IndexModel(Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext context)
        {
            _context = context;
        }

        public IList<Vendor> Vendor { get;set; }

        public async Task OnGetAsync()
        {
            Vendor = await ( from vendor in _context.Vendor select vendor).ToListAsync();
        }
    }
}
