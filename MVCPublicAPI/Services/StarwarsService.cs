using MVCPublicAPI.Controllers;
using MVCPublicAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public class StarwarsService : IStarwarsService
    {
        private const string _baseUrl = "https://swapi.co";

  

        public async Task<StarwarsResponse> GetPlanet(string planet)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) })
            {
                var result = await httpClient.GetStringAsync($"/api/planets/{planet}/");
                return JsonConvert.DeserializeObject<StarwarsResponse>(result);
            }
        }

        public async Task<StarwarsResponse> GetPlanets()
        {

            using (var httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) })
            {
                var result = await httpClient.GetStringAsync($"/api/planets/");
                return JsonConvert.DeserializeObject<StarwarsResponse>(result);
            }

        }



        
    }
}
