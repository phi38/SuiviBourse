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



        public static List<Cotation> GetBourseActionList()
        {
            List<Cotation> listAlert = new List<Cotation>()
            {
                new Cotation ("FR0000120073", "AIR LIQUIDE"),
                new Cotation ("FR0010241638", "Mercialys"),
                new Cotation ("FR0000060402", "Albioma"),
                new Cotation ("FR0011726835", "GTT")

            };
            return listAlert;
        }

        public static List<Alerte> GetAlerteList()
        {
            List<Alerte> listAlert = new List<Alerte>()
            {
                new Alerte ("FR0000120073", "AIR LIQUIDE"),
                new Alerte ("FR0010241638", "Mercialys"),
                new Alerte ("FR0000060402", "Albioma"),
                new Alerte ("FR0011726835", "GTT")

            };
            return listAlert;
        }
    }
}
