namespace AnTool
{
    partial class FrmTrader
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
            this.txtCoinName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtWaitingBuyPrice = new System.Windows.Forms.TextBox();
            this.txtWaitingSellPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbFlagBuy = new System.Windows.Forms.Label();
            this.txtStopLoss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTestChan = new System.Windows.Forms.Label();
            this.txtBTCGuard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbAdvance = new System.Windows.Forms.GroupBox();
            this.chkStoplossAt = new System.Windows.Forms.CheckBox();
            this.chkBTCGuard = new System.Windows.Forms.CheckBox();
            this.lbStoplossPresent = new System.Windows.Forms.Label();
            this.chkStoplossIncrease = new System.Windows.Forms.CheckBox();
            this.txtMinuteOfBTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.grbBasic = new System.Windows.Forms.GroupBox();
            this.llGo = new System.Windows.Forms.LinkLabel();
            this.grbAdvance.SuspendLayout();
            this.grbBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCoinName
            // 
            this.txtCoinName.Location = new System.Drawing.Point(146, 19);
            this.txtCoinName.Name = "txtCoinName";
            this.txtCoinName.Size = new System.Drawing.Size(71, 20);
            this.txtCoinName.TabIndex = 0;
            this.txtCoinName.Text = "BTC-";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(146, 53);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWaitingBuyPrice
            // 
            this.txtWaitingBuyPrice.Location = new System.Drawing.Point(146, 87);
            this.txtWaitingBuyPrice.Name = "txtWaitingBuyPrice";
            this.txtWaitingBuyPrice.Size = new System.Drawing.Size(71, 20);
            this.txtWaitingBuyPrice.TabIndex = 2;
            this.txtWaitingBuyPrice.Text = "0.00000000";
            this.txtWaitingBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWaitingSellPrice
            // 
            this.txtWaitingSellPrice.Location = new System.Drawing.Point(146, 121);
            this.txtWaitingSellPrice.Name = "txtWaitingSellPrice";
            this.txtWaitingSellPrice.Size = new System.Drawing.Size(71, 20);
            this.txtWaitingSellPrice.TabIndex = 3;
            this.txtWaitingSellPrice.Text = "0.00000000";
            this.txtWaitingSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coin Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price expected to buy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price expected to sell:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(146, 157);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(235, 157);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(267, 22);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(67, 13);
            this.lbLast.TabIndex = 3;
            this.lbLast.Text = "PresentPrice";
            // 
            // lbFlagBuy
            // 
            this.lbFlagBuy.AutoSize = true;
            this.lbFlagBuy.Location = new System.Drawing.Point(376, 22);
            this.lbFlagBuy.Name = "lbFlagBuy";
            this.lbFlagBuy.Size = new System.Drawing.Size(45, 13);
            this.lbFlagBuy.TabIndex = 3;
            this.lbFlagBuy.Text = "FlagBuy";
            // 
            // txtStopLoss
            // 
            this.txtStopLoss.Location = new System.Drawing.Point(146, 28);
            this.txtStopLoss.Name = "txtStopLoss";
            this.txtStopLoss.Size = new System.Drawing.Size(71, 20);
            this.txtStopLoss.TabIndex = 0;
            this.txtStopLoss.Text = "0.00000000";
            this.txtStopLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "% In";
            // 
            // lbTestChan
            // 
            this.lbTestChan.AutoSize = true;
            this.lbTestChan.Location = new System.Drawing.Point(479, 96);
            this.lbTestChan.Name = "lbTestChan";
            this.lbTestChan.Size = new System.Drawing.Size(75, 13);
            this.lbTestChan.TabIndex = 5;
            this.lbTestChan.Text = "InfoBTCGuard";
            // 
            // txtBTCGuard
            // 
            this.txtBTCGuard.Location = new System.Drawing.Point(284, 93);
            this.txtBTCGuard.Name = "txtBTCGuard";
            this.txtBTCGuard.Size = new System.Drawing.Size(29, 20);
            this.txtBTCGuard.TabIndex = 1;
            this.txtBTCGuard.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "BTC";
            // 
            // grbAdvance
            // 
            this.grbAdvance.Controls.Add(this.chkStoplossAt);
            this.grbAdvance.Controls.Add(this.chkBTCGuard);
            this.grbAdvance.Controls.Add(this.lbStoplossPresent);
            this.grbAdvance.Controls.Add(this.chkStoplossIncrease);
            this.grbAdvance.Controls.Add(this.txtMinuteOfBTC);
            this.grbAdvance.Controls.Add(this.label10);
            this.grbAdvance.Controls.Add(this.label9);
            this.grbAdvance.Controls.Add(this.label6);
            this.grbAdvance.Controls.Add(this.txtStopLoss);
            this.grbAdvance.Controls.Add(this.lbTestChan);
            this.grbAdvance.Controls.Add(this.txtBTCGuard);
            this.grbAdvance.Location = new System.Drawing.Point(28, 232);
            this.grbAdvance.Name = "grbAdvance";
            this.grbAdvance.Size = new System.Drawing.Size(647, 197);
            this.grbAdvance.TabIndex = 1;
            this.grbAdvance.TabStop = false;
            this.grbAdvance.Text = "Advance:";
            // 
            // chkStoplossAt
            // 
            this.chkStoplossAt.AutoSize = true;
            this.chkStoplossAt.Location = new System.Drawing.Point(21, 30);
            this.chkStoplossAt.Name = "chkStoplossAt";
            this.chkStoplossAt.Size = new System.Drawing.Size(86, 17);
            this.chkStoplossAt.TabIndex = 14;
            this.chkStoplossAt.Text = "StopLoss At:";
            this.chkStoplossAt.UseVisualStyleBackColor = true;
            // 
            // chkBTCGuard
            // 
            this.chkBTCGuard.AutoSize = true;
            this.chkBTCGuard.Location = new System.Drawing.Point(21, 96);
            this.chkBTCGuard.Name = "chkBTCGuard";
            this.chkBTCGuard.Size = new System.Drawing.Size(260, 17);
            this.chkBTCGuard.TabIndex = 13;
            this.chkBTCGuard.Text = "BTC Guard (Stop trading when BTC up or down) :";
            this.chkBTCGuard.UseVisualStyleBackColor = true;
            // 
            // lbStoplossPresent
            // 
            this.lbStoplossPresent.AutoSize = true;
            this.lbStoplossPresent.Location = new System.Drawing.Point(281, 64);
            this.lbStoplossPresent.Name = "lbStoplossPresent";
            this.lbStoplossPresent.Size = new System.Drawing.Size(142, 13);
            this.lbStoplossPresent.TabIndex = 12;
            this.lbStoplossPresent.Text = "StoplossIncreaseFollowPrice";
            // 
            // chkStoplossIncrease
            // 
            this.chkStoplossIncrease.AutoSize = true;
            this.chkStoplossIncrease.Location = new System.Drawing.Point(21, 63);
            this.chkStoplossIncrease.Name = "chkStoplossIncrease";
            this.chkStoplossIncrease.Size = new System.Drawing.Size(173, 17);
            this.chkStoplossIncrease.TabIndex = 11;
            this.chkStoplossIncrease.Text = "Stoploss Increase Follow Price.";
            this.chkStoplossIncrease.UseVisualStyleBackColor = true;
            // 
            // txtMinuteOfBTC
            // 
            this.txtMinuteOfBTC.Location = new System.Drawing.Point(347, 93);
            this.txtMinuteOfBTC.Name = "txtMinuteOfBTC";
            this.txtMinuteOfBTC.Size = new System.Drawing.Size(38, 20);
            this.txtMinuteOfBTC.TabIndex = 2;
            this.txtMinuteOfBTC.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "BTC";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(376, 162);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(65, 13);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status: Stop";
            // 
            // grbBasic
            // 
            this.grbBasic.Controls.Add(this.llGo);
            this.grbBasic.Controls.Add(this.lbStatus);
            this.grbBasic.Controls.Add(this.label8);
            this.grbBasic.Controls.Add(this.btnStop);
            this.grbBasic.Controls.Add(this.btnRun);
            this.grbBasic.Controls.Add(this.label7);
            this.grbBasic.Controls.Add(this.lbFlagBuy);
            this.grbBasic.Controls.Add(this.lbLast);
            this.grbBasic.Controls.Add(this.label4);
            this.grbBasic.Controls.Add(this.label3);
            this.grbBasic.Controls.Add(this.label2);
            this.grbBasic.Controls.Add(this.label1);
            this.grbBasic.Controls.Add(this.txtWaitingSellPrice);
            this.grbBasic.Controls.Add(this.txtWaitingBuyPrice);
            this.grbBasic.Controls.Add(this.txtQuantity);
            this.grbBasic.Controls.Add(this.txtCoinName);
            this.grbBasic.Location = new System.Drawing.Point(28, 15);
            this.grbBasic.Name = "grbBasic";
            this.grbBasic.Size = new System.Drawing.Size(647, 198);
            this.grbBasic.TabIndex = 0;
            this.grbBasic.TabStop = false;
            this.grbBasic.Text = "Basic:";
            // 
            // llGo
            // 
            this.llGo.AutoSize = true;
            this.llGo.Location = new System.Drawing.Point(557, 22);
            this.llGo.Name = "llGo";
            this.llGo.Size = new System.Drawing.Size(66, 13);
            this.llGo.TabIndex = 13;
            this.llGo.TabStop = true;
            this.llGo.Text = "Go To Bitrex";
            this.llGo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGo_LinkClicked);
            // 
            // FrmTrader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 441);
            this.Controls.Add(this.grbBasic);
            this.Controls.Add(this.grbAdvance);
            this.Name = "FrmTrader";
            this.Text = "frmTrader";
            this.Load += new System.EventHandler(this.frmTrader_Load);
            this.grbAdvance.ResumeLayout(false);
            this.grbAdvance.PerformLayout();
            this.grbBasic.ResumeLayout(false);
            this.grbBasic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoinName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtWaitingBuyPrice;
        private System.Windows.Forms.TextBox txtWaitingSellPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbLast;
        private System.Windows.Forms.Label lbFlagBuy;
        private System.Windows.Forms.TextBox txtStopLoss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTestChan;
        private System.Windows.Forms.TextBox txtBTCGuard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbAdvance;
        private System.Windows.Forms.CheckBox chkStoplossIncrease;
        private System.Windows.Forms.TextBox txtMinuteOfBTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkStoplossAt;
        private System.Windows.Forms.CheckBox chkBTCGuard;
        private System.Windows.Forms.Label lbStoplossPresent;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.GroupBox grbBasic;
        private System.Windows.Forms.LinkLabel llGo;
    }
}