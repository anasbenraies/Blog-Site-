using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.DAL.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 11, 47, 24, 575, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 11, 47, 24, 575, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDateTime",
                value: new DateTime(2022, 11, 22, 11, 47, 24, 575, DateTimeKind.Local).AddTicks(6867));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
