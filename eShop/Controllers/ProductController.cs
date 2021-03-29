using System.Collections.Generic;
using eShop.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var productsListViewModel = new ProductsListViewModel
            {
                Products = _productRepository.AllProduct,
                Categories = _categoryRepository.AllCategories
            };
            return View(productsListViewModel);
        }
    }
}