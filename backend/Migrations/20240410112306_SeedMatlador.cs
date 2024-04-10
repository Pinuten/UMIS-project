using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMatlador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matlador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matlador", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Matlador",
                columns: new[] { "Id", "CreatedAt", "Guid", "Name", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 10, 13, 23, 5, 804, DateTimeKind.Local).AddTicks(9690), "cf995e07-9cf2-411a-b6ba-0fc7421ee60f", "My First Matlada", 0 },
                    { 2, new DateTime(2024, 4, 10, 13, 23, 5, 804, DateTimeKind.Local).AddTicks(9740), "20b69a65-4787-4b43-b4d7-778eac508ac3", "My Second Matlada", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matlador");
        }
    }
}
