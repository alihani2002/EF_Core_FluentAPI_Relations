using EF_DataAccess.ModelConfigs;
using EF_Models.dataTypeConvension;
using Microsoft.EntityFrameworkCore;

namespace EF_DataAccess.DataAccess
{
    public class DB_ContextApp : DbContext
    {
        #region DataBaseConnection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JEJ8BBV;Database=EF_Core;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        #endregion

        #region DateOnlyConverter
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyCustomConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);
        }
        #endregion

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent-API
            //Configure domain classes using modelBuilder here   
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfigs());
            modelBuilder.ApplyConfiguration(new BookDetailsConfigs());
            modelBuilder.ApplyConfiguration(new CategoryConfigs());
            modelBuilder.ApplyConfiguration(new SubCategoryConfigs());
            modelBuilder.ApplyConfiguration(new PublisherConfigs());
            modelBuilder.ApplyConfiguration(new BookAuthorConfigs());

        }
        #endregion

    }
}
