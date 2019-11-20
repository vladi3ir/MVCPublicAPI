using MVCPublicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCPublicAPI.Controllers
{
    public interface IStarwarsService
    {
        Task<StarwarsResponse> GetPlanet(string planet);
        Task<StarwarsResponse> GetPlanets();


    }
}