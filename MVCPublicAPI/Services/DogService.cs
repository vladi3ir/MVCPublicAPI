using MVCPublicAPI.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public class DogService : IDogService
    {
        public async Task<DogResponse> GetDog()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://dog.ceo") })
            {
                var result = await httpClient.GetStringAsync("/api/breeds/image/random");
                return JsonConvert.DeserializeObject<DogResponse>(result);
            }

        }
    }
}
