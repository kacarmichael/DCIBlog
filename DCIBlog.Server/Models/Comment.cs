using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(CommentEntityTypeConfiguration))]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public User Author { get; set; }
        public string Content { get; set; }
        public int ParentId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        public BlogPost BlogPost { get; set; }
        public int PostId => BlogPost.Id;
    }

    public class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .ToTable("comments", schema: "blogInfra");
            builder
                .Property(comment => comment.Id)
                .IsRequired();
            
        }
    }
}
