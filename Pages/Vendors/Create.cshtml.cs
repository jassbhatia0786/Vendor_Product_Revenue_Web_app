using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vendor_Product_Revenue_Web_app.Business;
using Vendor_Product_Revenue_Web_app.Models;

namespace Vendor_Product_Revenue_Web_app.Pages.Vendors
{
    public class CreateModel : PageModel
    {
        private readonly Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext _context;

        public CreateModel(Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vendor Vendor { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vendor.Add(Vendor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
