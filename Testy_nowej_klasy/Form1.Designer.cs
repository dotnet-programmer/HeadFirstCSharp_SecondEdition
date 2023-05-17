namespace Testy_nowej_klasy
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
			this.LblSayIt = new System.Windows.Forms.Label();
			this.TxtSayIt = new System.Windows.Forms.TextBox();
			this.LblCount = new System.Windows.Forms.Label();
			this.TxtCount = new System.Windows.Forms.NumericUpDown();
			this.BtnSpeakToMe = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TxtCount)).BeginInit();
			this.SuspendLayout();
			// 
			// LblSayIt
			// 
			this.LblSayIt.AutoSize = true;
			this.LblSayIt.Location = new System.Drawing.Point(43, 45);
			this.LblSayIt.Name = "LblSayIt";
			this.LblSayIt.Size = new System.Drawing.Size(62, 13);
			this.LblSayIt.TabIndex = 0;
			this.LblSayIt.Text = "Powiedz to:";
			// 
			// TxtSayIt
			// 
			this.TxtSayIt.Location = new System.Drawing.Point(112, 41);
			this.TxtSayIt.Name = "TxtSayIt";
			this.TxtSayIt.Size = new System.Drawing.Size(120, 20);
			this.TxtSayIt.TabIndex = 1;
			this.TxtSayIt.Text = "Witaj!";
			// 
			// LblCount
			// 
			this.LblCount.AutoSize = true;
			this.LblCount.Location = new System.Drawing.Point(51, 75);
			this.LblCount.Name = "LblCount";
			this.LblCount.Size = new System.Drawing.Size(54, 13);
			this.LblCount.TabIndex = 2;
			this.LblCount.Text = "Ilość razy:";
			// 
			// TxtCount
			// 
			this.TxtCount.Location = new System.Drawing.Point(112, 75);
			this.TxtCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.TxtCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.TxtCount.Name = "TxtCount";
			this.TxtCount.Size = new System.Drawing.Size(120, 20);
			this.TxtCount.TabIndex = 3;
			this.TxtCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// BtnSpeakToMe
			// 
			this.BtnSpeakToMe.Location = new System.Drawing.Point(46, 110);
			this.BtnSpeakToMe.Name = "BtnSpeakToMe";
			this.BtnSpeakToMe.Size = new System.Drawing.Size(186, 23);
			this.BtnSpeakToMe.TabIndex = 4;
			this.BtnSpeakToMe.Text = "Mów do mnie!";
			this.BtnSpeakToMe.UseVisualStyleBackColor = true;
			this.BtnSpeakToMe.Click += new System.EventHandler(this.BtnSpeakToMe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 173);
			this.Controls.Add(this.BtnSpeakToMe);
			this.Controls.Add(this.TxtCount);
			this.Controls.Add(this.LblCount);
			this.Controls.Add(this.TxtSayIt);
			this.Controls.Add(this.LblSayIt);
			this.Name = "Form1";
			this.Text = "Test gadania";
			((System.ComponentModel.ISupportInitialize)(this.TxtCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblSayIt;
		private System.Windows.Forms.TextBox TxtSayIt;
		private System.Windows.Forms.Label LblCount;
		private System.Windows.Forms.NumericUpDown TxtCount;
		private System.Windows.Forms.Button BtnSpeakToMe;
	}
}

