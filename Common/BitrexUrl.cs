using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class BitrexUrl
    {
        public static string getmarketsummaries = "https://bittrex.com/api/v1.1/public/getmarketsummaries";
        public static string getcurrencies = "https://bittrex.com/api/v1.1/public/getcurrencies";
        public static string getorderbook(string coinName)
        {
            return @"https://bittrex.com/api/v1.1/public/getorderbook?market="+coinName+@"&type=both";
        }
        public static string getmarketsummariesByName(string coinName)
        {
            return @"https://bittrex.com/api/v1.1/public/getmarketsummary?market=" + coinName;
        }
    }
}
