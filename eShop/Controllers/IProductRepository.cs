using System.Collections.Generic;
using eShop.Models;

namespace eShop.Controllers
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProduct { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetProductById(int pieId);
    }
}