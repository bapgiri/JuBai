using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuBai.Migrations
{
    public partial class AddCategoryNameAndTagIdToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Update existing data if necessary
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 7, 53, 28, 261, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 7, 53, 28, 261, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 7, 53, 28, 261, DateTimeKind.Local).AddTicks(5504));
        }
    }
}
