using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class CategoryConfigs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories Table");

            builder.HasKey(c=> c.Id).HasName("CategoryID");

            builder.Property(c => c.Name).HasColumnType("nvarchar(50)").IsRequired();

            builder.Property(c => c.Description).IsRequired();

            //Navigation Property
            // relation many to one with book
            builder.HasMany(C => C.Books).WithOne(C => C.Category);
            // relation one to many with Subcategory
            builder.HasOne(C => C.SubCategory).WithMany(C => C.Category).HasForeignKey(C => C.SubCategoryId);

        }
    }
}
