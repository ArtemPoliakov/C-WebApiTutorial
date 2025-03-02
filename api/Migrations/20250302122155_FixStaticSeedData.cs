using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FixStaticSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8612de63-954b-4e2d-ae06-818bfc58d344");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe471cc6-4191-4907-ab4c-123fd6e86853");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8958b3bb-fd08-4e83-a2ef-83d9c5a8de68", null, "User", "USER" },
                    { "a1fd445c-0902-4de8-8d57-52fb2051f33d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8958b3bb-fd08-4e83-a2ef-83d9c5a8de68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1fd445c-0902-4de8-8d57-52fb2051f33d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8612de63-954b-4e2d-ae06-818bfc58d344", null, "User", "USER" },
                    { "fe471cc6-4191-4907-ab4c-123fd6e86853", null, "Admin", "ADMIN" }
                });
        }
    }
}
