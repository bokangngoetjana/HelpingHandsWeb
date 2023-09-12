using Microsoft.AspNetCore.Mvc;
using HelpingHands.Data;

namespace HelpingHands.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cities = _context.City.ToList();
            return View(cities);
        }
    }
}
