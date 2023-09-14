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
        public IActionResult Index()
        {
            var cities = _city.GetAllCitiesAsync();
            return View(cities);
        }
    }
}
