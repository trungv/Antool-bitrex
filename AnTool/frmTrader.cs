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
using System.Threading;

namespace AnTool
{
    public partial class FrmTrader : Form
    {
        public FrmTrader()
        {
            InitializeComponent();
        }
        int flagBuy = 0;
        private void btnRun_Click(object sender, EventArgs e)
        {
            time = 0;
            btnRun.Enabled = false;
            btnStop.Enabled = true;
            grbAdvance.Enabled = false;
            tradeV101();
            timer1.Start();
        }

        //Version V1: Có thể ăn đầu cuối theo chỉ định 1 lần.
        #region TradeFunctionV1
        //private void tradeV1()
        //{
        //    float giaDoiMua = float.Parse(txtWaitingBuyPrice.Text);
        //    float giaDoiBan = float.Parse(txtWaitingSellPrice.Text);
        //    float giaLast = BitrexApi.MarketSummariesAPI.GetPriceCoinbyName(txtCoinName.Text);
        //    if (giaLast <= giaDoiMua && flagBuy == 0)
        //    {
        //        timer1.Stop();
        //        MessageBox.Show("mua no voi gia : if mua đc thi flagbuy se bat");
        //        flagBuy = 1;
        //        timer1.Start();
        //    }
        //    if (flagBuy == 1 && giaDoiBan <= giaLast)
        //    {
        //        timer1.Stop();
        //        MessageBox.Show("ban voi gia đã set sẵn trong textbox");
        //    }
        //}
        #endregion

        //Version V1.01: Cải tiến an toàn. phát hiện BTC pump, dump để dừng.
        #region TradeFunctionV101
        private void tradeV101()
        {
            float giaDoiMua = float.Parse(txtWaitingBuyPrice.Text);
            float giaDoiBan = float.Parse(txtWaitingSellPrice.Text);
            float giaLast = MarketSummariesAPI.GetSummaryByName(txtCoinName.Text).Last;
            if (chkBTCGuard.Checked && flagBuy == 0)
            {
                if (time == 0)
                {
                    valueFirst = MarketSummariesAPI.GetSummaryByName("USDT-BTC").Last;
                }
                //Time lấy của tick, đếm số phút cho thằng BTC lấy giá trị.
                //Do Interval = 1500, 60 = 40x1.5
                if (time == int.Parse(txtMinuteOfBTC.Text) * 40)
                {
                    valueLast = MarketSummariesAPI.GetSummaryByName("USDT-BTC").Last;
                    float realPercentchange = 1;
                    string check = MarketSummariesAPI.AlertDumpOrPump(float.Parse(txtBTCGuard.Text) / 100, valueFirst, valueLast, ref realPercentchange);
                    if (check != "NONE")
                    {
                        timer1.Stop();
                        MessageBox.Show("Lá chắn bật: " + realPercentchange.ToString());
                        //TODO: Nữa kích hoạt event nuts Stop sẽ hay hơn.
                    }
                    lbTestChan.Invoke(new Action(() => lbTestChan.Text = realPercentchange.ToString("P")));
                    valueFirst = valueLast;
                    time = 0;
                }
            }
            if (giaLast <= giaDoiMua && flagBuy == 0)
            {
                timer1.Stop();
                MessageBox.Show("mua no voi gia : if mua đc thi flagbuy se bat");
                flagBuy = 1;
                timer1.Start();
            }
            if (flagBuy == 1 && giaDoiBan <= giaLast)
            {
                timer1.Stop();
                MessageBox.Show("ban voi gia đã set sẵn trong textbox");
            }
            lbLast.Invoke(new Action(() => lbLast.Text = MarketSummariesAPI.GetSummaryByName(txtCoinName.Text).Last.ToString()));
            lbFlagBuy.Invoke(new Action(() => lbFlagBuy.Text = flagBuy == 1 ? "Đã Mua" : "Chưa Mua"));
            //if(chkStoplossAt.Checked)
            //{
            //    if(flagBuy == 1 && giaLast<=float.Parse(txtStopLoss.Text)*1.01)
            //    {
            //        MessageBox.Show("Quăng cái stoploss ra");
            //    }
            //}
            //if(chkStoplossIncrease.Checked)
            //{
            //
            //}
        }
        #endregion
        //TODO: V1.1 biến thái, có thể ăn nhìu lần.
        #region V1.1
        #endregion
        //Version v2: Đang xây dựng. Cải tiến mạnh mẽ thêm stoploss và tự nâng stoploss khi pumpcoin.
        #region TradeV2UnderContruct
        private void trade()
        {
            float giaDoiMua = float.Parse(txtWaitingBuyPrice.Text);
            float giaDoiBan = float.Parse(txtWaitingSellPrice.Text);
            float giaLast = MarketSummariesAPI.GetSummaryByName(txtCoinName.Text).Last;
            if (giaLast <= giaDoiMua && flagBuy == 0)
            {
                timer1.Stop();
                MessageBox.Show("mua no voi gia : if mua đc thi flagbuy se bat");
                flagBuy = 1;
                timer1.Start();
            }
            if (flagBuy == 1 && giaDoiBan <= giaLast)
            {
                timer1.Stop();
                MessageBox.Show("ban voi gia đã set sẵn trong textbox");
            }
            float giaCatLo = float.Parse(txtStopLoss.Text);
            if (flagBuy == 1 && giaLast <= giaCatLo * 1.01)
            {
                timer1.Stop();
                MessageBox.Show("Đặt stoploss");
            }
        }
        #endregion

        private void frmTrader_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            timer1.Interval = 1 * 1500;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = 0;
            grbAdvance.Enabled = true;
            btnRun.Enabled = true;
            lbStatus.Text = time != 0 ? "Status: Running" : "Status: Stop";
        }

        #region ValueInitForTick
        float valueFirst = 1;
        float valueLast = 1;
        int time = 0;
        #endregion

        #region Tick_Old
        //void tick()
        //{
        //    time++;
        //    string check = "";
        //    if (time == 30)
        //    {
        //        valueLast = BitrexApi.MarketSummariesAPI.GetPriceCoinbyName("USDT-BTC");
        //        float realPercentchange = 1;
        //        check = BitrexApi.MarketSummariesAPI.AlertDumpOrPump((float)0.01, valueFirst, valueLast, ref realPercentchange);
        //        if (check != "NONE")
        //        {
        //            timer1.Stop();
        //        }
        //        valueFirst = valueLast;
        //        time = 0;
        //    }
        //    //lbTestChan.Text = "first: " + valueFirst.ToString() + " last: " + valueLast.ToString() + " " + check + " time: " + time;
        //    //
        //    //
        //    lbLast.Invoke(new Action(() => lbLast.Text = BitrexApi.MarketSummariesAPI.GetPriceCoinbyName(txtCoinName.Text).ToString()));
        //    lbFlagBuy.Invoke(new Action(() => lbFlagBuy.Text = flagBuy==1?"Đã Mua":"Chưa Mua"));
        //    tradeV1();
        //}
        #endregion
        Thread runTick;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            lbStatus.Text = time != 0 ? "Status: Running" : "Status: Stop";
            runTick = new Thread(tradeV101);
            runTick.Start();
        }

        private void llGo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://bittrex.com/Market/Index?MarketName=" + txtCoinName.Text);
        }
    }
}
