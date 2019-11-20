using MVCPublicAPI.DAL;
using MVCPublicAPI.Models;
using System.Collections.Generic;

namespace MVCPublicAPI.Services
{

    public interface IPlanetService
    {
       
        StarwarsViewModel AddNewPlanet(StarwarsViewModel model);

    }
    public class PlanetService : IPlanetService
    {
        private readonly IStarwarsStore _starwarsStore;
        public PlanetService(IStarwarsStore starwarsStore)
        {
            _starwarsStore = starwarsStore;
        }

        //private readonly IStarwarsService _starwarsService;


        //public StarwarsFacade(IStarwarsService starwarsService)
        //{
        //    _starwarsService = starwarsService;
        //}

        //public async Task<StarwarsResponse> GetPlanetViewModel(string planet)
        //{
        //    var result = await _starwarsService.GetPlanet(planet);
        //    var viewModel = new StarwarsResponse();
        //    //what am i doing to map it
        //    viewModel.Results = result.Results;
        //    return viewModel;
        //}

        //public async Task<StarwarsViewModel> GetAllPlanets()
        //{
        //    var result = await _starwarsService.GetPlanets();
        //    var planetsViewModel = new StarwarsViewModel();
        //    planetsViewModel.Planets = new List<Planet>();
        //    //what am i doing to map it
        //    foreach (var item in result.Results)
        //    {
        //        var planet = new Planet();
        //        planet.Name = item.Name;
        //        planet.Url = item.Url;
        //        planetsViewModel.Planets.Add(planet);
        //    }
        //    return planetsViewModel;
        //}

        public StarwarsViewModel AddNewPlanet(StarwarsViewModel model)
        {


            var dalModel = new StarwarsDALModel();
            dalModel.LinkToUrl = model.UserSelectedPlanet;
            _starwarsStore.InsertNewPlanet(dalModel);

            //MAPPING
            var dalProducts = _starwarsStore.SelectAllPlanets();
            var planets = new List<Planet>();

            foreach (var dalProduct in dalProducts)
            {
                var product = new Planet();
                product.Name = dalProduct.LinkToUrl;
                planets.Add(product);
            }

            var StarwarsViewModel = new StarwarsViewModel();
            StarwarsViewModel.Planet = planets;

            return StarwarsViewModel;
        }


    }
}



