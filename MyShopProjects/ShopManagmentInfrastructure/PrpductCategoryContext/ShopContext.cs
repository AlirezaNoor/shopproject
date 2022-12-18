using Microsoft.EntityFrameworkCore;
using ShopManagementDomin.ProductCategory;
using ShopManagmentInfrastructure.Mapping;

namespace ShopManagmentInfrastructure.PrpductCategoryContext
{
    public class ShopContext : DbContext
    {
        public DbSet<ProductCategoryAgg> Productcategores { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembely = typeof(CategoryProductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembely);


        }
    }
}
