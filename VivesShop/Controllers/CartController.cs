using Microsoft.AspNetCore.Mvc;
using VivesShop.Data;
using VivesShop.Models;

namespace VivesShop.Controllers
{
    public class CartController : Controller
    {
        private readonly VivesShopContext _context;

        public CartController(VivesShopContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            var item = _context.ShopItems.FirstOrDefault(p => p.Id == id);
            if (item == null)
                return NotFound();

            var cart = HttpContext.Session.GetObjectFromJson<List<ShopItem>>("Cart") ?? new List<ShopItem>();
            cart.Add(item);
            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<ShopItem>>("Cart") ?? new List<ShopItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<ShopItem>>("Cart") ?? new List<ShopItem>();
            var itemToRemove = cart.FirstOrDefault(i => i.Id == id);
            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ConfirmOrder()
        {
            
            HttpContext.Session.Remove("Cart"); // Clear cart after checkout
            return View();
        }

    }
}

