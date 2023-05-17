namespace Slownik
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
			this.number = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.yearLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numer";
			// 
			// number
			// 
			this.number.FormattingEnabled = true;
			this.number.Location = new System.Drawing.Point(76, 30);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(57, 21);
			this.number.TabIndex = 1;
			this.number.SelectedIndexChanged += new System.EventHandler(this.number_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(139, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "należał do gracza ";
			// 
			// nameLabel
			// 
			this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.nameLabel.Location = new System.Drawing.Point(240, 29);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 20);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "label3";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(346, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = ", który zakończył karierę w ";
			// 
			// yearLabel
			// 
			this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.yearLabel.Location = new System.Drawing.Point(489, 29);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(100, 20);
			this.yearLabel.TabIndex = 6;
			this.yearLabel.Text = "label5";
			this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(607, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "roku.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 75);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.yearLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.number);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox number;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Label label6;
	}
}

