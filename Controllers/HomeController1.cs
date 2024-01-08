using Microsoft.AspNetCore.Mvc;

namespace GameWallet.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
