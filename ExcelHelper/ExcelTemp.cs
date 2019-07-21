using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitrexApi;
using CoinMarketCapApi;
using Microsoft.Office.Interop.Excel;

namespace ExcelHelper
{
    public static class ExcelTemp
    {
        static Microsoft.Office.Interop.Excel.Application oXL;
        static Microsoft.Office.Interop.Excel._Workbook oWB;
        static Microsoft.Office.Interop.Excel._Worksheet oSheet;
        static Microsoft.Office.Interop.Excel.Range oRng;
        static object misvalue = System.Reflection.Missing.Value;
        public static void WriteInfoCoin()
        {

            //Start Excel and get Application object.
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;

            //Get a new workbook.
            //oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
            //oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Open(@"C:\test505.xlsx", misvalue,
                                                            false, misvalue, misvalue, misvalue, misvalue,
                                                            Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, misvalue, misvalue,
                                                            misvalue, misvalue, misvalue, misvalue, misvalue));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

            //NOTE: PHAN TUI LAM
            //LAY GIA TRI THI TRUONG TONG HOP
            JObject marketsummaries = MarketSummariesAPI.Getmarketsummaries();
            JObject globalData = CoinMarketCapApi.GlobalData.GetGlobalData();
            if (marketsummaries == null)
            {
                return;
            }

            //KIEM TRA NEU LA FILE EXCEL MOI HOAN TOAN
            if (oSheet.Cells[1, 1].Value2 == null)
            {
                //IN 2 COT DAU
                oSheet.Cells[1, 1].Value2 = "Time => ";
                oSheet.Cells[1, 2].Value2 = DateTime.Now.ToString();
                int i = 1;
                for (; i <= marketsummaries["result"].Count(); i++)
                {
                    if (marketsummaries["result"][i - 1]["MarketName"].ToString().Substring(0, 3) == "ETH")
                    {
                        break;
                    }
                    oSheet.Cells[2 * i + 1, 1].Value2 = marketsummaries["result"][i - 1]["MarketName"];
                    oSheet.Cells[2 * i + 1, 2].Value2 = marketsummaries["result"][i - 1]["BaseVolume"];
                    oSheet.Cells[2 * i + 2, 2].Value2 = marketsummaries["result"][i - 1]["Last"];
                }
                oSheet.Cells[2 * i + 3, 2].Value2 = Math.Round(float.Parse(globalData["total_market_cap_usd"].ToString())/1000000000,2);
                oSheet.Cells[2 * i + 4, 2].Value2 = Math.Round(float.Parse(globalData["total_24h_volume_usd"].ToString()) / 1000000000, 2);
                oSheet.Cells[2 * i + 5, 2].Value2 = float.Parse(globalData["bitcoin_percentage_of_market_cap"].ToString())/100;
                oSheet.Cells[2 * i + 6, 2].Value2 = CoinMarketCapApi.Ticker.GetPriceBTC();
            }
            else
            {
                //IN 1 COT TIEP THEO - init i là index cua column cua ẽxcel. cell[dong, cot]
                int indexColumn = 1;
                for (; indexColumn < 10000; indexColumn++)
                {
                    if (oSheet.Cells[1, indexColumn].Value2 == null)
                    {
                        break;
                    }
                }
                oSheet.Cells[1, indexColumn].Value2 = DateTime.Now.ToString();
                int i = 1;
                for (; i <= marketsummaries["result"].Count(); i++)
                {
                    if (marketsummaries["result"][i - 1]["MarketName"].ToString().Substring(0, 3) == "ETH")
                    {
                        break;
                    }
                    float baseVolume = float.Parse(marketsummaries["result"][i - 1]["BaseVolume"].ToString());
                    dynamic preValue = oSheet.Cells[2 * i + 1, indexColumn - 1].Value2;                  
                    oSheet.Cells[2 * i + 1, indexColumn].Value2 = baseVolume;
                    setColorPullBearBackground(preValue, baseVolume, oSheet.Cells[2 * i + 1, indexColumn]);

                    float last = float.Parse(marketsummaries["result"][i - 1]["Last"].ToString());
                    oSheet.Cells[2 * i + 2, indexColumn].Value2 = last;
                    setColorPullBear(oSheet.Cells[2 * i + 2, indexColumn - 1].Value2, last, oSheet.Cells[2 * i + 2, indexColumn]);
                }
                float total_market_cap_usd = (float)Math.Round(float.Parse(globalData["total_market_cap_usd"].ToString()) / 1000000000, 2);
                oSheet.Cells[2 * i + 3, indexColumn].Value2 = total_market_cap_usd;
                setColorPullBearBackground(oSheet.Cells[2 * i + 3, indexColumn-1].Value2, 
                                           total_market_cap_usd, 
                                           oSheet.Cells[2 * i + 3, indexColumn]);

                float total_24h_volume_usd = (float)Math.Round(float.Parse(globalData["total_24h_volume_usd"].ToString()) / 1000000000, 2);
                oSheet.Cells[2 * i + 4, indexColumn].Value2 = total_24h_volume_usd;
                setColorPullBearBackground(oSheet.Cells[2 * i + 4, indexColumn - 1].Value2,
                                           total_24h_volume_usd,
                                           oSheet.Cells[2 * i + 4, indexColumn]);

                float bitcoin_percentage_of_market_cap = float.Parse(globalData["bitcoin_percentage_of_market_cap"].ToString())/100;
                oSheet.Cells[2 * i + 5, indexColumn].Value2 = bitcoin_percentage_of_market_cap;
                setColorPullBearBackground(oSheet.Cells[2 * i + 5, indexColumn - 1].Value2,
                                           bitcoin_percentage_of_market_cap,
                                           oSheet.Cells[2 * i + 5, indexColumn]);

                float priceBTC = float.Parse(CoinMarketCapApi.Ticker.GetPriceBTC());
                oSheet.Cells[2 * i + 6, indexColumn].Value2 = priceBTC;
                setColorPullBearBackground(oSheet.Cells[2 * i + 6, indexColumn - 1].Value2,
                                           priceBTC,
                                           oSheet.Cells[2 * i + 6, indexColumn]);
            }
            ////Fill C2:C6 with a relative formula (=A2 & " " & B2).
            //oRng = oSheet.get_Range("C2", "C6");
            //oRng.Formula = "=A2 & \" \" & B2";
            //
            //int a = oRng.Columns.Count;
            //
            ////Fill D2:D6 with a formula(=RAND()*100000) and apply format.
            //oRng = oSheet.get_Range("D2", "D6");
            //oRng.Formula = "=RAND()*100000";
            //oRng.NumberFormat = "$0.00";

