using MVCPublicAPI.Controllers;
using MVCPublicAPI.DAL;
using MVCPublicAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public class StarwarsFacade : IStarwarsFacade
    {
        private readonly IStarshipStore _starshipStore;


        public async Task<StarshipDALModel> GetAllStarships()
        {
            //var starships = (await _starshipStore.GetAllStarships()).Select(StarshipDALModel => new Starship { Model = StarshipDALModel.Model, Name = StarshipDALModel.Name });

            //was trying to get this to work based on Robs Feedback
            var result = await _starshipStore.GetAllStarships();
            var starshipViewModel = new StarshipDALModel();
            starshipViewModel.Starship = new List<Starship>();
            //what am i doing to map it
            foreach (var item in result.Results)
            {
                var starship = new Starship();
                starship.Name = item.Name;
                starshipViewModel.Starship.Add(starship);
            }
            return starshipViewModel;
        }




        private readonly IStarwarsService _starwarsService;


        public StarwarsFacade(IStarwarsService starwarsService, IStarshipStore starshipStore)
        {
            _starwarsService = starwarsService;
            _starshipStore = starshipStore;
        }

        public async Task<StarwarsResponse> GetPlanetViewModel(string planet)
        {
            var result = await _starwarsService.GetPlanet(planet);
            var viewModel = new StarwarsResponse();
            //what am i doing to map it
            viewModel.Results = result.Results;
            return viewModel;
        }

        public async Task<StarwarsViewModel> GetAllPlanets()
        {
            var result = await _starwarsService.GetPlanets();
            var planetsViewModel = new StarwarsViewModel();
            planetsViewModel.Planets = new List<Planet>();
            //what am i doing to map it
            foreach (var item in result.Results)
            {
                var planet = new Planet();
                planet.Name = item.Name;
                planet.Url = item.Url;
                planetsViewModel.Planets.Add(planet);
            }
            return planetsViewModel;
        }


        //public StarwarsViewModel AddNewPlanet(StarwarsViewModel model)
        //{


        //    var dalModel = new StarwarsDALModel();
        //    dalModel.LinkToURL = model.UserSelectedPlanet;
        //    _starwarsStore.InsertNewPlanet(dalModel);

        //    //MAPPING
        //    var dalProducts = _starwarsStore.SelectAllPlanets();
        //    var planets = new List<Planet>();

        //    foreach (var dalProduct in dalProducts)
        //    {
        //        var product = new Planet();
        //        product.Name = dalProduct.LinkToURL;
        //        planets.Add(product);
        //    }

        //    var StarwarsViewModel = new StarwarsViewModel();
        //    StarwarsViewModel.Planet = planets;

        //    return StarwarsViewModel;
        //}


    }
}
