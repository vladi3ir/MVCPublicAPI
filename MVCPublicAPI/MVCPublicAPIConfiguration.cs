using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MVCPublicAPI
{
    public class MVCPublicAPIConfiguration
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public string ConnectionString { get; set; }
    }
}