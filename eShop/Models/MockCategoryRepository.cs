using System.Collections.Generic;
using eShop.Controllers;

namespace eShop.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Vegetable", Description="All-fruity pies"},
                new Category{CategoryId=2, CategoryName="Fruits", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Pies", Description="Get in the mood for a seasonal pie"}
            };
    }
}