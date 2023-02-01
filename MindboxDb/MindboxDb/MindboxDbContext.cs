using Microsoft.EntityFrameworkCore;
using MindboxDb.Models;

namespace MindboxDb
{
    public class MindboxDbContext : DbContext
    {
        public DbSet<Category> CategoriesDb { get; set; }

        public DbSet<Product> ProductsDb { get; set; }

        public MindboxDbContext(DbContextOptions config) : base(config)
        {

            base.Database.EnsureDeleted();
            base.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categories
            var fruitCategory = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "fruit"
            };
            var phoneCategory = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "phone"
            };
            var animalCategory = new Category()
            {
                Id = Guid.NewGuid(),
                Name = "animal"
            };

            //Products
            var appleProduct = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "apple"
            };
            var catProduct = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "cat"
            };
            var kiwiProduct = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "kiwi"
            };
            var cakeProduct = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "cake"
            };

            //Model building
            modelBuilder.Entity<Category>()
                .HasData(new List<Category>()
                {
                    fruitCategory,
                    phoneCategory,
                    animalCategory
                });

            modelBuilder.Entity<Product>()
                .HasData(new List<Product>()
                {
                    appleProduct,
                    catProduct,
                    kiwiProduct,
                    cakeProduct
                });

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j =>
                {
                    j.ToTable("CategoryProduct");
                    j.HasData(
                        new { CategoriesId = fruitCategory.Id, ProductsId = appleProduct.Id },
                        new { CategoriesId = phoneCategory.Id, ProductsId = appleProduct.Id },

                        new { CategoriesId = fruitCategory.Id, ProductsId = kiwiProduct.Id },
                        new { CategoriesId = animalCategory.Id, ProductsId = kiwiProduct.Id },

                        new { CategoriesId = phoneCategory.Id, ProductsId = catProduct.Id },
                        new { CategoriesId = animalCategory.Id, ProductsId = catProduct.Id }
                        );
                });
        }
    }
}
