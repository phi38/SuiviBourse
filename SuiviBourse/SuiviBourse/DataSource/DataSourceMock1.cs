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

        static public async Task<RootObject> GetTasksAsync()
        {
            HttpClient client;
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            RootObject rootObject = new RootObject();

          
            var uri = new Uri(string.Format("https://lesechos-bourse-fo-cdn.wlb.aw.atos.net/streaming/cours/blocs/getHeaderFiche?code=FR0000120073&place=XPAR&codif=ISIN", string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    rootObject = JsonConvert.DeserializeObject<RootObject>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return rootObject;
        }


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

        //public static async Task GetAllNewsAsync(Action<IEnumerable<Car>> action)
        public static async Task GetAllNewsAsync()
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://lesechos-bourse-fo-cdn.wlb.aw.atos.net/streaming/cours/blocs/getHeaderFiche?code=FR0000120073&place=XPAR&codif=ISIN");
     
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               // Console.WriteLine("RESUL content= " + response.Content.ReadAsStringAsync() );
                // JObject jResult = Newtonsoft.Json.Linq.JObject.Parse(await response.Content.ReadAsStringAsync());
                //  string str = jResult.GetValue("valorisation").ToString();
                //Console.WriteLine("RESUL = " + str);
                var list = JsonConvert.DeserializeObject<IEnumerable<HeaderFiche>>(await response.Content.ReadAsStringAsync());
                Console.WriteLine("RESUL list = " +list.ToString());
                //action(list);
            }
        }
    }
}
