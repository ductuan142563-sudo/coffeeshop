using coffeeshop.Models;
using coffeeshop.Models.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coffeeshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public IActionResult Index()
        {
            var trendingProducts = productRepository.GetTrendingProducts();
            return View(trendingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}