            //AutoFit columns A:D.
            oRng = oSheet.get_Range("A1", "Z1");
            oRng.EntireColumn.AutoFit();
            //oRng.Font.Color = XlRgbColor.rgbBlueViolet;
            //oRng = oSheet.get_Range(oSheet.Cells[2 * i + 1, indexColumn - 1], oSheet.Cells[2 * i + 1, indexColumn - 1]);
            //oRng.Interior.Color = XlRgbColor.rgbSkyBlue;
            //oRng.Font.Color = XlRgbColor.rgbWhite;

            oXL.Visible = false;
            oXL.UserControl = false;
            oWB.Save();
            oWB.Close(true, misvalue, misvalue);
            oXL.Quit();
        }

        private static void setColorPullBear(dynamic valueTruoc, float valueSau, object cell)
        {
            if (valueTruoc < valueSau)
            {
                var columnHeadingsRange = oSheet.Range[cell,cell];
                columnHeadingsRange.Font.Color = XlRgbColor.rgbGreen;
                columnHeadingsRange.Font.Bold = true;
            }
            else
            {
                var columnHeadingsRange = oSheet.Range[cell,cell];
                columnHeadingsRange.Font.Color = XlRgbColor.rgbRed;
                columnHeadingsRange.Font.Bold = true;
            }

            //if (oSheet.Cells[2 * i + 1, indexColumn - 1].Value2 < baseVolume)
            //{
            //    
            //
            //    var columnHeadingsRange = oSheet.Range[
            //                                oSheet.Cells[2 * i + 1, indexColumn],
            //                                oSheet.Cells[2 * i + 1, indexColumn]];
            //
            //    columnHeadingsRange.Font.Color = XlRgbColor.rgbGreen;
            //}
            //else
            //{
            //    var columnHeadingsRange = oSheet.Range[
            //                                oSheet.Cells[2 * i + 1, indexColumn],
            //                                oSheet.Cells[2 * i + 1, indexColumn]];
            //
            //    columnHeadingsRange.Font.Color = XlRgbColor.rgbRed;
            //}
        }

        private static void setColorPullBearBackground(dynamic valueTruoc, float valueSau, object cell)
        {
            if (valueTruoc < valueSau)
            {
                var columnHeadingsRange = oSheet.Range[cell, cell];
                columnHeadingsRange.Interior.Color = XlRgbColor.rgbGreen;
                columnHeadingsRange.Font.Color = XlRgbColor.rgbWhite;
            }
            else
            {
                var columnHeadingsRange = oSheet.Range[cell, cell];
                columnHeadingsRange.Interior.Color = XlRgbColor.rgbRed;
                columnHeadingsRange.Font.Color = XlRgbColor.rgbWhite;
            }
        }
    }
}
