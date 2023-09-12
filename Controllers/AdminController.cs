using Microsoft.AspNetCore.Mvc;

namespace HelpingHands.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
