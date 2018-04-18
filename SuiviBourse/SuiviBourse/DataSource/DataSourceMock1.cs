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



        public static List<BourseAction> GetBourseActionList()
        {
            List<BourseAction> listAlert = new List<BourseAction>()
            {
                new BourseAction ("FR0000120073", "AIR LIQUIDE"),
                new BourseAction ("FR0010241638", "Mercialys"),
                new BourseAction ("FR0000060402", "Albioma"),
                new BourseAction ("FR0011726835", "GTT")

            };
            return listAlert;
        }
    }
}
