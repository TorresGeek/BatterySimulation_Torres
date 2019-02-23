namespace SimulationBateriaTorres
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ProgressBar PbBattery;
		private System.Windows.Forms.TrackBar TbVolumen;
		private System.Windows.Forms.TrackBar TbBrightness;
		private System.Windows.Forms.Label LabelVolumen;
		private System.Windows.Forms.Label LabelBrightness;
		private System.Windows.Forms.Button BtnDischarge;
		private System.Windows.Forms.CheckBox CbCharger;
		private System.Windows.Forms.Label LabelTime;
		private System.Windows.Forms.Button BtnShutdown;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PbBattery = new System.Windows.Forms.ProgressBar();
			this.TbVolumen = new System.Windows.Forms.TrackBar();
			this.TbBrightness = new System.Windows.Forms.TrackBar();
			this.LabelVolumen = new System.Windows.Forms.Label();
			this.LabelBrightness = new System.Windows.Forms.Label();
			this.BtnDischarge = new System.Windows.Forms.Button();
			this.CbCharger = new System.Windows.Forms.CheckBox();
			this.LabelTime = new System.Windows.Forms.Label();
			this.BtnShutdown = new System.Windows.Forms.Button();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TbVolumen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TbBrightness)).BeginInit();
			this.SuspendLayout();
			// 
			// PbBattery
			// 
			this.PbBattery.Location = new System.Drawing.Point(13, 13);
			this.PbBattery.MarqueeAnimationSpeed = 500;
			this.PbBattery.Maximum = 1000;
			this.PbBattery.Name = "PbBattery";
			this.PbBattery.Size = new System.Drawing.Size(780, 61);
			this.PbBattery.TabIndex = 0;
			this.PbBattery.Value = 1000;
			// 
			// TbVolumen
			// 
			this.TbVolumen.Location = new System.Drawing.Point(22, 160);
			this.TbVolumen.Name = "TbVolumen";
			this.TbVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.TbVolumen.Size = new System.Drawing.Size(45, 246);
			this.TbVolumen.TabIndex = 1;
			this.TbVolumen.Scroll += new System.EventHandler(this.TbVolumenScroll);
			// 
			// TbBrightness
			// 
			this.TbBrightness.Location = new System.Drawing.Point(103, 160);
			this.TbBrightness.Name = "TbBrightness";
			this.TbBrightness.Size = new System.Drawing.Size(359, 45);
			this.TbBrightness.TabIndex = 2;
			this.TbBrightness.Scroll += new System.EventHandler(this.TbBrilloScroll);
			// 
			// LabelVolumen
			// 
			this.LabelVolumen.Location = new System.Drawing.Point(13, 418);
			this.LabelVolumen.Name = "LabelVolumen";
			this.LabelVolumen.Size = new System.Drawing.Size(23, 23);
			this.LabelVolumen.TabIndex = 3;
			this.LabelVolumen.Text = "0";
			// 
			// LabelBrightness
			// 
			this.LabelBrightness.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LabelBrightness.Location = new System.Drawing.Point(479, 160);
			this.LabelBrightness.Name = "LabelBrightness";
			this.LabelBrightness.Size = new System.Drawing.Size(100, 23);
			this.LabelBrightness.TabIndex = 4;
			this.LabelBrightness.Text = "0";
			this.LabelBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnDischarge
			// 
			this.BtnDischarge.Location = new System.Drawing.Point(103, 211);
			this.BtnDischarge.Name = "BtnDischarge";
			this.BtnDischarge.Size = new System.Drawing.Size(359, 68);
			this.BtnDischarge.TabIndex = 5;
			this.BtnDischarge.Text = "Discharge";
			this.BtnDischarge.UseVisualStyleBackColor = true;
			this.BtnDischarge.Click += new System.EventHandler(this.BtnDescargaClick);
			// 
			// CbCharger
			// 
			this.CbCharger.Location = new System.Drawing.Point(13, 449);
			this.CbCharger.Name = "CbCharger";
			this.CbCharger.Size = new System.Drawing.Size(145, 24);
			this.CbCharger.TabIndex = 6;
			this.CbCharger.Text = "plug charger";
			this.CbCharger.UseVisualStyleBackColor = true;
			this.CbCharger.CheckedChanged += new System.EventHandler(this.CbCargadorCheckedChanged);
			// 
			// LabelTime
			// 
			this.LabelTime.Location = new System.Drawing.Point(609, 449);
			this.LabelTime.Name = "LabelTime";
			this.LabelTime.Size = new System.Drawing.Size(100, 23);
			this.LabelTime.TabIndex = 7;
			this.LabelTime.Text = "-Time-";
			// 
			// BtnShutdown
			// 
			this.BtnShutdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShutdown.BackgroundImage")));
			this.BtnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnShutdown.Location = new System.Drawing.Point(718, 406);
			this.BtnShutdown.Name = "BtnShutdown";
			this.BtnShutdown.Size = new System.Drawing.Size(75, 67);
			this.BtnShutdown.TabIndex = 8;
			this.BtnShutdown.UseVisualStyleBackColor = true;
			this.BtnShutdown.Click += new System.EventHandler(this.BtnApagarClick);
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 200;
			this.Timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Speakers";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(248, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Brightness";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(566, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(227, 256);
			this.panel1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(566, 339);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Torres Velarde Alfredo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 485);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnShutdown);
			this.Controls.Add(this.LabelTime);
			this.Controls.Add(this.CbCharger);
			this.Controls.Add(this.BtnDischarge);
			this.Controls.Add(this.LabelBrightness);
			this.Controls.Add(this.LabelVolumen);
			this.Controls.Add(this.TbBrightness);
			this.Controls.Add(this.TbVolumen);
			this.Controls.Add(this.PbBattery);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(821, 524);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(821, 524);
			this.Name = "MainForm";
			this.Text = "BatterySimulation - Torres";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.TbVolumen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TbBrightness)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
		
	

