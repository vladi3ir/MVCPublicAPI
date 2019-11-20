using MVCPublicAPI.Controllers;
using MVCPublicAPI.Models;
using System.Collections.Generic;

namespace MVCPublicAPI.DAL
{
    public class StarshipDALModel
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public List<Starship> Starship { get; set; }
        public IEnumerable<PlanetResponse> Results { get; set; }



    }
}