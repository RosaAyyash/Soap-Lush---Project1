using Microsoft.EntityFrameworkCore;
using SoapLush.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SoapLush.Data
{
    public class SoapLushDbContext : DbContext
    {

        public SoapLushDbContext(DbContextOptions<SoapLushDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOptional(u => u.SubCategory)
                .WithMany(d => d.Products)
                .HasForeignKey(u => u.SubCategoryId);
        }*/


    }
}
