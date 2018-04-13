using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.DataSource
{
    class DataSourceMock1
    {
       public static List<Alerte> GetAlerte()
        {
            List<Alerte> listAlert = new List<Alerte>()
            {
                new Alerte ("FR0000120073", "AIR LIQUIDE")
            };
            return listAlert;
        }
    }
}
