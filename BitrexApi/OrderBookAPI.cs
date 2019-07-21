using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BitrexApi.Entities;

namespace BitrexApi
{
    public static class OrderBookAPI
    {
        public static JObject getOrderBook(string coinName)
        {
            string url = Common.BitrexUrl.getorderbook(coinName);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
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

        public static OrderBook getInfoOrderBook(string coinName)
        {
            OrderBook order = new OrderBook();
            JObject json = getOrderBook(coinName);

            float totalBuy = 0;
            float totalSell = 0;
            float percentBuy = 0;
            float percentSell = 0;

            if(json != null)
            {
                for(int i = 0; i<json["result"]["buy"].Count(); i++)
                {
                    totalBuy = totalBuy + float.Parse(json["result"]["buy"][i]["Quantity"].ToString());
                    totalSell = totalSell + float.Parse(json["result"]["sell"][i]["Quantity"].ToString());
                }

                percentBuy = totalBuy / (totalBuy + totalSell);
                percentSell = totalSell / (totalBuy + totalSell);

                order.TotalBuy = totalBuy;
                order.TotalSell = totalSell;
                order.PercentBuy = percentBuy;
                order.PercentSell = percentSell;

                return order;
            }
            return null;
        }
    }
}
