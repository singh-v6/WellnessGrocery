using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WellnessGrocery.Models;

namespace WellnessGrocery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WellnessGrocery.Models.User> User { get; set; }
        public DbSet<WellnessGrocery.Models.Product> Product { get; set; }
        public DbSet<WellnessGrocery.Models.Order> Order { get; set; }
        public DbSet<WellnessGrocery.Models.Orderdetail> Orderdetail { get; set; }
        public DbSet<WellnessGrocery.Models.Inventory> Inventory { get; set; }
    }
}