using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelHelper;
using System.Diagnostics;
using System.Threading;

namespace AnTool
{
    public partial class frmAnalyster : Form
    {
        public frmAnalyster()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(txtTimeToLoop.Text) * 60 * 1000;
            ExcelHelper.ExcelTemp.WriteInfoCoin();
            timeOfRunning = 1;
            lbRun.Text = "Running " + timeOfRunning.ToString() + " times";
            btnRun.Enabled = false;
            btnStop.Enabled = true;
            timer1.Start();
        }

        private void frmAnalyster_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Enabled = false;
            btnRun.Enabled = true;
            lbRun.Text = "Not Run:!!!";
        }

        int timeOfRunning = 0;
        Thread threadWriteCoin;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeOfRunning++;
            lbRun.Text = "Running " + timeOfRunning.ToString() + " times";
            threadWriteCoin = new Thread(ExcelHelper.ExcelTemp.WriteInfoCoin);
            threadWriteCoin.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTrader frm = new FrmTrader();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSnipMarket frm = new FrmSnipMarket();
            frm.Show();
        }

        private void llViewDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\test505.xlsx");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmWatchMarket frm = new frmWatchMarket();
            frm.Show();
        }

        bool flagTatMay = false;
        private void button7_Click(object sender, EventArgs e)
        {            
            if(!flagTatMay)
            {
                Process.Start("shutdown", @"-s -t " + txtTatMayTime.Text);
                btnShutdown.Text = "Dừng";
                flagTatMay = true;
            }
            else
            {
                Process.Start("shutdown", "-a");
                btnShutdown.Text = "Tắt máy";
                flagTatMay = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSpeedTrader frm = new frmSpeedTrader();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCoinInfo frm = new frmCoinInfo();
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frmChart frm = new frmChart();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TestAccountAPI frm = new TestAccountAPI();
            frm.Show();
        }
    }
}
