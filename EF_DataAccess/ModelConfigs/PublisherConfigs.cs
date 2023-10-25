using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class PublisherConfigs : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publisher Table");

            builder.HasKey(p => p.Id).HasName("PublisherID");

            builder.Property(p => p.Name).HasColumnType("nvarchar(50)").IsRequired();

            //Navigation
            builder.HasMany(P => P.Books).WithOne(p => p.Publisher);

        }
    }
}
