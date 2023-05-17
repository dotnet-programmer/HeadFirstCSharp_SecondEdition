namespace Organizacja_przyjecia
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
			this.label1 = new System.Windows.Forms.Label();
			this.NmNumberOfPeople = new System.Windows.Forms.NumericUpDown();
			this.ChDecoration = new System.Windows.Forms.CheckBox();
			this.ChHealthyOption = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LbTotalCost = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeople)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ilość ludzi:";
			// 
			// NmNumberOfPeople
			// 
			this.NmNumberOfPeople.Location = new System.Drawing.Point(74, 7);
			this.NmNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NmNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NmNumberOfPeople.Name = "NmNumberOfPeople";
			this.NmNumberOfPeople.Size = new System.Drawing.Size(52, 20);
			this.NmNumberOfPeople.TabIndex = 1;
			this.NmNumberOfPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NmNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.NmNumberOfPeople.ValueChanged += new System.EventHandler(this.NmNumberOfPeople_ValueChanged);
			// 
			// ChDecoration
			// 
			this.ChDecoration.AutoSize = true;
			this.ChDecoration.Checked = true;
			this.ChDecoration.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChDecoration.Location = new System.Drawing.Point(15, 33);
			this.ChDecoration.Name = "ChDecoration";
			this.ChDecoration.Size = new System.Drawing.Size(126, 17);
			this.ChDecoration.TabIndex = 2;
			this.ChDecoration.Text = "Dekoracje fantazyjne";
			this.ChDecoration.UseVisualStyleBackColor = true;
			this.ChDecoration.CheckedChanged += new System.EventHandler(this.ChDecoration_CheckedChanged);
			// 
			// ChHealthyOption
			// 
			this.ChHealthyOption.AutoSize = true;
			this.ChHealthyOption.Location = new System.Drawing.Point(15, 56);
			this.ChHealthyOption.Name = "ChHealthyOption";
			this.ChHealthyOption.Size = new System.Drawing.Size(91, 17);
			this.ChHealthyOption.TabIndex = 3;
			this.ChHealthyOption.Text = "Opcja zdrowa";
			this.ChHealthyOption.UseVisualStyleBackColor = true;
			this.ChHealthyOption.CheckedChanged += new System.EventHandler(this.ChHealthyOption_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Koszt:";
			// 
			// LbTotalCost
			// 
			this.LbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LbTotalCost.Location = new System.Drawing.Point(54, 76);
			this.LbTotalCost.Name = "LbTotalCost";
			this.LbTotalCost.Size = new System.Drawing.Size(100, 22);
			this.LbTotalCost.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(166, 111);
			this.Controls.Add(this.LbTotalCost);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ChHealthyOption);
			this.Controls.Add(this.ChDecoration);
			this.Controls.Add(this.NmNumberOfPeople);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Planista przyjęć";
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeople)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NmNumberOfPeople;
		private System.Windows.Forms.CheckBox ChDecoration;
		private System.Windows.Forms.CheckBox ChHealthyOption;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LbTotalCost;
	}
}

