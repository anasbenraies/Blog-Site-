using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySite.BL.Entities;


namespace MySiteDAL
{
    internal class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Url = "http://blogs.packtpub.com/dotnet"
                },
                new Blog
                {
                    Id = 2,
                    Url = "http://blogs.packtpub.com/dotnetcore"
                }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    BlogId = 1,
                    Title = "Dotnet 4.7 Released",
                    Content = "Dotnet 4.7 Released Contents",
                    PublishedDateTime = DateTime.Now
                },
                new Post
                {
                    Id = 2,
                    BlogId = 1,
                    Title = "Dotnet 4.8 Released",
                    Content = "Dotnet 4.8 Released Contents",
                    PublishedDateTime = DateTime.Now
                },
                new Post
                {
                    Id = 3,
                    BlogId = 2,
                    Title = "testTitle",
                    Content = "testContent",
                    PublishedDateTime = DateTime.Now
                }
            );
        }
    }
}