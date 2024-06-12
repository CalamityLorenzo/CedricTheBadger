using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using xpclSampleMvc.Models;

namespace xpclSampleMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyFingers _fingers;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IOptions<MyFingers> fingers)
        {
            _fingers = fingers.Value;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_fingers);
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
