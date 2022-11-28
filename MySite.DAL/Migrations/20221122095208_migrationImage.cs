using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.DAL.Migrations
{
    public partial class migrationImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 10, 52, 7, 408, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 10, 52, 7, 409, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 10, 52, 7, 409, DateTimeKind.Local).AddTicks(8213));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 17, 20, 3, 54, 771, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831));
        }
    }
}
