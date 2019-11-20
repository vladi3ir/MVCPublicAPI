using MVCPublicAPI.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public class HolidayService : IHolidayService
    {
        

        public async Task<HolidayResponse> GetHoliday(string date)
        {
            var covertedDate = DateTime.Parse(date).ToString("yyyy-MM-dd");
            using (var httpClient = new HttpClient { BaseAddress = new Uri(@"https://datazen.katren.ru") })
            {
                var result = await httpClient.GetStringAsync($"/calendar/day/{covertedDate}/");
                return JsonConvert.DeserializeObject<HolidayResponse>(result);
            }
        }

  
    }
}
