using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class addStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Eaten = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1510), "b4b0c8cc-63f4-47e7-99e7-c86cb8661cb2" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 30, 30, 270, DateTimeKind.Local).AddTicks(1550), "4ceeb16e-d32a-459f-b81f-d88b60dafd0b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 8, 38, 747, DateTimeKind.Local).AddTicks(1020), "8b086b08-8d91-4dc7-a9ea-2661cc70e3f4" });

            migrationBuilder.UpdateData(
                table: "Matlador",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Guid" },
                values: new object[] { new DateTime(2024, 4, 10, 23, 8, 38, 747, DateTimeKind.Local).AddTicks(1060), "ed4c5369-aab3-4198-8a60-bf4bad8a6ae5" });
        }
    }
}
