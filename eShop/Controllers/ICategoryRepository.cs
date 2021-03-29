using System.Collections.Generic;
using eShop.Models;

namespace eShop.Controllers
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}