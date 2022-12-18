using Golbal;

namespace ShopManagementDomin.ProductCategory
{
    public class ProductCategoryAgg : DominG

    {
        public string Title2 { get; private set; }
        public string Discription { get; private set; }
        public string picture { get; private set; }
        public string Altpicture { get; private set; }
        public string Title { get; private set; }
        public string Slug { get; private set; }

        public ProductCategoryAgg(string title2, string discription, string picture, string altpicture, string title, string slug)
        {
            this.Title2 = title2;
            Discription = discription;
            this.picture = picture;
            Altpicture = altpicture;
            Title = title;
            Slug = slug;
        }
        public void Edited(string categoryname, string discription, string picture, string altpicture, string title, string slug)
        {
            this.Title2 = categoryname;
            Discription = discription;
            this.picture = picture;
            Altpicture = altpicture;
            Title = title;
            Slug = slug;
        }
    }
}
