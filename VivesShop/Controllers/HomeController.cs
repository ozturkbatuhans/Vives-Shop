using Microsoft.AspNetCore.Mvc;
using VivesShop.Data;
using VivesShop.Models;

namespace VivesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly VivesShopContext _context;

        public HomeController(VivesShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.ShopItems.ToList();
            return View(products);
        }
    }
}

