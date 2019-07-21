using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnTool
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            SplineChartExample();

        }
        private void SplineChartExample()
        {
            //NOTE: Ví dụ về chart.
            #region ChartExample
            //this.chart1.Series.Clear();

            //this.chart1.Titles.Add("Total Income");

            //Series series = this.chart1.Series.Add("Total Income");
            //series.ChartType = SeriesChartType.Spline;
            //series.Points.AddXY("September", 100);
            //series.Points.AddXY("Obtober", 300);
            //series.Points.AddXY("November", 800);
            //series.Points.AddXY("December", 200);
            //series.Points.AddXY("January", 600);
            //series.Points.AddXY("February", 400);
            //series.Points.AddXY("February", 1400);
            //series.Points.AddXY("February", 1200);

            //chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            ////chart1.Series[1].YAxisType = AxisType.Secondary;

            //Series series2 = this.chart1.Series.Add("Income x");
            //series2.YAxisType = AxisType.Secondary;
            //series2.ChartType = SeriesChartType.Spline;
            //series2.Points.AddXY("September", 20);
            //series2.Points.AddXY("Obtober", 70);
            //series2.Points.AddXY("November", 10);
            //series2.Points.AddXY("December", 30);
            //series2.Points.AddXY("January", 10);
            //series2.Points.AddXY("February", 240);
            //series2.Points.AddXY("February", 40);
            //series2.Points.AddXY("February", 220);

            //Series series3 = this.chart1.Series.Add("Income y");
            //series3.YAxisType = AxisType.Secondary;
            //series3.ChartType = SeriesChartType.Spline;
            //series3.Points.AddXY("September", 20);
            //series3.Points.AddXY("Obtober", 70);
            //series3.Points.AddXY("November", 210);
            //series3.Points.AddXY("December", 30);
            //series3.Points.AddXY("January", 110);
            //series3.Points.AddXY("February", 140);
            //series3.Points.AddXY("February", 10);
            //series3.Points.AddXY("February", 920);
            #endregion

            this.chart1.Series.Clear();

            this.chart1.Titles.Add("Total Income");

            Series series = this.chart1.Series.Add("Total Income");
            series.ChartType = SeriesChartType.Spline;
            DataTable table = ExcelHelper.ExcelSuporter.readExcel();
            for(int i=0;i<table.Rows.Count;i++)
            {

                series.Points.AddXY(table.Rows[i][0], table.Rows[i][1]);
                //series.Points.AddXY("Obtober", 300);
                //series.Points.AddXY("November", 800);
                //series.Points.AddXY("December", 200);
                //series.Points.AddXY("January", 600);
                //series.Points.AddXY("February", 400);
                //series.Points.AddXY("February", 1400);
                //series.Points.AddXY("February", 1200);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ExcelHelper.ExcelSuporter.readExcel();
        }
    }
}
