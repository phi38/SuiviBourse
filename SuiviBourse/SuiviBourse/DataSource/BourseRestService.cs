using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuiviBourse.Model;

namespace SuiviBourse.DataSource
{
    class BourseRestService : IBourseRestService
    {
        private const string URI_ALERT = "https://lesechos-bourse-fo-cdn.wlb.aw.atos.net/streaming/cours/blocs/getHeaderFiche?place=XPAR&codif=ISIN&code=";

        HttpClient httpClientAlerte;

        public BourseRestService()
        {
            httpClientAlerte = new HttpClient();
            httpClientAlerte.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<BourseAction>> GetCoursDataAsync(List<BourseAction> list)
        {
            List < BourseAction > listres = new List<BourseAction>();
            foreach (BourseAction action in list)
            {
                BourseAction actionRes  = await GetCoursDataAsync(action);
                listres.Add(actionRes);
            }
            return listres;
        }

        public async Task<BourseAction> GetCoursDataAsync(BourseAction actionBourse)
        { 

            RootObject rootObject =null;

            var uri = new Uri(URI_ALERT+actionBourse.Code);

            try
            {
                var response = await httpClientAlerte.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    rootObject = JsonConvert.DeserializeObject<RootObject>(content);
                    actionBourse.Cours = Tools.Utils.ExtractFloat(rootObject.HeaderFiche.ValorisationHeaderFiche, '\n'); 
                    actionBourse.Variation = Tools.Utils.ExtractFloat(rootObject.HeaderFiche.VariationHeaderFiche, '>', '%');
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return actionBourse;
        }





    }
}
