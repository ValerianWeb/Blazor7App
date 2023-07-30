using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor7App.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A sweet and fruity delight combined with custard, vanilla, malt, cream, strawberry, red berries and pink rhubarb combine in this super strong fragrance.", "CandleCrumble.png", "Crumble Candle", 27.5m },
                    { 2, 0, "A combination of vibrant, fruity accord of juicy black plum, blackberry and fresh rhubarb supported with interludes of ripe pear and sweet peach.", "CandlePlumPudding.png", "Plum Pudding Candle", 48.95m },
                    { 3, 1, "Our natural soy wax candles are sustainable and blended with high-quality fragrances and hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide your home with a delicately scented steady burn time of up to 90 hours, (depending on size). Our candles are presented in a beautiful design box (which may change from time to time), providing you with the perfect gift for all occasions.", "Lily_of_the_valleyIMG_2224.JPG", "Lilly of the Valley", 19.50m },
                    { 4, 1, "Our natural soy wax candles are sustainable and blended with high-quality fragrances and hand-poured into recyclable/refill and elegant glass jars with beautiful wooden lids to provide your home with a delicately scented steady burn time of up to 90 hours, (depending on size). Our candles are presented in a beautiful design box (which may change from time to time), providing you with the perfect gift for all occasions.", "LemonDrizzelCandleIMG_2154.JPG", "Lemon Drizzle Candle", 34.95m },
                    { 5, 2, "Aromatic vintage cologne notes lead into a heart of rich sweet tobacco, warm spices and a hint of cognac. Smokey woods of oak, ebony and incense combine with dark musk to complete this fragrance.", "CandlePlumPudding.png", "Cuban Oak Diffuser", 79500m },
                    { 6, 2, "Desciption Missing", "CandlePlumPudding.png", "Pandoras Box Diffuser", 16m },
                    { 7, 2, "Grapefruit, Lime & Sweet Orange ", "LemonDrizzle.jpg", "Citric Delight", 29.95m },
                    { 8, 2, "This is a simple but classic scent. A fruity, floral combination of cranberriesfollowed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,cedar, musk and vanilla", "CandlePlumPudding.png", "Stress Buster", 75m },
                    { 9, 4, "This is a simple but classic scent. A fruity, floral combination of cranberriesfollowed by orange and cinnamon with floral back notes of jasmine and lily on a base of sandal,cedar, musk and vanilla", "CandlePlumPudding.png", "Calm Bath Bomb", 1200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
