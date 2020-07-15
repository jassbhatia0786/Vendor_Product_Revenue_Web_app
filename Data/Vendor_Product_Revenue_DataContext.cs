using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendor_Product_Revenue_Web_app.Business;

namespace Vendor_Product_Revenue_Web_app.Models
{
    //Connects the database with Business layer classes using Entity framework.
    public class Vendor_Product_Revenue_DataContext : DbContext
    {
        public Vendor_Product_Revenue_DataContext (DbContextOptions<Vendor_Product_Revenue_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Vendor_Product_Revenue_Web_app.Business.Product> Product { get; set; }

        public DbSet<Vendor_Product_Revenue_Web_app.Business.Revenue> Revenue { get; set; }

        public DbSet<Vendor_Product_Revenue_Web_app.Business.StoreFront> StoreFront { get; set; }

        public DbSet<Vendor_Product_Revenue_Web_app.Business.Vendor> Vendor { get; set; }
    }
}
