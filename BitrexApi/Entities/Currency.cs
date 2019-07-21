using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrexApi.Entities
{
    public class Currency
    {
        public string CurrencyName { get; set; }
        public string CurrencyLong { get; set; }
        public int MinConfirmation { get; set; }
        public float TxFee { get; set; }
        public bool IsActive { get; set; }
        public string CoinType { get; set; }
        public string BaseAddress { get; set; }
        public string Notice { get; set; }
    }
}
