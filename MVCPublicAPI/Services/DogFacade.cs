using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCPublicAPI.Models;

namespace MVCPublicAPI.Services
{
    public class DogFacade :IDogFacade
    {
        private readonly IDogService _dogService;

        public DogFacade(IDogService dogService)
        {
            _dogService = dogService;
        }

        public async Task<DogViewModel> GetDogViewModel()
        {
            var result = await _dogService.GetDog();
            var viewModel = new DogViewModel();

            //what am i doing to map it

            viewModel.ImageURL = result.Message;
            return viewModel;


        }
    }
}
