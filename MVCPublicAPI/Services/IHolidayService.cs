using MVCPublicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public interface IHolidayService
    {
        Task<HolidayResponse> GetHoliday(string date);

    }
}
