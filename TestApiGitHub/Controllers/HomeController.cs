using Microsoft.AspNetCore.Mvc;

namespace TestApiGitHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
