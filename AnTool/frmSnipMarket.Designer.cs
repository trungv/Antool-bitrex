namespace AnTool
{
    partial class FrmSnipMarket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.lstvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuyPercentAlarm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumOfCoin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstvCoinPumpDump = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeloop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMinutes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeLoop = new System.Windows.Forms.TextBox();
            this.btnStopRun = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtPercentChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(346, 32);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(47, 40);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lstvResult
            // 
            this.lstvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvResult.Location = new System.Drawing.Point(26, 32);
            this.lstvResult.Name = "lstvResult";
            this.lstvResult.Size = new System.Drawing.Size(305, 509);
            this.lstvResult.TabIndex = 3;
            this.lstvResult.UseCompatibleStateImageBehavior = false;
            this.lstvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coin";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "%Buy";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "%Sell";
            this.columnHeader3.Width = 100;
            // 
            // txtBuyPercentAlarm
            // 
            this.txtBuyPercentAlarm.Location = new System.Drawing.Point(346, 111);
            this.txtBuyPercentAlarm.Name = "txtBuyPercentAlarm";
            this.txtBuyPercentAlarm.Size = new System.Drawing.Size(34, 20);
            this.txtBuyPercentAlarm.TabIndex = 4;
            this.txtBuyPercentAlarm.Text = "75";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buy percent alarm:";
            // 
            // lbNumOfCoin
            // 
            this.lbNumOfCoin.AutoSize = true;
            this.lbNumOfCoin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfCoin.Location = new System.Drawing.Point(23, 563);
            this.lbNumOfCoin.Name = "lbNumOfCoin";
            this.lbNumOfCoin.Size = new System.Drawing.Size(89, 16);
            this.lbNumOfCoin.TabIndex = 5;
            this.lbNumOfCoin.Text = "NumOfCoin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(399, 32);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 40);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstvCoinPumpDump
            // 
            this.lstvCoinPumpDump.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.timeloop});
            this.lstvCoinPumpDump.Location = new System.Drawing.Point(571, 32);
            this.lstvCoinPumpDump.Name = "lstvCoinPumpDump";
            this.lstvCoinPumpDump.Size = new System.Drawing.Size(375, 442);
            this.lstvCoinPumpDump.TabIndex = 6;
            this.lstvCoinPumpDump.UseCompatibleStateImageBehavior = false;
            this.lstvCoinPumpDump.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Coin";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "%Dump";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "%Pump";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Time";
            this.columnHeader7.Width = 111;
            // 
            // timeloop
            // 
            this.timeloop.Text = "Time Loop";
            this.timeloop.Width = 79;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(746, 524);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(44, 13);
            this.lbMinutes.TabIndex = 10;
            this.lbMinutes.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time to loop:";
            // 
            // txtTimeLoop
            // 
            this.txtTimeLoop.Location = new System.Drawing.Point(706, 521);
            this.txtTimeLoop.Name = "txtTimeLoop";
            this.txtTimeLoop.Size = new System.Drawing.Size(34, 20);
            this.txtTimeLoop.TabIndex = 9;
            this.txtTimeLoop.Text = "30";
            // 
            // btnStopRun
            // 
            this.btnStopRun.Location = new System.Drawing.Point(625, 501);
            this.btnStopRun.Name = "btnStopRun";
            this.btnStopRun.Size = new System.Drawing.Size(47, 40);
            this.btnStopRun.TabIndex = 7;
            this.btnStopRun.Text = "Stop";
            this.btnStopRun.UseVisualStyleBackColor = true;
            this.btnStopRun.Click += new System.EventHandler(this.btnStopRun_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(572, 501);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(47, 40);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPercentChange
            // 
            this.txtPercentChange.Location = new System.Drawing.Point(817, 521);
            this.txtPercentChange.Name = "txtPercentChange";
            this.txtPercentChange.Size = new System.Drawing.Size(34, 20);
            this.txtPercentChange.TabIndex = 9;
            this.txtPercentChange.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "%Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(857, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "%Change:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(578, 565);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Coinigy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmSnipMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 607);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercentChange);
            this.Controls.Add(this.txtTimeLoop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStopRun);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lstvCoinPumpDump);
            this.Controls.Add(this.lbNumOfCoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuyPercentAlarm);
            this.Controls.Add(this.lstvResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnScan);
            this.Name = "FrmSnipMarket";
            this.Text = "SnipMarket";
            this.Load += new System.EventHandler(this.FrmSnipMarket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListView lstvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtBuyPercentAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumOfCoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lstvCoinPumpDump;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader timeloop;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeLoop;
        private System.Windows.Forms.Button btnStopRun;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPercentChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}