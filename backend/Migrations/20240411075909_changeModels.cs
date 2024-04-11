using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class changeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EatenCount",
                table: "Matlador");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Matlador");

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 9, 59, 9, 250, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 11, 9, 59, 9, 250, DateTimeKind.Local).AddTicks(9630));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EatenCount",
                table: "Matlador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Matlador",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EatenCount", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1510), 0, "b4b0c8cc-63f4-47e7-99e7-c86cb8661cb2" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EatenCount", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1550), 0, "4ceeb16e-d32a-459f-b81f-d88b60dafd0b" });
        }
    }
}
