using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aea98e7-ff3e-4128-b76c-959e844c0f36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5cdb112-3f51-4144-a99f-f1acdaad2d2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e3214a6-8e8c-4226-be9c-9f3113c6fed4", null, "Administrator", "ADMINISTRATOR" },
                    { "c866717e-91e4-4466-a973-4528601ae54b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e3214a6-8e8c-4226-be9c-9f3113c6fed4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c866717e-91e4-4466-a973-4528601ae54b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6aea98e7-ff3e-4128-b76c-959e844c0f36", null, "Administrator", "ADMINISTRATOR" },
                    { "a5cdb112-3f51-4144-a99f-f1acdaad2d2f", null, "User", "USER" }
                });
        }
    }
}
