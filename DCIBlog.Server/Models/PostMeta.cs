using DCIBlog.Server.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(PostMetaEntityTypeConfiguration))]
    public class PostMeta
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }
        public PostMeta() 
        {
            //accountAge = new DateTimeDelta(DateTime.UtcNow, createdAt);
        }

    }
    public class PostMetaEntityTypeConfiguration : IEntityTypeConfiguration<PostMeta>
    {
        public void Configure(EntityTypeBuilder<PostMeta> builder)
        {
            builder
                .ToTable("PostMeta", schema: "blogInfra");
            builder
                .Property(pm => pm.Id)
                .IsRequired();
            builder
                .Property(pm => pm.PostId)
                .IsRequired();
            builder
                .Property(pm => pm.Key)
                .IsRequired();
        }
    }
}