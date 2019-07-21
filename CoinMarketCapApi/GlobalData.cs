using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CoinMarketCapApi
{
    public static class GlobalData
    {
        public static JObject GetGlobalData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(CoinMarketCapUrl.globalData);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(CoinMarketCapUrl.globalData).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                JObject json = response.Content.ReadAsAsync<JObject>().Result;
                return json;
            }
            else
            {
                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                return null;
            }
        }
    }
}
