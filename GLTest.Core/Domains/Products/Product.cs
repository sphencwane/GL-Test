using GLTest.Core.Domains.Categories;
using GLTest.Core.Domains.ProductCategories;

namespace GLTest.Core.Domains.Products
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public string ProductName { get; private set; }
        public ICollection<ProductCategory> ProductCategories { get; private set; } = new List<ProductCategory>();

        protected Product() { }

        protected Product Create(string name)
        {
            return new Product
            {
                ProductName = name
            };
        }

        public void SetCategory(Guid categoryId)
        {
            ProductCategories.Add(new ProductCategory { ProductId = ProductId, CategoryId = categoryId });
        }
    }
}
