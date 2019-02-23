namespace SimulationBateriaTorres
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ProgressBar PbBateria;
		private System.Windows.Forms.TrackBar TbVolumen;
		private System.Windows.Forms.TrackBar TbBrillo;
		private System.Windows.Forms.Label LabelVolumen;
		private System.Windows.Forms.Label LabelBrillo;
		private System.Windows.Forms.Button BtnDescarga;
		private System.Windows.Forms.CheckBox CbCargador;
		private System.Windows.Forms.Label LabelHora;
		private System.Windows.Forms.Button BtnApagar;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;

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
			this.PbBateria = new System.Windows.Forms.ProgressBar();
			this.TbVolumen = new System.Windows.Forms.TrackBar();
			this.TbBrillo = new System.Windows.Forms.TrackBar();
			this.LabelVolumen = new System.Windows.Forms.Label();
			this.LabelBrillo = new System.Windows.Forms.Label();
			this.BtnDescarga = new System.Windows.Forms.Button();
			this.CbCargador = new System.Windows.Forms.CheckBox();
			this.LabelHora = new System.Windows.Forms.Label();
			this.BtnApagar = new System.Windows.Forms.Button();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TbVolumen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TbBrillo)).BeginInit();
			this.SuspendLayout();
			// 
			// PbBateria
			// 
			this.PbBateria.Location = new System.Drawing.Point(13, 13);
			this.PbBateria.MarqueeAnimationSpeed = 500;
			this.PbBateria.Maximum = 1000;
			this.PbBateria.Name = "PbBateria";
			this.PbBateria.Size = new System.Drawing.Size(780, 61);
			this.PbBateria.TabIndex = 0;
			this.PbBateria.Value = 1000;
			// 
			// TbVolumen
			// 
			this.TbVolumen.Location = new System.Drawing.Point(13, 160);
			this.TbVolumen.Name = "TbVolumen";
			this.TbVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.TbVolumen.Size = new System.Drawing.Size(45, 246);
			this.TbVolumen.TabIndex = 1;
			this.TbVolumen.Scroll += new System.EventHandler(this.TbVolumenScroll);
			// 
			// TbBrillo
			// 
			this.TbBrillo.Location = new System.Drawing.Point(103, 160);
			this.TbBrillo.Name = "TbBrillo";
			this.TbBrillo.Size = new System.Drawing.Size(359, 45);
			this.TbBrillo.TabIndex = 2;
			this.TbBrillo.Scroll += new System.EventHandler(this.TbBrilloScroll);
			// 
			// LabelVolumen
			// 
			this.LabelVolumen.Location = new System.Drawing.Point(13, 418);
			this.LabelVolumen.Name = "LabelVolumen";
			this.LabelVolumen.Size = new System.Drawing.Size(23, 23);
			this.LabelVolumen.TabIndex = 3;
			this.LabelVolumen.Text = "0";
			// 
			// LabelBrillo
			// 
			this.LabelBrillo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LabelBrillo.Location = new System.Drawing.Point(479, 160);
			this.LabelBrillo.Name = "LabelBrillo";
			this.LabelBrillo.Size = new System.Drawing.Size(100, 23);
			this.LabelBrillo.TabIndex = 4;
			this.LabelBrillo.Text = "0";
			this.LabelBrillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnDescarga
			// 
			this.BtnDescarga.Location = new System.Drawing.Point(103, 211);
			this.BtnDescarga.Name = "BtnDescarga";
			this.BtnDescarga.Size = new System.Drawing.Size(359, 68);
			this.BtnDescarga.TabIndex = 5;
			this.BtnDescarga.Text = "Descargar";
			this.BtnDescarga.UseVisualStyleBackColor = true;
			this.BtnDescarga.Click += new System.EventHandler(this.BtnDescargaClick);
			// 
			// CbCargador
			// 
			this.CbCargador.Location = new System.Drawing.Point(13, 449);
			this.CbCargador.Name = "CbCargador";
			this.CbCargador.Size = new System.Drawing.Size(145, 24);
			this.CbCargador.TabIndex = 6;
			this.CbCargador.Text = "Conectar cargador";
			this.CbCargador.UseVisualStyleBackColor = true;
			this.CbCargador.CheckedChanged += new System.EventHandler(this.CbCargadorCheckedChanged);
			// 
			// LabelHora
			// 
			this.LabelHora.Location = new System.Drawing.Point(609, 449);
			this.LabelHora.Name = "LabelHora";
			this.LabelHora.Size = new System.Drawing.Size(100, 23);
			this.LabelHora.TabIndex = 7;
			this.LabelHora.Text = "-Hora-";
			// 
			// BtnApagar
			// 
			this.BtnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnApagar.BackgroundImage")));
			this.BtnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnApagar.Location = new System.Drawing.Point(718, 406);
			this.BtnApagar.Name = "BtnApagar";
			this.BtnApagar.Size = new System.Drawing.Size(75, 67);
			this.BtnApagar.TabIndex = 8;
			this.BtnApagar.UseVisualStyleBackColor = true;
			this.BtnApagar.Click += new System.EventHandler(this.BtnApagarClick);
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
			this.label1.Size = new System.Drawing.Size(45, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Volumen";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Brillo";
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
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(566, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(227, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "171000250";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 485);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnApagar);
			this.Controls.Add(this.LabelHora);
			this.Controls.Add(this.CbCargador);
			this.Controls.Add(this.BtnDescarga);
			this.Controls.Add(this.LabelBrillo);
			this.Controls.Add(this.LabelVolumen);
			this.Controls.Add(this.TbBrillo);
			this.Controls.Add(this.TbVolumen);
			this.Controls.Add(this.PbBateria);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(821, 524);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(821, 524);
			this.Name = "MainForm";
			this.Text = "SimulacionBateriaTorres";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.TbVolumen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TbBrillo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
		
	

