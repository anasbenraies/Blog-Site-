// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySite.DAL;

namespace MySite.DAL.Migrations
{
    [DbContext(typeof(MySiteContext))]
    [Migration("20221117190355_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySite.BL.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Url = "http://blogs.packtpub.com/dotnet"
                        },
                        new
                        {
                            Id = 2,
                            Url = "http://blogs.packtpub.com/dotnetcore"
                        });
                });

            modelBuilder.Entity("MySite.BL.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Content = "Dotnet 4.7 Released Contents",
                            PublishedDateTime = new DateTime(2022, 11, 17, 20, 3, 54, 771, DateTimeKind.Local).AddTicks(1840),
                            Title = "Dotnet 4.7 Released"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Content = "Dotnet 4.8 Released Contents",
                            PublishedDateTime = new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831),
                            Title = "Dotnet 4.8 Released"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 2,
                            Content = "testContent",
                            PublishedDateTime = new DateTime(2022, 11, 17, 20, 3, 54, 772, DateTimeKind.Local).AddTicks(1831),
                            Title = "testTitle"
                        });
                });

            modelBuilder.Entity("MySite.BL.Entities.Post", b =>
                {
                    b.HasOne("MySite.BL.Entities.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
