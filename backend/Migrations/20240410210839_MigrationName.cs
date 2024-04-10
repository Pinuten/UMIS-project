using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EatenCount",
                table: "Matlador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EatenCount", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 8, 38, 747, DateTimeKind.Local).AddTicks(1020), 0, "8b086b08-8d91-4dc7-a9ea-2661cc70e3f4" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EatenCount", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 8, 38, 747, DateTimeKind.Local).AddTicks(1060), 0, "ed4c5369-aab3-4198-8a60-bf4bad8a6ae5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EatenCount",
                table: "Matlador");

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 13, 23, 5, 804, DateTimeKind.Local).AddTicks(9690), "cf995e07-9cf2-411a-b6ba-0fc7421ee60f" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 13, 23, 5, 804, DateTimeKind.Local).AddTicks(9740), "20b69a65-4787-4b43-b4d7-778eac508ac3" });
        }
    }
}
