using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        // GET: HomeController
        public IActionResult Index()
        {
            return View();
        }

    }
}
