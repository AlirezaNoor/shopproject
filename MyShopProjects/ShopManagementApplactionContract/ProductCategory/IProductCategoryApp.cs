using OperationResult;
namespace ShopManagementApplactionContract.ProductCategory
{
    public interface IProductCategoryApp
    {
        OperationResults CrateCategory(Create command);
        Edite FindMyProduct(long Id);
        OperationResults Edited(Edite commnad);
        List<ViewModel> search(SearchModel search);
    }
}
