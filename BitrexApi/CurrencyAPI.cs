using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitrexApi.Entities;
using System.Net.Http;
using Common;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace BitrexApi
{
    public static class CurrencyAPI
    {
        public static List<Currency> GetListSummary()//Select mode: "ALL" or only "BTC" market
        {
            List<Currency> listCurrency = new List<Currency>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BitrexUrl.getcurrencies);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getcurrencies).Result) // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        int coinCount = json["result"].Count();
                        for (int i = 1; i <= coinCount; i++)
                        {
                            listCurrency.Add(new Currency
                            {
                                CurrencyName = json["result"][i - 1]["Currency"].ToString(),
                                CurrencyLong = json["result"][i - 1]["CurrencyLong"].ToString(),
                                MinConfirmation = int.Parse(json["result"][i - 1]["MinConfirmation"].ToString()),
                                TxFee = float.Parse(json["result"][i - 1]["TxFee"].ToString()),
                                IsActive = bool.Parse(json["result"][i - 1]["IsActive"].ToString()),
                                CoinType = json["result"][i - 1]["CoinType"].ToString(),
                                BaseAddress = json["result"][i - 1]["BaseAddress"].ToString(),
                                Notice = json["result"][i - 1]["Notice"].ToString()
                            });

                        }
                        return listCurrency;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return null;
                    }
                }
            }
        }
    }
}
