using ClothingStore.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepositoryInterface _productRepository;
        private readonly CategoryRepositoryInterface _categoryRepository;

        public ProductController(ProductRepositoryInterface productRepository, CategoryRepositoryInterface categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ViewBag.CurrentCategory = "Pants";
            return View(_productRepository.AllProducts);
        }
    }
}