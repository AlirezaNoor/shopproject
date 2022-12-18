using System.Linq.Expressions;
using ShopManagementApplactionContract.ProductCategory;

namespace ShopManagementDomin.ProductCategory
{
   public  interface  IProductCategoryReposetory
    {
        void Create(ProductCategoryAgg entity);
         ProductCategoryAgg GetbyId(long id);
         List<ProductCategoryAgg> MyCategory();
         bool Exists(Expression<Func<ProductCategoryAgg,bool>> expression);
         void savechanges();
         Edite GetDetails(long id);
         List<ViewModel> SearchCategory(SearchModel search);
    }
}
