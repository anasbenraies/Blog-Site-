using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishedDateTime = table.Column<DateTime>(nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Url" },
                values: new object[] { 1, "http://blogs.packtpub.com/dotnet" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Url" },
                values: new object[] { 2, "http://blogs.packtpub.com/dotnetcore" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "PublishedDateTime", "Title" },
                values: new object[] { 1, 1, "Dotnet 4.7 Released Contents", new DateTime(2022, 11, 17, 20, 3, 54, 771, DateTimeKind.Local).AddTicks(1840), "Dotnet 4.7 Released" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "PublishedDateTime", "Title" },
                values: new object[] { 2, 1, "Dotnet 4.8 Released Contents", new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831), "Dotnet 4.8 Released" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "PublishedDateTime", "Title" },
                values: new object[] { 3, 2, "testContent", new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831), "testTitle" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
