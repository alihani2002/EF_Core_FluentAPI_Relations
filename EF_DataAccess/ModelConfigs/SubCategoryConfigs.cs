using EF_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_DataAccess.ModelConfigs
{
    public class SubCategoryConfigs : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("SubCategories Table");

            builder.HasKey(sc => sc.Id).HasName("CategoryID");

            builder.Property(sc => sc.Name).HasColumnType("nvarchar(50)").IsRequired();

            //Navigation Property

            builder.HasMany(sc => sc.Category).WithOne(sc => sc.SubCategory);
        }
    }
}
