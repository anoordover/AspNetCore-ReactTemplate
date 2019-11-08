using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreReact.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}