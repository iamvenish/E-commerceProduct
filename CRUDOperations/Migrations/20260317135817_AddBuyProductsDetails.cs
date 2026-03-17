using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDOperations.Migrations
{
    /// <inheritdoc />
    public partial class AddBuyProductsDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyProductsDetails",
                columns: table => new
                {
                    BuyProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BuyRating = table.Column<int>(type: "int", nullable: false),
                    BuyOrignalPrice = table.Column<double>(type: "float", nullable: false),
                    BuyDiscountOff = table.Column<int>(type: "int", nullable: false),
                    BuyPrice = table.Column<double>(type: "float", nullable: false),
                    BuyImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyProductsDetails", x => x.BuyProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyProductsDetails");
        }
    }
}
