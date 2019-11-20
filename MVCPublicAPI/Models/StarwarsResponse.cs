using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.Models
{
    public class StarwarsResponse
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string LinktoURL { get; set; }
        //public string PlanetNumber { get; set; }
        //public IEnumerable<Planets> Planets { get; set; }

        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public IEnumerable<PlanetResponse> Results { get; set; }

    }


    public class PlanetResponse
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public string[] Residents { get; set; }
        public string[] films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }

}
