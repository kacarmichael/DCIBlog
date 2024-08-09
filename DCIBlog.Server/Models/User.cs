using DCIBlog.Server.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DCIBlog.Server.Models
{
    [EntityTypeConfiguration(typeof(UserEntityTypeConfiguration))]
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string EmailVerified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        public bool Discoverable { get; set; }
        [Key]
        public int Id { get; set; }
        public string FullName => FirstName + LastName;
        //public DateTimeDelta accountAge { get; set; }
        public string Intro { get; set; }

        public string Profile { get; set; }
        
        public User() 
        {
            //accountAge = new DateTimeDelta(DateTime.UtcNow, createdAt);
        }

    }
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("users", schema: "blogInfra");
            builder
                .Property(user => user.Id)
                .IsRequired();
            builder
                .Property(user => user.Username)
                .IsRequired();
            builder
                .Property(user => user.Email)
                .IsRequired();
            builder
                .Property(user => user.PasswordHash)
                .IsRequired();
        }
    }
}
