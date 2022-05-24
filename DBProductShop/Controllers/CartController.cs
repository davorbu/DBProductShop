using Microsoft.AspNetCore.Mvc;

namespace DBProductShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add (string id)
        {
            ViewBag.ProductSlug = id;   
            return View();
        }
    }
}
