using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuBai.Migrations
{
    /// <inheritdoc />
    public partial class MakeTagIdNullableInPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: true, // Make this nullable
                oldClrType: typeof(int),
                oldNullable: false);

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 27, 54, 660, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 9, 21, 8, 27, 54, 660, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TagId" },
                values: new object[] { new DateTime(2024, 9, 21, 8, 27, 54, 660, DateTimeKind.Local).AddTicks(4618), null });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: false, // Make this non-nullable
                oldClrType: typeof(int),
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "TagId" },
                values: new object[] { new DateTime(2024, 9, 21, 8, 23, 2, 705, DateTimeKind.Local).AddTicks(1671), 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
