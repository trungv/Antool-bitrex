using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitrexApi;
using BitrexApi.Entities;

namespace AnTool
{
    public partial class TestAccountAPI : Form
    {
        public TestAccountAPI()
        {
            InitializeComponent();
        }

        string APIKey = "06f428312531448eabbf736988dab272";
        string APISecret = "d21c093ab59e4ebd99165a4e5f012c05";

        public List<CurrencyBalance> GetAccountCurrencies1()
        {
            if (APIKey == null || APISecret == null) return new List<CurrencyBalance>();
            var nonce = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP, need to integrate it
            var encoding = Encoding.UTF8;
            var urlForAuth = @"https://bittrex.com/api/v1.1/account/getbalances?apikey=" + APIKey + "&nonce=" + nonce;
            var result = Gethmacsha512(encoding, APISecret, urlForAuth);

            // some var for the request
            var account = new List<CurrencyBalance>();

            // sending it to get the response
            var request = (HttpWebRequest)WebRequest.Create(urlForAuth);
            request.Headers.Add("apisign", result);
            //request.Headers.Add("nonce", nonce.ToString());
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            //var stream = response.ContentEncoding.

            //response.GetValue(stream, account);
            return account;
        }

        public int GetAccountCurrencies()
        {
            if (APIKey == null || APISecret == null) return -1;
            var nonce = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP, need to integrate it
            var encoding = Encoding.UTF8;
            var urlForAuth = @"https://bittrex.com/api/v1.1/account/getbalances?apikey=" + APIKey + "&nonce=" + nonce;
            var result = Gethmacsha512(encoding, APISecret, urlForAuth);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(urlForAuth);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Add("apisign", result);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlForAuth).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                //Object json = response.Content.ReadAsAsync<Object>().Result;
                //return float.Parse(json["result"][0]["Last"].ToString());
                return 1;
            }
            else
            {
                string error = response.StatusCode.ToString() + response.ReasonPhrase.ToString();
                return 0;
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
        private void button1_Click(object sender, EventArgs e)
        {
            GetAccountCurrencies();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<BitrexApi.Entities.CurrencyBalance> list = BitrexApi.AccountAPI.GetAccountCurrencies();
            foreach(var x in list)
            {
                if(x.Currency=="BTC")
                {
                    MessageBox.Show(x.Currency + x.Balance);
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uuid = BitrexApi.AccountAPI.BuyLimitTo();
            if(uuid == null)
            {
                MessageBox.Show("that bai");
            }
            else
            {
                MessageBox.Show(uuid);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var item = OrderBookAPI.getInfoOrderBook("BTC-STRAT");
            MessageBox.Show(item.PercentBuy.ToString()+" "+item.TotalSell);
        }
    }
}
