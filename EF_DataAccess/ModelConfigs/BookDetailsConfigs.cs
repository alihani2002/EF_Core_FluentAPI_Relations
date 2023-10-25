using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class BookDetailsConfigs : IEntityTypeConfiguration<BookDetails>
    {
        public BookDetailsConfigs() { }
        public void Configure(EntityTypeBuilder<BookDetails> builder)
        {
            builder.ToTable("Book Details Data");

            builder.HasKey(bk => bk.Id).HasName("BookDetailsId");

            builder.Property(bd => bd.NumberOfChapter).IsRequired();

            builder.Property(bd => bd.NumberOfPage).IsRequired();

            builder.Property(bd => bd.Weight).IsRequired();

            //navigation Property
            builder.HasMany(bd => bd.Books).WithOne(bd => bd.BookDetails);
        }

    }
}
