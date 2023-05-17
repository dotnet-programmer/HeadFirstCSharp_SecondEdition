namespace Zabawa_instrukcjami_if_else
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
			this.BtnChangeColor = new System.Windows.Forms.Button();
			this.CbxChangeColor = new System.Windows.Forms.CheckBox();
			this.LText1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnChangeColor
			// 
			this.BtnChangeColor.Location = new System.Drawing.Point(45, 15);
			this.BtnChangeColor.Name = "BtnChangeColor";
			this.BtnChangeColor.Size = new System.Drawing.Size(128, 35);
			this.BtnChangeColor.TabIndex = 0;
			this.BtnChangeColor.Text = "Zmień kolor, jeżeli pole jest zaznaczone";
			this.BtnChangeColor.UseVisualStyleBackColor = true;
			this.BtnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
			// 
			// CbxChangeColor
			// 
			this.CbxChangeColor.AutoSize = true;
			this.CbxChangeColor.Location = new System.Drawing.Point(180, 25);
			this.CbxChangeColor.Name = "CbxChangeColor";
			this.CbxChangeColor.Size = new System.Drawing.Size(132, 17);
			this.CbxChangeColor.TabIndex = 1;
			this.CbxChangeColor.Text = "Możliwa zmiana koloru";
			this.CbxChangeColor.UseVisualStyleBackColor = true;
			// 
			// LText1
			// 
			this.LText1.AutoSize = true;
			this.LText1.BackColor = System.Drawing.Color.Red;
			this.LText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LText1.Location = new System.Drawing.Point(12, 59);
			this.LText1.Name = "LText1";
			this.LText1.Size = new System.Drawing.Size(320, 20);
			this.LText1.TabIndex = 2;
			this.LText1.Text = "Naciśnij przycisk, aby zmienić mój kolor";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 95);
			this.Controls.Add(this.LText1);
			this.Controls.Add(this.CbxChangeColor);
			this.Controls.Add(this.BtnChangeColor);
			this.Name = "Form1";
			this.Text = "Zabawa z instrukcjami if/else";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnChangeColor;
		private System.Windows.Forms.CheckBox CbxChangeColor;
		private System.Windows.Forms.Label LText1;
	}
}

