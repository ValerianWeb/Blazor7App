using Blazor7App.Server.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Blazor7App.Shared;

namespace Blazor7App.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        // Add a DbSet for each entity type that you want to include in your model.
        public DbSet<Product> Products { get; set; } = null!;

            // seed the database with products
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    ProductId = 1, 
                    Name = "Kayak", 
                    Description = "A boat for one person", 
                    Category = ProductCategories.None, 
                    Price = 275 
                },
                new Product 
                { 
                    ProductId = 2, 
                    Name = "Lifejacket", 
                    Description = "Protective and fashionable", 
                    Category = ProductCategories.None, 
                    Price = 48.95m 
                },
                new Product 
                { 
                    ProductId = 3, 
                    Name = "Soccer Ball", 
                    Description = "FIFA-approved size and weight", 
                    Category = ProductCategories.None, 
                    Price = 19.50m 
                },
                new Product 
                { 
                    ProductId = 4, 
                    Name = "Corner Flags", 
                    Description = "Give your playing field a professional touch", 
                    Category = ProductCategories.None, 
                    Price = 34.95m 
                },
                new Product 
                { ProductId = 5, 
                    Name = "Stadium", 
                    Description = "Flat-packed 35,000-seat stadium", 
                    Category = ProductCategories.None, 
                    Price = 79500 
                },
                new Product 
                { 
                    ProductId = 6, 
                    Name = "Thinking Cap", 
                    Description = "Improve brain efficiency by 75%", 
                    Category = ProductCategories.Books, 
                    Price = 16 
                },
                new Product 
                { 
                    ProductId = 7, 
                    Name = "Unsteady Chair", 
                    Description = "Secretly give your opponent a disadvantage", 
                    Category = ProductCategories.Books, 
                    Price = 29.95m 
                },
                new Product 
                { 
                    ProductId = 8, 
                    Name = "Human Chess Board", 
                    Description = "A fun game for the family", 
                    Category = ProductCategories.Books, 
                    Price = 75 
                },
                new Product 
                { 
                    ProductId = 9, 
                    Name = "Bling-Bling King", 
                    Description = "Gold-plated, diamond-studded King", 
                    Category = ProductCategories.Books, 
                    Price = 1200 
                }
            );
        }

    }
}