using Microsoft.AspNetCore.Mvc;
using MVCPublicAPI.Models;
using MVCPublicAPI.Services;
using System.Threading.Tasks;

namespace MVCPublicAPI.Controllers
{
    public class StarwarsController : Controller
    {
        //private IStarwarsService _starwarsService;
        private IPlanetService _planetService;
        private IStarwarsFacade _starwarsFacade;

        public StarwarsController(IStarwarsFacade starwarsFacade, IPlanetService planetService)
        {
            _starwarsFacade = starwarsFacade;
            _planetService = planetService;


        }


        public async Task<IActionResult> StarwarsView()
        {
            var result = await _starwarsFacade.GetAllPlanets();
            return View(result);
        }


        public IActionResult UserPlanetsView(StarwarsViewModel model)
        {

            var result = _planetService.AddNewPlanet(model);
            return View(result);
        }


        public async Task<IActionResult> Index()
        {
            var starships = await _starwarsFacade.GetAllStarships();

            return View(starships);
        }



    }
}