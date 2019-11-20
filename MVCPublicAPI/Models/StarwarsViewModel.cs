using System.Collections.Generic;

namespace MVCPublicAPI.Models
{
    public class StarwarsViewModel
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string LinktoURL { get; set; }

        //public string PlanetNumber { get; set; }
        //public string Name { get; set; }
        public IList<Planet> Planets { get; set; }
        public List<Planet> Planet { get; set; }
        public string UserSelectedPlanet { get; set; }

    }

    public class Planet
    {
        public string Url { get; set; }
        public string Name { get; set; }
    }

}
