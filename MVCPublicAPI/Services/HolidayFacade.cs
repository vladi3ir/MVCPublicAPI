using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCPublicAPI.Models;

namespace MVCPublicAPI.Services
{
    public class HolidayFacade : IHolidayFacade
    {
        private readonly IHolidayService _holidayService;

        public HolidayFacade(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        public async Task<HolidayViewModel> GetHolidayViewModel(string date)
        {
            var result = await _holidayService.GetHoliday(date);
            var viewModel = new HolidayViewModel();

            //what am i doing to map it

            viewModel.Date = result.date;
            viewModel.Holiday = result.holiday;
            return viewModel;


        }
    }
}
