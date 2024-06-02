using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZakatHelper.Migrations.ZakatAuthDb
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b3f5e8e-2a09-48fb-85c6-65e70b46af2c", "0b3f5e8e-2a09-48fb-85c6-65e70b46af2c", "admin", "admin" },
                    { "10c43cf9-0ee4-4ef0-a941-8ffa27d43f3a", "10c43cf9-0ee4-4ef0-a941-8ffa27d43f3a", "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b3f5e8e-2a09-48fb-85c6-65e70b46af2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10c43cf9-0ee4-4ef0-a941-8ffa27d43f3a");
        }
    }
}
