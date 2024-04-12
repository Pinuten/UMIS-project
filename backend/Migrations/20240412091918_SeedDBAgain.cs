using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedDBAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 11, 19, 18, 54, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 11, 19, 18, 54, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 11, 19, 18, 54, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 11, 19, 18, 54, DateTimeKind.Local).AddTicks(1820));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 10, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 11, 18, 39, 692, DateTimeKind.Local).AddTicks(7090));
        }
    }
}
