using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDOperations.Migrations
{
    /// <inheritdoc />
    public partial class AddToCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddToCartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddToCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddToCartProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddToCartOriginalPrice = table.Column<double>(type: "float", nullable: false),
                    AddToCartDiscountOff = table.Column<int>(type: "int", nullable: false),
                    AddToCartQuantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddToCartDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddToCartDetails");
        }
    }
}
