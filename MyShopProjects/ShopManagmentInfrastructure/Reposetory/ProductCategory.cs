using System.Linq.Expressions;
using ShopManagementApplactionContract.ProductCategory;
using ShopManagementDomin.ProductCategory;
using ShopManagmentInfrastructure.PrpductCategoryContext;

namespace ShopManagmentInfrastructure.Reposetory
{
    public class ProductCategoryReposetory : IProductCategoryReposetory
    {
        private readonly ShopContext _context;

        public ProductCategoryReposetory(ShopContext context)
        {
            _context = context;
        }

        public void Create(ProductCategoryAgg entity)
        {
            _context.Productcategores.Add(entity);

        }

        public ProductCategoryAgg GetbyId(long id)
        {
            return _context.Productcategores.FirstOrDefault(x => x.Id == id);

        }

        public List<ProductCategoryAgg> MyCategory()
        {

            return _context.Productcategores.ToList();
        }

        public bool Exists(Expression<Func<ProductCategoryAgg, bool>> expression)
        {
            return _context.Productcategores.Any(expression);
        }

        public void savechanges()
        {
            _context.SaveChanges();
        }

        public Edite GetDetails(long id)
        {
            var product = _context.Productcategores.FirstOrDefault(x => x.Id == id);
            return new Edite()
            {
                Id = product.Id,
                Title = product.Title,
                Title2 = product.Title2,
                Slug = product.Slug,
                Altpicture = product.Altpicture,
                picture = product.picture,
                Discription = product.Discription,

            };
        }

        public List<ViewModel> SearchCategory(SearchModel search)
        {
            var t = _context.Productcategores.ToList();
            var count = (from o in _context.Productcategores select _context.Productcategores).Count();
            var qurey = _context.Productcategores.Select(x => new ViewModel()
            {
                Id = x.Id,
                picture = x.picture,
                CreationDate = x.CreationDateTime.ToString(),
                categoryname = x.Title,
                categoryname2 = x.Title2,
                Productcount =count,
            });
            if (!string.IsNullOrWhiteSpace(search.Name))
            {
               qurey = qurey.Where(x =>
                    x.categoryname.Contains(search.Name) || x.categoryname2.Contains(search.Name));
            }

            return qurey.OrderByDescending(x=>x.Id).ToList();
        }
    }
}
