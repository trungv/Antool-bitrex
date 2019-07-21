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
using System.Diagnostics;
using BitrexApi.Entities;
using System.Globalization;
using System.Threading;

namespace AnTool
{
    public partial class frmWatchMarket : Form
    {
        public frmWatchMarket()
        {
            InitializeComponent();
        }

        List<MarketSummary> listCoin = BitrexApi.MarketSummariesAPI.GetListSummary("BTC");
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Time Start: " + DateTime.Now.ToString();
            FollowCoin();
            timer1.Interval = 5000;
            timer1.Start();
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            Thread threadFollowCoin = new Thread(FollowCoin);
            threadFollowCoin.Start();
        }

        void FollowCoin()
        {
            //lstvResult.Items[0].SubItems[3].Text = "da doi";
            //lstvResult.Items[0].SubItems[0].Text = "da doi 1";
            //lstvResult.Items[0].SubItems[1].Text = "da doi 2";
            //lstvResult.Items[0].SubItems[2].Text = "da doi 3";
            ListViewItem item;
            if(time == 0)
            {
                foreach (var coin in listCoin)
                {
                    item = new ListViewItem(new string[] {
                    coin.NameCoin,
                    coin.Last.ToString("0.00000000", CultureInfo.InvariantCulture),
                    "",
                    ""
                });
                    lstvResult.Items.Add(item);
                }
                listCoin.Clear();
            }
            else
            {
                listCoin = BitrexApi.MarketSummariesAPI.GetListSummary("BTC");
                int index=0;
                foreach (var coin in listCoin)
                {
                    lstvResult.Invoke(new Action(()=>lstvResult.Items[index].SubItems[2].Text = coin.Last.ToString("0.00000000")));

                    float valueFirst = 0;
                    lstvResult.Invoke(new Action(() => valueFirst = float.Parse(lstvResult.Items[index].SubItems[1].Text)));

                    float changePercent = (coin.Last - valueFirst) / valueFirst;
                    lstvResult.Invoke(new Action(() => lstvResult.Items[index].SubItems[3].Text = changePercent.ToString("P")));
                    if (changePercent > 0)
                    {
                        lstvResult.Invoke(new Action(() => lstvResult.Items[index].ForeColor = Color.Green));
                    }
                    else if (changePercent == 0)
                    {
                        lstvResult.Invoke(new Action(() => lstvResult.Items[index].ForeColor = Color.Black));
                    }
                    else
                    {
                        lstvResult.Invoke(new Action(() => lstvResult.Items[index].ForeColor = Color.Red));
                    }

                    index++;
                }
                index = 0;
                listCoin.Clear();
            }
        }
    }
}
