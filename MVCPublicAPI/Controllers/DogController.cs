using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCPublicAPI.Models;
using MVCPublicAPI.Services;

namespace MVCPublicAPI.Controllers
{
    public class DogController : Controller
    {
        private IDogService _dogService;
        private IDogFacade _dogFacade;

        public DogController(IDogFacade dogFacade)
        {
            _dogFacade = dogFacade;
        }

        public async Task<IActionResult> Dog()
        {
            var viewModel = new DogViewModel();
            var result = await _dogFacade.GetDogViewModel();
            return View(result);
        }
    }
}