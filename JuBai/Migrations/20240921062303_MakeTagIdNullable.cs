using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuBai.Migrations
{
    /// <inheritdoc />
    public partial class MakeTagIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 23, 2, 705, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 23, 2, 705, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 23, 2, 705, DateTimeKind.Local).AddTicks(1671));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 2, 34, 240, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 2, 34, 240, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 2, 34, 240, DateTimeKind.Local).AddTicks(8994));
        }
    }
}
