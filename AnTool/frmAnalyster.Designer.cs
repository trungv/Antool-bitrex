namespace AnTool
{
    partial class frmAnalyster
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
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeToLoop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRun = new System.Windows.Forms.Label();
            this.llViewDoc = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.txtTatMayTime = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(213, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(91, 28);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run Analyst";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(310, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Analyst";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Trader";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sniper";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TimeToLoop:";
            // 
            // txtTimeToLoop
            // 
            this.txtTimeToLoop.Location = new System.Drawing.Point(103, 20);
            this.txtTimeToLoop.Name = "txtTimeToLoop";
            this.txtTimeToLoop.Size = new System.Drawing.Size(39, 20);
            this.txtTimeToLoop.TabIndex = 5;
            this.txtTimeToLoop.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // lbRun
            // 
            this.lbRun.AutoSize = true;
            this.lbRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRun.Location = new System.Drawing.Point(27, 51);
            this.lbRun.Name = "lbRun";
            this.lbRun.Size = new System.Drawing.Size(79, 16);
            this.lbRun.TabIndex = 4;
            this.lbRun.Text = "Not Run:!!!";
            // 
            // llViewDoc
            // 
            this.llViewDoc.AutoSize = true;
            this.llViewDoc.Location = new System.Drawing.Point(491, 23);
            this.llViewDoc.Name = "llViewDoc";
            this.llViewDoc.Size = new System.Drawing.Size(53, 13);
            this.llViewDoc.TabIndex = 6;
            this.llViewDoc.TabStop = true;
            this.llViewDoc.Text = "View Doc";
            this.llViewDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewDoc_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Speed Trader";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Watch Maket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "Entry Book";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(151, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "Phát hiện coin đang thấp";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(494, 291);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(63, 30);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "Tắt máy";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtTatMayTime
            // 
            this.txtTatMayTime.Location = new System.Drawing.Point(449, 297);
            this.txtTatMayTime.Name = "txtTatMayTime";
            this.txtTatMayTime.Size = new System.Drawing.Size(39, 20);
            this.txtTatMayTime.TabIndex = 9;
            this.txtTatMayTime.Text = "7200";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(151, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 45);
            this.button7.TabIndex = 10;
            this.button7.Text = "Theo dõi giá BTC, Xuat xlsx, in bieu do";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(447, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 45);
            this.button8.TabIndex = 11;
            this.button8.Text = "Coin Info List";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(447, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 45);
            this.button9.TabIndex = 11;
            this.button9.Text = "Coin Info List";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(267, 94);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 45);
            this.button10.TabIndex = 12;
            this.button10.Text = "phan tich %BTC và các coin";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(267, 145);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(110, 45);
            this.button11.TabIndex = 13;
            this.button11.Text = "Truy xuat thông tin Coin, CoinCompare";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // frmAnalyster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 326);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtTatMayTime);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.llViewDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeToLoop);
            this.Controls.Add(this.lbRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Name = "frmAnalyster";
            this.Text = "frmAnalyster";
            this.Load += new System.EventHandler(this.frmAnalyster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeToLoop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRun;
        private System.Windows.Forms.LinkLabel llViewDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.TextBox txtTatMayTime;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

