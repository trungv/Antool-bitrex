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
    public partial class frmCoinInfo : Form
    {
        public frmCoinInfo()
        {
            InitializeComponent();
        }

        List<Currency> list = CurrencyAPI.GetListSummary();
        private void frmCoinInfo_Load(object sender, EventArgs e)
        {
            foreach(var item in list)
            {
                lstvCoinPumpDump.Items.Add(new ListViewItem(new string[] {
                    item.CurrencyName,
                    item.CurrencyLong,
                    item.MinConfirmation.ToString(),
                    item.TxFee.ToString("0.00000000"),
                    item.IsActive.ToString(),
                    item.CoinType,
                    item.Notice
                }));
            }
        }
    }
}
