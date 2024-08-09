using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(PostTagEntityTypeConfiguration))]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }

    public class PostTagEntityTypeConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasNoKey();
        }
    }
}
