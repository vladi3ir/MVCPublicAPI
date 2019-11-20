using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPublicAPI.DAL
{
    public interface IStarwarsStore
    {
        bool InsertNewPlanet(StarwarsDALModel dalModel);
        IEnumerable<StarwarsDALModel> SelectAllPlanets();
    }


    public class StarwarsStore : IStarwarsStore
    {
        private readonly Database _config;

        public StarwarsStore(MVCPublicAPIConfiguration config)
        {
            _config = config.Database;
        }


        public IEnumerable<StarwarsDALModel> SelectAllPlanets()
        {
            var sql = @"SELECT * FROM PlanetFanDb";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Query<StarwarsDALModel>(sql);

                return result;
            }
        }

        public bool InsertNewPlanet(StarwarsDALModel dalModel)
        {
           

            //ADD PRODUCT
            var sql = $@"Insert INTO PlanetFanDb (LinkToUrl) Values (@{nameof(dalModel.LinkToUrl)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);
                return true;
            }

        }


        public bool InsertNewFan(StarwarsDALModel dalModel)
        {
            //ADD PRODUCT
            var sql = $@"Insert INTO PlanetFanDb (FanID) Values (@{nameof(dalModel.FanID)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);

                return true;
            }

        }
    }

}

