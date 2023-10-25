using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors Data");

            builder.HasKey(e => e.Id).HasName("AuthorID");

            builder.Property(a=>a.FirstName).HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(a => a.LastName).HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(a => a.BirthDate).HasColumnType("date");
            
            builder.Ignore(a => a.FullName);
  
        }

    }
}
