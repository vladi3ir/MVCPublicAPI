using MVCPublicAPI.DAL;
using MVCPublicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCPublicAPI.Controllers
{
    public interface IStarwarsFacade
    {
        Task<StarwarsResponse> GetPlanetViewModel(string planet);
        Task<StarwarsViewModel> GetAllPlanets();

        Task<StarshipDALModel> GetAllStarships();



    }
}