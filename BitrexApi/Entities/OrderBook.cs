using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrexApi.Entities
{
    public class OrderBook
    {
        public float TotalBuy { get; set; }
        public float TotalSell { get; set; }
        public float PercentBuy { get; set; }
        public float PercentSell { get; set; }
    }
}
