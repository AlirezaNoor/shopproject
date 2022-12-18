using Application;
using OperationResult;
using ShopManagementApplactionContract.ProductCategory;
using ShopManagementDomin.ProductCategory;

namespace ShopManagementApplication.ProductCategory
{
    public class ProductCategoryApp : IProductCategoryApp
    {
        private readonly IProductCategoryReposetory _reposetory;

        public ProductCategoryApp(IProductCategoryReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResults CrateCategory(Create create)
        {
            var operation=new OperationResults();
            if (_reposetory.Exists(x=>x.Title==create.Title))
            {
                return operation.isfailed("نام کالا موجود است");
            }

            var slug = create.Slug.GenerateSlug();
            var catecory = new ProductCategoryAgg(create.Title2, create.Discription, create.picture,
                create.Altpicture, create.Title, slug);
            _reposetory.Create(catecory);
            _reposetory.savechanges();
            return operation.secsseced();
        }

        public Edite FindMyProduct(long Id)
        {

            return _reposetory.GetDetails(Id);
        }

        public OperationResults Edited(Edite edite)
        {
            var operation = new OperationResults();
            var foredite = _reposetory.GetbyId(edite.Id);
            if (foredite==null)
            {
                return operation.isfailed("هیچ رکوردی با مضمون مورد نظر یافت نشد");
            }

            if (_reposetory.Exists(x=>x.Title==foredite.Title && x.Id!=foredite.Id))
            {
                return operation.isfailed("هیچ رکوردی با مضمون مورد نظر یافت نشد");
            }
            var slug=edite.Slug.GenerateSlug();
            foredite.Edited(edite.Title2, edite.Discription, edite.picture,
                edite.Altpicture, edite.Title,slug);
            _reposetory.savechanges();
            return operation.secsseced();
        }

        public List<ViewModel> search(SearchModel search)
        {
            return _reposetory.SearchCategory(search); 
        }
    }
}
