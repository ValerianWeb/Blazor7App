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
                    Name = "Crumble Candle", 
                    Description = "A sweet and fruity delight combined with custard, vanilla, malt,"
                        + " cream, strawberry, red berries and pink rhubarb combine in this super"
                        + " strong fragrance.",
                    Category = ProductCategories.Candles, 
                    Image = "CandleCrumble.png",
                    Price = 27.5m 
                },
                new Product 
                { 
                    ProductId = 2, 
                    Name = "Plum Pudding Candle",
                    Description = "A combination of vibrant, fruity accord of juicy black plum,"
                        + " blackberry and fresh rhubarb supported with interludes of ripe pear"
                        + " and sweet peach.",
                    Image = "CandlePlumPudding.png",
                    Category = ProductCategories.None, 
                    Price = 48.95m 
                },
                new Product 
                { 
                    ProductId = 3,
                    Name = "Lilly of the Valley",
                    Description = "Our natural soy wax candles are sustainable and blended with high-quality fragrances "
                    + "and hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide"
                    + " your home with a delicately scented steady burn time of up to 90 hours, (depending on size). "
                    + "Our candles are presented in a beautiful design box (which may change from time to time), "
                    + "providing you with the perfect gift for all occasions.",
                    Image = "Lily_of_the_valleyIMG_2224.JPG",
                    Category = ProductCategories.Candles, 
                    Price = 19.50m 
                },
                new Product 
                { 
                    ProductId = 4,
                    Name = "Lemon Drizzle Candle",
                    Description = "Our natural soy wax candles are sustainable and blended with high-quality fragrances and "
                    + "hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide your home"
                    + " with a delicately scented steady burn time of up to 90 hours, (depending on size). "
                    + "Our candles are presented in a beautiful design box (which may change from time to time), "
                    + "providing you with the perfect gift for all occasions.",
                    Image = "LemonDrizzelCandleIMG_2154.JPG",
                    Category = ProductCategories.Candles, 
                    Price = 34.95m 
                },
                new Product 
                { ProductId = 5,
                    Name = "Cuban Oak Diffuser",
                    Description = "Aromatic vintage cologne notes lead into a heart of rich sweet tobacco, warm spices and a hint of cognac. "
                    + "Smokey woods of oak, ebony and incense combine with dark musk to complete this fragrance.",
                    Image = "CandlePlumPudding.png",
                    Category = ProductCategories.Diffusers, 
                    Price = 79500 
                },
                new Product 
                { 
                    ProductId = 6,
                    Name = "Pandoras Box Diffuser",
                    Description = "Desciption Missing",
                    Image = "CandlePlumPudding.png",
                    Category = ProductCategories.Diffusers, 
                    Price = 16 
                },
                new Product 
                { 
                    ProductId = 7,
                    Name = "Citric Delight",
                    Description = "Grapefruit, Lime & Sweet Orange ",
                    Image = "LemonDrizzle.jpg",
                    Category = ProductCategories.Diffusers, 
                    Price = 29.95m 
                },
                new Product 
                { 
                    ProductId = 8,
                    Name = "Stress Buster",
                    Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
                    + "followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
                    + "cedar, musk and vanilla",
                    Image = "CandlePlumPudding.png",
                    Category = ProductCategories.Diffusers, 
                    Price = 75 
                },
                new Product 
                { 
                    ProductId = 9,
                    Name = "Calm Bath Bomb",
                    Description = "This is a simple but classic scent. A fruity, floral combination of cranberries"
                    + "followed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,"
                    + "cedar, musk and vanilla",
                    Image = "CandlePlumPudding.png",
                    Category = ProductCategories.Books, 
                    Price = 1200 
                }
            );
        }

    }
}