using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoinMarketCapApi
{
    public static class Ticker
    {
        public static string GetPriceBTC()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Common.CoinMarketCapUrl.BitcoinInfo);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(Common.CoinMarketCapUrl.BitcoinInfo).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                JArray json = response.Content.ReadAsAsync<JArray>().Result;
                return json[0]["price_usd"].ToString();
            }
            else
            {
                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                return error;
            }
        }
    }
}
