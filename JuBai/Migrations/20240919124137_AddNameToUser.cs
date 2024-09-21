using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuBai.Migrations
{
    /// <inheritdoc />
    public partial class AddNameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 19, 14, 41, 36, 553, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 19, 14, 41, 36, 553, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 19, 14, 41, 36, 553, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Name", "PasswordHash", "Role", "Username" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John Doe", "", "Reader", "johndoe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 59, 15, 365, DateTimeKind.Local).AddTicks(7291), "admin@jubai.com", "hashedpassword", "Admin", "admin" });
        }
    }
}
