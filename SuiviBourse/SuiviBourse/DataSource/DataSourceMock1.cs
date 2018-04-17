//using Newtonsoft.Json;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SuiviBourse.DataSource
{
    class DataSourceMock1
    {



        public static List<Alerte> GetAlerte()
        {
            List<Alerte> listAlert = new List<Alerte>()
            {
                new Alerte ("FR0000120073", "AIR LIQUIDE"),
                new Alerte ("FR0000120073", "AIR LIQUIDE"),
                  new Alerte ("FR0000120073", "AIR LIQUIDE"),
                new Alerte ("FR0000120073", "AIR LIQUIDE")

            };
            return listAlert;
        }
    }
}
