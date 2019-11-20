using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCPublicAPI.DAL
{
    public class StarshipStore : IStarshipStore
    {
        private string baseUrl = "https://swapi.co";

        public async Task<StarshipDALModel> GetAllStarships()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) })
            {
                var result = await httpClient.GetStringAsync($"/api/starships");
                return JsonConvert.DeserializeObject<StarshipDALModel>(result);
            }

        }

      
    }
}