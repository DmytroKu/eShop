using System.Collections.Generic;

namespace eShop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProduct { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetProductById(int pieId);
    }
}