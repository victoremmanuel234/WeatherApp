using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [Route("/")]
        // GET: HomeController
        public IActionResult Index()
        {
            ViewBag.configuration = _configuration;
            ViewBag.configValue = _configuration.GetValue<string>("myvalue");
            ViewBag.loggingValue = _configuration.GetValue<string>("Logging:LogLevel:Default", "Mannem");
            return View();
        }

    }
}
