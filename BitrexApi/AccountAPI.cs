using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitrexApi.Entities;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace BitrexApi
{
    public static class AccountAPI
    {
        static string APIKey = "06f428312531448eabbf736988dab272";
        static string APISecret = "d21c093ab59e4ebd99165a4e5f012c05";
        public static List<CurrencyBalance> GetAccountCurrencies()
        {
            if (APIKey == null || APISecret == null) return new List<CurrencyBalance>();
            var nonce = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP, need to integrate it
            var encoding = Encoding.UTF8;
            var urlForAuth = @"https://bittrex.com/api/v1.1/account/getbalances?apikey=" + APIKey + "&nonce=" + nonce + "&currency = BTC";
            var result = Gethmacsha512(encoding, APISecret, urlForAuth);
            List<CurrencyBalance> list = new List<CurrencyBalance>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlForAuth);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Add("apisign", result);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(urlForAuth).Result) // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        int coinCount = json["result"].Count();
                        for (int i = 1; i <= coinCount; i++)
                        {
                            list.Add(new CurrencyBalance
                            {
                                Currency = json["result"][i - 1]["Currency"].ToString(),
                                Balance = decimal.Parse(json["result"][i - 1]["Balance"].ToString()),
                                Available = decimal.Parse(json["result"][i - 1]["Available"].ToString()),
                                Pending = decimal.Parse(json["result"][i - 1]["Pending"].ToString()),
                                CryptoAddress = json["result"][i - 1]["CryptoAddress"].ToString(),
                            });

                        }
                        //return float.Parse(json["result"][0]["Last"].ToString());
                        return list;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return null;
                    }
                }
            }
        }

        private static string Gethmacsha512(Encoding encoding, string apiSecret, string url)
        {
            // doing the encoding
            var keyByte = encoding.GetBytes(apiSecret);
            string result;
            using (var hmacsha512 = new HMACSHA512(keyByte))
            {
                hmacsha512.ComputeHash(encoding.GetBytes(url));

                result = ByteToString(hmacsha512.Hash);
            }
            return result;
        }

        static string ByteToString(IEnumerable<byte> buff)
        {
            return buff.Aggregate("", (current, t) => current + t.ToString("X2"));
        }

        public static string BuyLimitTo()
        {
            if (APIKey == null || APISecret == null) return null;
            var nonce = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP, need to integrate it
            var encoding = Encoding.UTF8;
            var urlForAuth = @"https://bittrex.com/api/v1.1/market/buylimit?apikey=" + APIKey + "&nonce=" + nonce + "&market=BTC-STRAT&quantity=1&rate=0.00050000";
            var result = Gethmacsha512(encoding, APISecret, urlForAuth);
            List<CurrencyBalance> list = new List<CurrencyBalance>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlForAuth);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Add("apisign", result);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response = client.GetAsync(urlForAuth).Result) // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        string uuid = json["result"]["uuid"].ToString();

                        //return float.Parse(json["result"][0]["Last"].ToString());
                        return uuid;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return null;
                    }
                }
            }
        }

        public static bool CancelOrder(string uuid)
        {
            if (APIKey == null || APISecret == null) return false;
            var nonce = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP, need to integrate it
            var encoding = Encoding.UTF8;
            var urlForAuth = @"https://bittrex.com/api/v1.1/market/cancel?apikey=" + APIKey + "&nonce=" + nonce + "&uuid=" + uuid;
            var result = Gethmacsha512(encoding, APISecret, urlForAuth);
            List<CurrencyBalance> list = new List<CurrencyBalance>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlForAuth);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Add("apisign", result);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                using (HttpResponseMessage response =  client.GetAsync(urlForAuth).Result) // Blocking call!
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body. Blocking!
                        JObject json = response.Content.ReadAsAsync<JObject>().Result;
                        bool success = bool.Parse(json["success"].ToString());
                        return success;
                    }
                    else
                    {
                        string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                        return false;
                    }
                }
            }
        }
    }
}
