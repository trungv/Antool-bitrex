using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common;

using System.Net;

namespace BitrexApi
{
    public static class MarketSummariesAPIClientNew
    {
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response;
        //private static JObject json;

        public static float GetPriceCoinbyName(string name)
        {
            //client = new HttpClient();
            client.BaseAddress = new Uri(BitrexUrl.getmarketsummariesByName(name));

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            response = client.GetAsync(BitrexUrl.getmarketsummariesByName(name)).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                JObject json = response.Content.ReadAsAsync<JObject>().Result;
                return float.Parse(json["result"][0]["Last"].ToString());
            }
            else
            {
                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                return -1;
            }
        }

        public static async Task<float> GetProductAsync(string name)
        {
            JObject x = null;

            client.BaseAddress = new Uri(BitrexUrl.getmarketsummariesByName(name));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(BitrexUrl.getmarketsummariesByName(name));
            if (response.IsSuccessStatusCode)
            {
                dynamic json = await response.Content.ReadAsAsync<dynamic>().Result;
                x = json;
            }
            return float.Parse(x["result"][0]["Last"].ToString());
        }
    }
}
