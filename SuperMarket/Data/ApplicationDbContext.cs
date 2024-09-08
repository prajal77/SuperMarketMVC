using Microsoft.EntityFrameworkCore;
using SuperMarket.Models;

namespace SuperMarket.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        //create table
        public DbSet<Category> Categories { get; set; }

        //Seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Beverage", Description = "Beverage" },
            new Category { Id = 2, Name = "Bakery", Description = "Bakery" },
            new Category {Id = 3, Name = "Meat", Description = "Meat" }
                );
        }


    }
}
