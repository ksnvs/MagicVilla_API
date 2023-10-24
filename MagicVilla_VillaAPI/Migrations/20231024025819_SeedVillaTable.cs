using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occuoancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "sdsadsadsa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 Tince Max", "dsdasda", "Royal Villa", 100, 100.0, 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "sdsadsadsa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 Tince Max", "dsdasda", "Premium Pool Villa", 100, 300.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "sdsadsadsa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 Tince Max", "dsdasda", "Luxury Pool Villa", 100, 400.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "sdsadsadsa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 Tince Max", "dsdasda", "Diamond Villa", 100, 100.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "sdsadsadsa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 Tince Max", "dsdasda", "Dimond Pool Villa", 100, 200.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
