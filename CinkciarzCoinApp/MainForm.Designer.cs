namespace CinkciarzCoinApp
{
	partial class MainForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnApplyConfiguration = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnStopGenerate = new System.Windows.Forms.Button();
			this.btnStartGenerate = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnStopRecording = new System.Windows.Forms.Button();
			this.btnStartRecording = new System.Windows.Forms.Button();
			this.tbxAvgExchangeRate = new UserControls.ExchangeRateTextBox();
			this.tbxMaxSpread = new UserControls.ExchangeRateTextBox();
			this.tbxRefresh = new UserControls.NumericTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblBuyingRate = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblSellingRate = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblCurrentSpread = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblRefresh = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblRefresh);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.lblCurrentSpread);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lblSellingRate);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblBuyingRate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CinkciarzCoin exchange rate";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnApplyConfiguration);
			this.groupBox2.Controls.Add(this.tbxAvgExchangeRate);
			this.groupBox2.Controls.Add(this.tbxMaxSpread);
			this.groupBox2.Controls.Add(this.tbxRefresh);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(218, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(261, 128);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Configuration";
			// 
			// btnApplyConfiguration
			// 
			this.btnApplyConfiguration.Location = new System.Drawing.Point(180, 96);
			this.btnApplyConfiguration.Name = "btnApplyConfiguration";
			this.btnApplyConfiguration.Size = new System.Drawing.Size(75, 23);
			this.btnApplyConfiguration.TabIndex = 4;
			this.btnApplyConfiguration.Text = "Apply";
			this.btnApplyConfiguration.UseVisualStyleBackColor = true;
			this.btnApplyConfiguration.Click += new System.EventHandler(this.btnApplyConfiguration_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "ms";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Avg. exchange rate:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Refresh:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Max spread:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnStopGenerate);
			this.groupBox3.Controls.Add(this.btnStartGenerate);
			this.groupBox3.Location = new System.Drawing.Point(12, 146);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 56);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Generate process";
			// 
			// btnStopGenerate
			// 
			this.btnStopGenerate.Enabled = false;
			this.btnStopGenerate.Location = new System.Drawing.Point(87, 19);
			this.btnStopGenerate.Name = "btnStopGenerate";
			this.btnStopGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnStopGenerate.TabIndex = 1;
			this.btnStopGenerate.Text = "Stop";
			this.btnStopGenerate.UseVisualStyleBackColor = true;
			this.btnStopGenerate.Click += new System.EventHandler(this.btnStopGenerate_Click);
			// 
			// btnStartGenerate
			// 
			this.btnStartGenerate.Location = new System.Drawing.Point(6, 19);
			this.btnStartGenerate.Name = "btnStartGenerate";
			this.btnStartGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnStartGenerate.TabIndex = 0;
			this.btnStartGenerate.Text = "Start";
			this.btnStartGenerate.UseVisualStyleBackColor = true;
			this.btnStartGenerate.Click += new System.EventHandler(this.btnStartGenerate_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnSave);
			this.groupBox4.Controls.Add(this.btnStopRecording);
			this.groupBox4.Controls.Add(this.btnStartRecording);
			this.groupBox4.Location = new System.Drawing.Point(218, 146);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(261, 56);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Recording";
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(166, 19);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save to file";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnStopRecording
			// 
			this.btnStopRecording.Enabled = false;
			this.btnStopRecording.Location = new System.Drawing.Point(87, 19);
			this.btnStopRecording.Name = "btnStopRecording";
			this.btnStopRecording.Size = new System.Drawing.Size(75, 23);
			this.btnStopRecording.TabIndex = 2;
			this.btnStopRecording.Text = "Stop";
			this.btnStopRecording.UseVisualStyleBackColor = true;
			this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
			// 
			// btnStartRecording
			// 
			this.btnStartRecording.Enabled = false;
			this.btnStartRecording.Location = new System.Drawing.Point(6, 19);
			this.btnStartRecording.Name = "btnStartRecording";
			this.btnStartRecording.Size = new System.Drawing.Size(75, 23);
			this.btnStartRecording.TabIndex = 2;
			this.btnStartRecording.Text = "Start";
			this.btnStartRecording.UseVisualStyleBackColor = true;
			this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
			// 
			// tbxAvgExchangeRate
			// 
			this.tbxAvgExchangeRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CinkciarzCoinApp.Properties.Settings.Default, "avgExchangeRage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbxAvgExchangeRate.Location = new System.Drawing.Point(115, 70);
			this.tbxAvgExchangeRate.Name = "tbxAvgExchangeRate";
			this.tbxAvgExchangeRate.Size = new System.Drawing.Size(100, 20);
			this.tbxAvgExchangeRate.TabIndex = 9;
			this.tbxAvgExchangeRate.Text = global::CinkciarzCoinApp.Properties.Settings.Default.avgExchangeRage;
			// 
			// tbxMaxSpread
			// 
			this.tbxMaxSpread.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CinkciarzCoinApp.Properties.Settings.Default, "maxSpread", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbxMaxSpread.Location = new System.Drawing.Point(115, 18);
			this.tbxMaxSpread.Name = "tbxMaxSpread";
			this.tbxMaxSpread.Size = new System.Drawing.Size(100, 20);
			this.tbxMaxSpread.TabIndex = 8;
			this.tbxMaxSpread.Text = global::CinkciarzCoinApp.Properties.Settings.Default.maxSpread;
			// 
			// tbxRefresh
			// 
			this.tbxRefresh.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CinkciarzCoinApp.Properties.Settings.Default, "refresh", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbxRefresh.Location = new System.Drawing.Point(115, 44);
			this.tbxRefresh.Name = "tbxRefresh";
			this.tbxRefresh.Size = new System.Drawing.Size(100, 20);
			this.tbxRefresh.TabIndex = 7;
			this.tbxRefresh.Text = global::CinkciarzCoinApp.Properties.Settings.Default.refresh;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Buing rate:";
			// 
			// lblBuyingRate
			// 
			this.lblBuyingRate.AutoSize = true;
			this.lblBuyingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblBuyingRate.Location = new System.Drawing.Point(71, 21);
			this.lblBuyingRate.Name = "lblBuyingRate";
			this.lblBuyingRate.Size = new System.Drawing.Size(46, 13);
			this.lblBuyingRate.TabIndex = 1;
			this.lblBuyingRate.Text = "0,0000";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Selling rate:";
			// 
			// lblSellingRate
			// 
			this.lblSellingRate.AutoSize = true;
			this.lblSellingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblSellingRate.Location = new System.Drawing.Point(74, 44);
			this.lblSellingRate.Name = "lblSellingRate";
			this.lblSellingRate.Size = new System.Drawing.Size(46, 13);
			this.lblSellingRate.TabIndex = 3;
			this.lblSellingRate.Text = "0,0000";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Current spread:";
			// 
			// lblCurrentSpread
			// 
			this.lblCurrentSpread.AutoSize = true;
			this.lblCurrentSpread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblCurrentSpread.Location = new System.Drawing.Point(92, 70);
			this.lblCurrentSpread.Name = "lblCurrentSpread";
			this.lblCurrentSpread.Size = new System.Drawing.Size(46, 13);
			this.lblCurrentSpread.TabIndex = 5;
			this.lblCurrentSpread.Text = "0,0000";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(103, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Refresh per second:";
			// 
			// lblRefresh
			// 
			this.lblRefresh.AutoSize = true;
			this.lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblRefresh.Location = new System.Drawing.Point(116, 96);
			this.lblRefresh.Name = "lblRefresh";
			this.lblRefresh.Size = new System.Drawing.Size(14, 13);
			this.lblRefresh.TabIndex = 7;
			this.lblRefresh.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 205);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "CinkciarzCoinApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnStopGenerate;
		private System.Windows.Forms.Button btnStartGenerate;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnStopRecording;
		private System.Windows.Forms.Button btnStartRecording;
		private UserControls.NumericTextBox tbxRefresh;
		private UserControls.ExchangeRateTextBox tbxAvgExchangeRate;
		private UserControls.ExchangeRateTextBox tbxMaxSpread;
		private System.Windows.Forms.Button btnApplyConfiguration;
		private System.Windows.Forms.Label lblRefresh;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCurrentSpread;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblSellingRate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblBuyingRate;
		private System.Windows.Forms.Label label5;
	}
}

