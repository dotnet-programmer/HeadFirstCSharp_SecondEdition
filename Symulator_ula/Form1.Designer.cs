namespace Symulator_ula
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.startSimulation = new System.Windows.Forms.ToolStripButton();
			this.reset = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.otwórzToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.zapiszToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.drukujToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.FrameRate = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.FramesRun = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NectarInFlowers = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.HoneyInHive = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Flowers = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Bees = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSimulation,
            this.reset,
            this.toolStripSeparator,
            this.otwórzToolStripButton,
            this.zapiszToolStripButton,
            this.drukujToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(522, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// startSimulation
			// 
			this.startSimulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.startSimulation.Image = ((System.Drawing.Image)(resources.GetObject("startSimulation.Image")));
			this.startSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.startSimulation.Name = "startSimulation";
			this.startSimulation.Size = new System.Drawing.Size(124, 22);
			this.startSimulation.Text = "Rozpocznij symulację";
			this.startSimulation.Click += new System.EventHandler(this.startSimulation_Click);
			// 
			// reset
			// 
			this.reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
			this.reset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(47, 22);
			this.reset.Text = "Restart";
			this.reset.Click += new System.EventHandler(this.reset_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// otwórzToolStripButton
			// 
			this.otwórzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.otwórzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otwórzToolStripButton.Image")));
			this.otwórzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.otwórzToolStripButton.Name = "otwórzToolStripButton";
			this.otwórzToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.otwórzToolStripButton.Text = "&Otwórz";
			this.otwórzToolStripButton.Click += new System.EventHandler(this.otwórzToolStripButton_Click);
			// 
			// zapiszToolStripButton
			// 
			this.zapiszToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zapiszToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripButton.Image")));
			this.zapiszToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zapiszToolStripButton.Name = "zapiszToolStripButton";
			this.zapiszToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.zapiszToolStripButton.Text = "&Zapisz";
			this.zapiszToolStripButton.Click += new System.EventHandler(this.zapiszToolStripButton_Click);
			// 
			// drukujToolStripButton
			// 
			this.drukujToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.drukujToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("drukujToolStripButton.Image")));
			this.drukujToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.drukujToolStripButton.Name = "drukujToolStripButton";
			this.drukujToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.drukujToolStripButton.Text = "&Drukuj";
			this.drukujToolStripButton.Click += new System.EventHandler(this.drukujToolStripButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 458);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(522, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
			this.toolStripStatusLabel1.Text = "Symulacja zatrzymana";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.FrameRate, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.FramesRun, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.NectarInFlowers, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.HoneyInHive, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Flowers, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Bees, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 170);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// FrameRate
			// 
			this.FrameRate.AutoSize = true;
			this.FrameRate.Location = new System.Drawing.Point(316, 140);
			this.FrameRate.Name = "FrameRate";
			this.FrameRate.Size = new System.Drawing.Size(59, 13);
			this.FrameRate.TabIndex = 11;
			this.FrameRate.Text = "FrameRate";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 140);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Ilość klatek na sekundę";
			// 
			// FramesRun
			// 
			this.FramesRun.AutoSize = true;
			this.FramesRun.Location = new System.Drawing.Point(316, 112);
			this.FramesRun.Name = "FramesRun";
			this.FramesRun.Size = new System.Drawing.Size(61, 13);
			this.FramesRun.TabIndex = 9;
			this.FramesRun.Text = "FramesRun";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Ilość wyświetlonych klatek";
			// 
			// NectarInFlowers
			// 
			this.NectarInFlowers.AutoSize = true;
			this.NectarInFlowers.Location = new System.Drawing.Point(316, 84);
			this.NectarInFlowers.Name = "NectarInFlowers";
			this.NectarInFlowers.Size = new System.Drawing.Size(84, 13);
			this.NectarInFlowers.TabIndex = 7;
			this.NectarInFlowers.Text = "NectarInFlowers";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Całkowita ilość nektaru na polu";
			// 
			// HoneyInHive
			// 
			this.HoneyInHive.AutoSize = true;
			this.HoneyInHive.Location = new System.Drawing.Point(316, 56);
			this.HoneyInHive.Name = "HoneyInHive";
			this.HoneyInHive.Size = new System.Drawing.Size(69, 13);
			this.HoneyInHive.TabIndex = 5;
			this.HoneyInHive.Text = "HoneyInHive";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Całkowita ilość miodu w ulu";
			// 
			// Flowers
			// 
			this.Flowers.AutoSize = true;
			this.Flowers.Location = new System.Drawing.Point(316, 28);
			this.Flowers.Name = "Flowers";
			this.Flowers.Size = new System.Drawing.Size(43, 13);
			this.Flowers.TabIndex = 3;
			this.Flowers.Text = "Flowers";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ilość kwiatów";
			// 
			// Bees
			// 
			this.Bees.AutoSize = true;
			this.Bees.Location = new System.Drawing.Point(316, 0);
			this.Bees.Name = "Bees";
			this.Bees.Size = new System.Drawing.Size(31, 13);
			this.Bees.TabIndex = 1;
			this.Bees.Text = "Bees";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ilość pszczół";
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(0, 195);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(522, 263);
			this.listBox1.TabIndex = 3;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "simulator";
			this.saveFileDialog1.FileName = "SaveFile";
			this.saveFileDialog1.Filter = "pliki symulatora|*.simulator";
			this.saveFileDialog1.Title = "Wybierz plik do zapisania bieżącej symulacji";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "simulator";
			this.openFileDialog1.Filter = "pliki symulatora|*.simulator";
			this.openFileDialog1.Title = "Wybierz plik z symulacją do odczytu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 480);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Symulator ula";
			this.Move += new System.EventHandler(this.Form1_Move);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton startSimulation;
		private System.Windows.Forms.ToolStripButton reset;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label FrameRate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label FramesRun;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label NectarInFlowers;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label HoneyInHive;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Flowers;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Bees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton otwórzToolStripButton;
		private System.Windows.Forms.ToolStripButton zapiszToolStripButton;
		private System.Windows.Forms.ToolStripButton drukujToolStripButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

