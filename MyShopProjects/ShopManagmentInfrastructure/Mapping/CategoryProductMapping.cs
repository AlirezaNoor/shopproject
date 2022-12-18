using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagementDomin.ProductCategory;

namespace ShopManagmentInfrastructure.Mapping
{
    public class CategoryProductMapping:IEntityTypeConfiguration<ProductCategoryAgg>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryAgg> builder)
        {
            builder.ToTable("ProductsCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Altpicture).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Discription).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Title2).HasMaxLength(100).IsRequired();
            builder.Property(x => x.picture).HasMaxLength(900).IsRequired();


        }
    }
}
