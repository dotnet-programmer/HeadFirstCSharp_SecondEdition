namespace Dom2
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
			this.description = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// description
			// 
			this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.description.Location = new System.Drawing.Point(12, 9);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(267, 150);
			this.description.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 172);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 69);
			this.panel1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 267);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.description);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Panel panel1;
	}
}

