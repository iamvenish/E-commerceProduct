using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDOperations.Migrations
{
    /// <inheritdoc />
    public partial class FixModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountOff",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "OrginalPrice",
                table: "ProductDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountOff",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "OrginalPrice",
                table: "ProductDetails");
        }
    }
}
