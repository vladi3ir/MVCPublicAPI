using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.DAL
{
    public interface IStarshipStore
    {

        Task<StarshipDALModel> GetAllStarships();
    }
}
