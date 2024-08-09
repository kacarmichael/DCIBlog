using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(PostCategoryEntityTypeConfiguration))]
    public class PostCategory
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
    }

    public class PostCategoryEntityTypeConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.HasNoKey();
        }
    }
}
