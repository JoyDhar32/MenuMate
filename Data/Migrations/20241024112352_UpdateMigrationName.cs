using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuMate.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious goat taco", "Goat Taco" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A delicious beef taco", "Beef Taco" });
        }
    }
}
