﻿using MVCPublicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.Services
{
    public interface IHolidayFacade
    {
        Task<HolidayViewModel> GetHolidayViewModel(string date);
    }
}
