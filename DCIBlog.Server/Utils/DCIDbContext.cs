using DCIBlog.Server.Controllers;
using DCIBlog.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace DCIBlog.Server.Utils
{
    public class DCIDbContext : DbContext
    {
        public DCIDbContext(DbContextOptions<DCIDbContext> options) : base(options) 
        { 
            
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.UseSqlServer("name=ConnectionStrings:default");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("blogInfra");
            modelBuilder.Entity<BlogPost>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.BlogPost)
                .HasForeignKey(e => e.Id)
                .HasPrincipalKey(e => e.Id);
        }
    }

    
}
