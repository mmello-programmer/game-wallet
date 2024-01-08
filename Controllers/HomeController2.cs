using Microsoft.AspNetCore.Mvc;

namespace GameWallet.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
