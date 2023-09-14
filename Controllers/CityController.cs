using Microsoft.AspNetCore.Mvc;
using HelpingHands.Data;
using HelpingHands.Repositories;

namespace HelpingHands.Controllers
{
    public class CityController : Controller
    {
        private readonly CityRepo _city;
        public CityController(CityRepo city)
        {
            _city = city;
        }
        public async Task<IActionResult> Index()
        {
            var cities = await _city.GetAllCitiesAsync();
            return View(cities);
        }
    }
}
