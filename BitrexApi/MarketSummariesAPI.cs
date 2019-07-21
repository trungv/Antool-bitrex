using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Common;
using BitrexApi.Entities;
using System.Threading;

namespace BitrexApi
{
    public static class MarketSummariesAPI
    {
        #region TheOldVersion
        //private static HttpClient client = new HttpClient();
        //private static HttpResponseMessage response;
        //private static JObject json;
        public static JObject Getmarketsummaries()
        {
            Thread.Sleep(5000);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BitrexUrl.getmarketsummaries);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummaries).Result;  // Blocking call!
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
        //public static float GetPriceCoinbyName(string name)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(BitrexUrl.getmarketsummariesByName(name));

        //        // Add an Accept header for JSON format.
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // List data response.
        //        using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummariesByName(name)).Result)  // Blocking call!
        //        {
        //            if (response.IsSuccessStatusCode)
        //            {
        //                // Parse the response body. Blocking!
        //                JObject json = response.Content.ReadAsAsync<JObject>().Result;
        //                return float.Parse(json["result"][0]["Last"].ToString());
        //            }
        //            else
        //            {
        //                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
        //                return -1;
        //            }
        //        }
        //    }
        //}
        //public static List<float> GetListPriceCoin()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(BitrexUrl.getmarketsummaries);

        //        // Add an Accept header for JSON format.
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // List data response.
        //        using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummaries).Result) // Blocking call!
        //        {
        //            List<float> listResult = new List<float>();
        //            if (response.IsSuccessStatusCode)
        //            {
        //                // Parse the response body. Blocking!
        //                JObject json = response.Content.ReadAsAsync<JObject>().Result;
        //                int i = 1;
        //                for (; i <= json["result"].Count(); i++)
        //                {
        //                    if (json["result"][i - 1]["MarketName"].ToString().Substring(0, 3) == "ETH")
        //                    {
        //                        break;
        //                    }
        //                    listResult.Add(float.Parse(json["result"][i - 1]["Last"].ToString()));
        //                }
        //                return listResult;
        //            }
        //            else
        //            {
        //                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
        //                return null;
        //            }
        //        }
        //    }
        //}
        //static List<string> listCoin = new List<string>();
        //public static List<string> GetListNameCoin()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {

        //        client.BaseAddress = new Uri(BitrexUrl.getmarketsummaries);

        //        // Add an Accept header for JSON format.
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // List data response.
        //        using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummaries).Result) // Blocking call!
        //        {
        //            if (response.IsSuccessStatusCode)
        //            {
        //                // Parse the response body. Blocking!
        //                JObject json = response.Content.ReadAsAsync<JObject>().Result;
        //                int i = 1;
        //                for (; i <= json["result"].Count(); i++)
        //                {
        //                    if (json["result"][i - 1]["MarketName"].ToString().Substring(0, 3) == "ETH")
        //                    {
        //                        break;
        //                    }
        //                    listCoin.Add(json["result"][i - 1]["MarketName"].ToString());

        //                }
        //                return listCoin;
        //            }
        //            else
        //            {
        //                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
        //                return null;
        //            }
        //        }
        //    }
        //}
        #endregion

        public static List<MarketSummary> GetListSummary(string selectMode)//Select mode: "ALL" or only "BTC" market
        {
            Thread.Sleep(5000);
            List<MarketSummary> listSummarry = new List<MarketSummary>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BitrexUrl.getmarketsummaries);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummaries).Result) // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        int coinCount = json["result"].Count();
                        for (int i = 1; i <= coinCount; i++)
                        {
                            if (selectMode == "BTC")
                            {
                                if (json["result"][i - 1]["MarketName"].ToString().Substring(0, 3) == "ETH")
                                {
                                    break;
                                }
                            }

                            listSummarry.Add(new MarketSummary
                            {
                                NameCoin = json["result"][i - 1]["MarketName"].ToString(),
                                Last = float.Parse(json["result"][i - 1]["Last"].ToString())
                            });

                        }
                        return listSummarry;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return null;
                    }
                }
            }
        }

        public static MarketSummary GetSummaryByName(string name)
        {
            Thread.Sleep(5000);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BitrexUrl.getmarketsummariesByName(name));

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(BitrexUrl.getmarketsummariesByName(name)).Result)  // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        MarketSummary coin = new MarketSummary
                        {
                            NameCoin = json["result"][0]["MarketName"].ToString(),
                            Last = float.Parse(json["result"][0]["Last"].ToString())
                        };
                        return coin;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return null;
                    }
                }
            }
        }
        //NOTE: Hàm này nữa phát triển để Filter theo danh sách coin.
        //public static MarketSummary GetSummaryByName(string nameCoin)
        //{
        //    List<MarketSummary> list = GetListSummary("ALL");
        //    MarketSummary x = list.FirstOrDefault(p => p.NameCoin == nameCoin);
        //    return x;
        //}

        public static string AlertDumpOrPump(float percentDumpAlert, float valueFirst, float valueLast, ref float realPercentChange)
        {
            realPercentChange = (valueLast - valueFirst) / valueFirst;
            if (Math.Abs(realPercentChange) >= percentDumpAlert)
            {
                if (realPercentChange > 0)
                {
                    return "PUMP";
                }
                else
                {
                    return "DUMP";
                }
            }
            return "NONE";
        }
    }
}
