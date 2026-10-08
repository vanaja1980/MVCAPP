using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Repositories;

namespace MyMVCApp.Controllers
{
    /// <summary>
    /// Displays the product catalog.
    /// </summary>
    public class ProductController : Controller
    {
        /// <summary>
        /// Displays all products.
        /// </summary>
        /// <returns>The product catalog view.</returns>
        public IActionResult Index()
        {
            return View(ProductRepository.GetProducts());
        }
    }
}
