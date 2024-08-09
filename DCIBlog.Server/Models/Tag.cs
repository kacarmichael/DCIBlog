using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(TagEntityTypeConfiguration))]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
    }

    public class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder
                .ToTable("tags", schema: "blogInfra");
            builder
                .Property(tag => tag.Id)
                .IsRequired();
            
        }
    }
}
