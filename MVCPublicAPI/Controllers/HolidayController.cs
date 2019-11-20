using Microsoft.AspNetCore.Mvc;
using MVCPublicAPI.Models;
using MVCPublicAPI.Services;
using System.Threading.Tasks;

namespace MVCPublicAPI.Controllers
{
    public class HolidayController : Controller
    {
        private IHolidayService _holidayService;
        private IHolidayFacade _holidayFacade;

        public HolidayController(IHolidayFacade holidayFacade)
        {
            _holidayFacade = holidayFacade;
        }

        public IActionResult HolidayFormView()
        {
            return View();
        }


        public async Task<IActionResult> Holiday(HolidayViewModel model)
        {
            // var viewModel = new HolidayViewModel();
            var result = await _holidayFacade.GetHolidayViewModel(model.Date);
            return View(result);
        }
    }
}