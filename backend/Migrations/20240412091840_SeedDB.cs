using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7000), "Chicken Salad Lunchbox" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7080), "Fruit Snack Lunchbox" });

            migrationBuilder.InsertData(
                table: "Matlador",
                columns: new[] { "Id", "CreatedAt", "Name", "Size" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 4, 9, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7090), "Pasta Lunchbox", 0 },
                    { 4, new DateTime(2024, 4, 8, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7090), "Vegan Wrap Lunchbox", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 11, 9, 59, 9, 250, DateTimeKind.Local).AddTicks(9600), "My First Matlada" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 11, 9, 59, 9, 250, DateTimeKind.Local).AddTicks(9630), "My Second Matlada" });
        }
    }
}
