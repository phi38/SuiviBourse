﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public async Task<List<Cotation>> GetCoursDataAsync(List<Cotation> list)
        {
            List < Cotation > listres = new List<Cotation>();
            foreach (Cotation action in list)
            {
                Cotation actionRes  = await GetCoursDataAsync(action);
                listres.Add(actionRes);
            }
            return listres;
        }


        public async Task<List<Cotation>> GetCoursDataAsync(IEnumerator<Cotation> it)
        {
            List<Cotation> listres = new List<Cotation>();
            while (it.MoveNext())
            {
                Cotation actionRes = await GetCoursDataAsync(it.Current);
                listres.Add(actionRes);
            }
            return listres;
        }

        
        public async Task<Cotation> GetCoursDataAsync(Cotation actionBourse)
        { 

            var uri = new Uri(URI_ALERT+actionBourse.Code);

            try
            {
                var response = await httpClientAlerte.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(content);
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
