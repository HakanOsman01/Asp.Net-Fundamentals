using ForumApp.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
using System.Collections.Generic;

namespace ForumApp.Infrastructer.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private readonly Post[] intialPosts = new Post[]
        {
            new Post
            {
                Id = 1,
                Title = "My first Post",
                Content = "My first context",
            },
            new Post
            {
                Id = 2,
                Title = "My second Post",
                Content = "My second content",
            },
              new Post
              {
                Id = 3,
                Title = "My third Post",
                Content = "My third content",
              }
        };
        public void Configure(EntityTypeBuilder<Post> builder)
        {

            builder.HasData(intialPosts);
        }
        
    }
       
         
}
