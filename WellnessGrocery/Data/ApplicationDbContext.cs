using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.wwwroot.Models;

namespace WellnessGrocery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WellnessGrocery.wwwroot.Models.Customer> Customer { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Inventory> Inventory { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Order> Order { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Product> Product { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.PurchaseHistory> PurchaseHistory { get; set; }
    }
}