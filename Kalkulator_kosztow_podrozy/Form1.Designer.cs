namespace Kalkulator_kosztow_podrozy
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
			this.LblStart = new System.Windows.Forms.Label();
			this.LblFinish = new System.Windows.Forms.Label();
			this.EdtStart = new System.Windows.Forms.NumericUpDown();
			this.EdtFinish = new System.Windows.Forms.NumericUpDown();
			this.LblCash = new System.Windows.Forms.Label();
			this.LblCashValue = new System.Windows.Forms.Label();
			this.BtnCalculate = new System.Windows.Forms.Button();
			this.LblDistance = new System.Windows.Forms.Label();
			this.LblDistanceValue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.EdtStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EdtFinish)).BeginInit();
			this.SuspendLayout();
			// 
			// LblStart
			// 
			this.LblStart.AutoSize = true;
			this.LblStart.Location = new System.Drawing.Point(13, 24);
			this.LblStart.Name = "LblStart";
			this.LblStart.Size = new System.Drawing.Size(129, 13);
			this.LblStart.TabIndex = 0;
			this.LblStart.Text = "Początkowy stan licznika:";
			// 
			// LblFinish
			// 
			this.LblFinish.AutoSize = true;
			this.LblFinish.Location = new System.Drawing.Point(27, 57);
			this.LblFinish.Name = "LblFinish";
			this.LblFinish.Size = new System.Drawing.Size(115, 13);
			this.LblFinish.TabIndex = 1;
			this.LblFinish.Text = "Końcowy stan licznika:";
			// 
			// EdtStart
			// 
			this.EdtStart.Location = new System.Drawing.Point(148, 22);
			this.EdtStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.EdtStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.EdtStart.Name = "EdtStart";
			this.EdtStart.Size = new System.Drawing.Size(120, 20);
			this.EdtStart.TabIndex = 2;
			this.EdtStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// EdtFinish
			// 
			this.EdtFinish.Location = new System.Drawing.Point(148, 55);
			this.EdtFinish.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.EdtFinish.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.EdtFinish.Name = "EdtFinish";
			this.EdtFinish.Size = new System.Drawing.Size(120, 20);
			this.EdtFinish.TabIndex = 3;
			this.EdtFinish.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// LblCash
			// 
			this.LblCash.AutoSize = true;
			this.LblCash.Location = new System.Drawing.Point(37, 121);
			this.LblCash.Name = "LblCash";
			this.LblCash.Size = new System.Drawing.Size(105, 13);
			this.LblCash.TabIndex = 4;
			this.LblCash.Text = "Pieniądze do zwrotu:";
			// 
			// LblCashValue
			// 
			this.LblCashValue.AutoSize = true;
			this.LblCashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LblCashValue.Location = new System.Drawing.Point(144, 116);
			this.LblCashValue.Name = "LblCashValue";
			this.LblCashValue.Size = new System.Drawing.Size(19, 20);
			this.LblCashValue.TabIndex = 5;
			this.LblCashValue.Text = "0";
			// 
			// BtnCalculate
			// 
			this.BtnCalculate.Location = new System.Drawing.Point(111, 157);
			this.BtnCalculate.Name = "BtnCalculate";
			this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
			this.BtnCalculate.TabIndex = 6;
			this.BtnCalculate.Text = "Oblicz";
			this.BtnCalculate.UseVisualStyleBackColor = true;
			this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// LblDistance
			// 
			this.LblDistance.AutoSize = true;
			this.LblDistance.Location = new System.Drawing.Point(29, 94);
			this.LblDistance.Name = "LblDistance";
			this.LblDistance.Size = new System.Drawing.Size(113, 13);
			this.LblDistance.TabIndex = 7;
			this.LblDistance.Text = "Przejechane kilometry:";
			// 
			// LblDistanceValue
			// 
			this.LblDistanceValue.AutoSize = true;
			this.LblDistanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LblDistanceValue.Location = new System.Drawing.Point(144, 89);
			this.LblDistanceValue.Name = "LblDistanceValue";
			this.LblDistanceValue.Size = new System.Drawing.Size(19, 20);
			this.LblDistanceValue.TabIndex = 8;
			this.LblDistanceValue.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 196);
			this.Controls.Add(this.LblDistanceValue);
			this.Controls.Add(this.LblDistance);
			this.Controls.Add(this.BtnCalculate);
			this.Controls.Add(this.LblCashValue);
			this.Controls.Add(this.LblCash);
			this.Controls.Add(this.EdtFinish);
			this.Controls.Add(this.EdtStart);
			this.Controls.Add(this.LblFinish);
			this.Controls.Add(this.LblStart);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.EdtStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EdtFinish)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblStart;
		private System.Windows.Forms.Label LblFinish;
		private System.Windows.Forms.NumericUpDown EdtStart;
		private System.Windows.Forms.NumericUpDown EdtFinish;
		private System.Windows.Forms.Label LblCash;
		private System.Windows.Forms.Label LblCashValue;
		private System.Windows.Forms.Button BtnCalculate;
		private System.Windows.Forms.Label LblDistance;
		private System.Windows.Forms.Label LblDistanceValue;
	}
}

