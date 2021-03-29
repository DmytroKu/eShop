using System.Collections.Generic;
using System.Linq;
using eShop.Controllers;

namespace eShop.Models
{
    public class MockProductRepository:IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Category> Categories => _categoryRepository.AllCategories;
        public IEnumerable<Product> AllProduct =>
            new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Potato",
                    Price = 8.75M,
                    Description = "A raw potato is 79% water, 17% carbohydrates " +
                                  "(88% is starch), 2% protein, and contains negligible fat",
                    ImageUrl = "https://pngicon.ru/file/uploads/kartofel.png",
                    Category = Categories.ToList()[0],
                    CategoryId =Categories.ToList()[0].CategoryId
                },
                new Product
                {
                ProductId = 2,
                Name = "Tomato",
                Price = 19.5M,
                Description = "A ripe tomato fruit contains 93-95% water and 5-7.5% dry matter",
                ImageUrl = "https://pngicon.ru/file/uploads/pomidory-png.png",
                Category = Categories.ToList()[0],
                CategoryId =Categories.ToList()[0].CategoryId
                }
            };
        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProduct.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}