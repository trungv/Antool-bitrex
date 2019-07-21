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
using BitrexApi.Entities;

namespace AnTool
{
    public partial class frmSpeedTrader : Form
    {
        public frmSpeedTrader()
        {
            InitializeComponent();
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5 * 1000;
            timer1.Start();
        }

        //Sử dụng biên độ 2%
        float amplitude = 0.05f;
        float totalGoc = 0;//Xoa

        float valueFirst = 1;
        float valueLast = 1;
        //NOTE: CHo trước 1 giá, và canh giá tăng từ giá đó.
        void SpeedTrade()
        {
            //Lay gia dau tien
            if (time == 0)
            {
                //NOTE: Choi cho vui, chinh thuc xoa
                txtPrice.Text = BitrexApi.MarketSummariesAPI.GetSummaryByName(txtCoin.Text).Last.ToString("0.00000000");
                valueFirst = float.Parse(txtPrice.Text);
                totalGoc = valueFirst * float.Parse(txtTime.Text) * 0.9925f;
            }
            //Time lấy của tick, đếm số phút cho thằng BTC lấy giá trị.
            //Do Interval = 1500, 60 = 40x1.5
            else
            {
                valueLast = MarketSummariesAPI.GetSummaryByName(txtCoin.Text).Last;
                float realPercentchange = 1;
                string check = MarketSummariesAPI.AlertDumpOrPump(amplitude, valueFirst, valueLast, ref realPercentchange);
                if (realPercentchange > 0)
                {
                    valueFirst = valueLast;
                }
                else
                {
                    if (check == "DUMP")
                    {
                        timer1.Stop();
                        float giaBan = valueLast * 0.997f;
                        MessageBox.Show("Ban voi gia: " + giaBan.ToString("0.00000000"));
                    }
                }
                float total = float.Parse(txtTime.Text) * valueFirst * 0.9925f;
                StringBuilder status = new StringBuilder();
                status.Append(time.ToString());
                status.Append(" Status: " + check + " ");
                status.Append(realPercentchange.ToString("P"));
                status.Append(valueFirst.ToString("0.00000000") + " => " + valueLast.ToString("0.00000000"));
                status.Append(" Total: " + total.ToString("0.00000000"));
                status.Append(" Total Goc: " + totalGoc.ToString("0.00000000"));
                lbStatus.Text = status.ToString();
            }

            //So sánh, nếu nó lên thì nâng giá lên
            //Nếu nó tụt xuống lại thì bán
        }

        #region LuuTru
        //void SpeedTradeStore()
        //{
        //    //Lay gia dau tien
        //    if (time == 0)
        //    {
        //        valueFirst = float.Parse(txtPrice.Text);
        //    }
        //    //Time lấy của tick, đếm số phút cho thằng BTC lấy giá trị.
        //    //Do Interval = 1500, 60 = 40x1.5
        //    else
        //    {
        //        valueLast = MarketSummariesAPI.GetSummaryByName(txtCoin.Text).Last;
        //        float realPercentchange = 1;
        //        string check = MarketSummariesAPI.AlertDumpOrPump(amplitude, valueFirst, valueLast, ref realPercentchange);
        //        if (realPercentchange > 0)
        //        {
        //            valueFirst = valueLast;
        //        }
        //        else
        //        {
        //            if (check == "DUMP")
        //            {
        //                timer1.Stop();
        //                float giaBan = valueLast * 0.997f;
        //                MessageBox.Show("Ban voi gia: " + giaBan.ToString("0.00000000"));
        //            }
        //        }
        //        float total = float.Parse(txtTime.Text) * valueFirst * 0.995f;
        //        StringBuilder status = new StringBuilder();
        //        status.Append(time.ToString());
        //        status.Append(" Status: " + check + " ");
        //        status.Append(realPercentchange.ToString("P"));
        //        status.Append(valueFirst.ToString("0.000000000") + " => " + valueLast.ToString("0.00000000"));
        //        status.Append(" Total: " + total.ToString("0.00000000"));
        //        status.Append(time.ToString());
        //        lbStatus.Text = status.ToString();
        //    }

        //    //So sánh, nếu nó lên thì nâng giá lên
        //    //Nếu nó tụt xuống lại thì bán
        //}
        #endregion
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            SpeedTrade();
            time++;
        }
    }
}
