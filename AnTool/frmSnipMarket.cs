using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitrexApi;
using System.Threading;
using System.Diagnostics;
using BitrexApi.Entities;

namespace AnTool
{
    public partial class FrmSnipMarket : Form
    {
        public FrmSnipMarket()
        {
            InitializeComponent();
        }

        OrderBook order;
        void Scan()
        {
            int i = 0;
            foreach (var coin in listCoin)
            {
                i++;
                order = BitrexApi.OrderBookAPI.getInfoOrderBook(coin.NameCoin);
                ListViewItem item = new ListViewItem(new string[] {
                    coin.NameCoin,
                    Math.Round(order.PercentBuy*100,2).ToString(),
                    Math.Round(order.PercentSell*100,2).ToString()
                    });
                if (order.PercentBuy >= float.Parse(txtBuyPercentAlarm.Text) / 100)
                {
                    item.BackColor = Color.Aqua;
                }
                lstvResult.Invoke(new Action(() => lstvResult.Items.Add(item)));
                lbNumOfCoin.Invoke(new Action(() => lbNumOfCoin.Text = "NumOfCoin: " + i.ToString() + " Waiting!!!!"));
            }
            lbNumOfCoin.Invoke(new Action(() => lbNumOfCoin.Text = "NumOfCoin: " + i.ToString() + " DONE!!!!"));
        }

        Thread threadScan;
        private void btnScan_Click(object sender, EventArgs e)
        {
            lstvResult.Items.Clear();
            threadScan = new Thread(Scan);
            threadScan.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            threadScan.Abort();
        }

        List<MarketSummary> listSummaryFirst;
        List<MarketSummary> listSummaryLast;
        private void btnRun_Click(object sender, EventArgs e)
        {
            listSummaryFirst = MarketSummariesAPI.GetListSummary("BTC");
            timer1.Interval = int.Parse(txtTimeLoop.Text) *60* 1000;
            timeTick = 0;

            FindCoinPumpDump();
            timer1.Start();
        }

        int timeTick = 0;
        void FindCoinPumpDump()
        {
            float percentChange = float.Parse(txtPercentChange.Text) / 100;
            if (timeTick != 0)
            {
                listSummaryLast = MarketSummariesAPI.GetListSummary("BTC");
                int i = 0;
                ListViewItem item;
                foreach (var coin in listCoin)
                {
                    float realPercentChange = 0;
                    string check = MarketSummariesAPI.AlertDumpOrPump(percentChange, listSummaryFirst[i].Last, listSummaryLast[i].Last, ref realPercentChange);
                    if (check == "NONE")
                    {
                        i++;
                        continue;// countinue ma khong cong i truoc, dan den chay sai
                    }
                    else if (check == "PUMP")
                    {
                        //Add vao list va to mau xanh
                        item = new ListViewItem(new string[] {
                            coin.NameCoin,
                            "",
                            Math.Round((realPercentChange*100),2).ToString(),
                            DateTime.Now.ToShortTimeString(),
                            txtTimeLoop.Text + " Minutes"
                        });
                        item.BackColor = Color.Green;
                        item.ForeColor = Color.White;
                        lstvCoinPumpDump.Items.Add(item);
                    }
                    else
                    {
                        //Add vao list va to mau do
                        item = new ListViewItem(new string[] {
                            coin.NameCoin,
                            Math.Round((realPercentChange*100),2).ToString(),
                            "",
                            DateTime.Now.ToShortTimeString(),
                            txtTimeLoop.Text + " Minutes"
                        });
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                        lstvCoinPumpDump.Items.Add(item);
                    }
                    i++;
                }
                listSummaryFirst = listSummaryLast;
            }
            timeTick++;

            string log = timeTick.ToString();
            label6.Text = log;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FindCoinPumpDump();
        }

        private void btnStopRun_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstvCoinPumpDump.Items.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.coinigy.com/auth/login");
            //Process.Start(@"C:\test505.xlsx");
        }

        List<MarketSummary> listCoin;
        private void FrmSnipMarket_Load(object sender, EventArgs e)
        {
            listCoin = BitrexApi.MarketSummariesAPI.GetListSummary("BTC");
        }
    }
}
