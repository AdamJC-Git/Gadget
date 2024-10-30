using GadgetCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace GadgetCompany.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    Id = 1,
                    Type = "Phone",
                    Description = "Phones that are new or in good condition"
                },
                new ProductType 
                {
                    Id = 2,
                    Type = "Laptop",
                    Description = "Brand new laptops"
                },
                new ProductType
                {
                    Id = 3,
                    Type = "Personal computers",
                    Description = "Recycled and used computers"
                });


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Samsung",
                    Description = "High spec Android phone",
                    Price = 90,
                    StockQuantity = 85,
                    ProductTypeId = 1
                },
                 new Product
                 {
                     Id = 2,
                     Name = "IPhone",
                     Description = "Good Apple iPhone 9",
                     Price = 130,
                     StockQuantity = 50,
                     ProductTypeId = 1
                 },
                  new Product
                  {
                      Id = 3,
                      Name = "Dell",
                      Description = "Dell Inspiron",
                      Price = 200,
                      StockQuantity = 35,
                      ProductTypeId = 2
                  },
                   new Product
                   {
                       Id = 4,
                       Name = "Dell",
                       Description = "A personal computer",
                       Price = 99,
                       StockQuantity = 15,
                       ProductTypeId = 3
                   });
        }
    }


}
