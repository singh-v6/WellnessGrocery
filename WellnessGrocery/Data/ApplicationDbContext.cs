using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using WellnessGrocery.Models;
=======
using WellnessGrocery.wwwroot.Models;
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0

namespace WellnessGrocery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<WellnessGrocery.Models.User> User { get; set; }
        public DbSet<WellnessGrocery.Models.Product> Product { get; set; }
        public DbSet<WellnessGrocery.Models.Order> Order { get; set; }
        public DbSet<WellnessGrocery.Models.Orderdetail> Orderdetail { get; set; }
        public DbSet<WellnessGrocery.Models.Inventory> Inventory { get; set; }
=======
        public DbSet<WellnessGrocery.wwwroot.Models.Customer> Customer { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Inventory> Inventory { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Order> Order { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.Product> Product { get; set; }
        public DbSet<WellnessGrocery.wwwroot.Models.PurchaseHistory> PurchaseHistory { get; set; }
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
    }
}