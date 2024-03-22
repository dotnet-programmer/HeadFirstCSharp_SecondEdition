namespace Letter_game
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.CorrectLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 108;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.MultiColumn = true;
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(856, 131);
			this.listBox1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 800;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CorrectLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.difficultyLabel,
            this.difficultyProgressBar});
			this.statusStrip1.Location = new System.Drawing.Point(0, 109);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(856, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// CorrectLabel
			// 
			this.CorrectLabel.Name = "CorrectLabel";
			this.CorrectLabel.Size = new System.Drawing.Size(93, 17);
			this.CorrectLabel.Text = "Prawidłowych: 0";
			// 
			// missedLabel
			// 
			this.missedLabel.Name = "missedLabel";
			this.missedLabel.Size = new System.Drawing.Size(58, 17);
			this.missedLabel.Text = "Błędów: 0";
			// 
			// totalLabel
			// 
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(77, 17);
			this.totalLabel.Text = "Wszystkich: 0";
			// 
			// accuracyLabel
			// 
			this.accuracyLabel.Name = "accuracyLabel";
			this.accuracyLabel.Size = new System.Drawing.Size(91, 17);
			this.accuracyLabel.Text = "Dokładność: 0%";
			// 
			// difficultyLabel
			// 
			this.difficultyLabel.Name = "difficultyLabel";
			this.difficultyLabel.Size = new System.Drawing.Size(420, 17);
			this.difficultyLabel.Spring = true;
			this.difficultyLabel.Text = "Poziom trudności";
			this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// difficultyProgressBar
			// 
			this.difficultyProgressBar.Maximum = 701;
			this.difficultyProgressBar.Name = "difficultyProgressBar";
			this.difficultyProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 131);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.listBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel CorrectLabel;
		private System.Windows.Forms.ToolStripStatusLabel missedLabel;
		private System.Windows.Forms.ToolStripStatusLabel totalLabel;
		private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
		private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;
		private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
	}
}

