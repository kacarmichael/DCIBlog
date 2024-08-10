using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(BlogPostEntityTypeConfiguration))]
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string? MetaTitle { get; set; }
        public string? Slug { get; set; }
        public string Content { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }

        public ICollection<Comment>? Comments { get; }
        public BlogPost(string title, string content) 
        { 
            Title = title;
            Content = content;
            CreatedAt = DateTime.UtcNow;
        }
    }

    public class BlogPostEntityTypeConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder
                .ToTable("blogposts", schema: "blogInfra");
            builder
                .Property(bp => bp.Id)
                .IsRequired();
        }
    }
}
