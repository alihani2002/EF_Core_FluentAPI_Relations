using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class BookConfigs : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book Data");

            builder.HasKey(b => b.Id).HasName("BookId");

            builder.Property(b => b.Name).HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(b => b.ISBN).HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(b => b.Price).IsRequired();

            //navigation Property 

            builder.HasOne(BD => BD.BookDetails).WithMany(BD => BD.Books).HasForeignKey(BD => BD.BookDetailsId);
            builder.HasOne(BD => BD.Publisher).WithMany(BD => BD.Books).HasForeignKey(BD => BD.PublisherId);
            builder.HasOne(BD => BD.Category).WithMany(BD => BD.Books).HasForeignKey(BD => BD.CategoryId);

            //modelBuilder.Entity<Employee>().HasOne(e => e.Company).WithMany(c => c.Employees);

        }
    }
}
