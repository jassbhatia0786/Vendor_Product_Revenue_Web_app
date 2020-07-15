using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor_Product_Revenue_Web_app.Business;
using Vendor_Product_Revenue_Web_app.Models;

namespace Vendor_Product_Revenue_Web_app.Pages.StoreFronts
{
    public class EditModel : PageModel
    {
        private readonly Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext _context;

        public EditModel(Vendor_Product_Revenue_Web_app.Models.Vendor_Product_Revenue_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StoreFront StoreFront { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StoreFront = await _context.StoreFront.FirstOrDefaultAsync(m => m.Id == id);

            if (StoreFront == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StoreFront).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreFrontExists(StoreFront.Id))
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

        private bool StoreFrontExists(int id)
        {
            return _context.StoreFront.Any(e => e.Id == id);
        }
    }
}
