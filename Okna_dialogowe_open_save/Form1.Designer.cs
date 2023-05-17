namespace Okna_dialogowe_open_save
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnOpen = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BtnSave);
			this.panel1.Controls.Add(this.BtnOpen);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 406);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 44);
			this.panel1.TabIndex = 0;
			// 
			// BtnOpen
			// 
			this.BtnOpen.Location = new System.Drawing.Point(12, 9);
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.Size = new System.Drawing.Size(75, 23);
			this.BtnOpen.TabIndex = 0;
			this.BtnOpen.Text = "Otwórz";
			this.BtnOpen.UseVisualStyleBackColor = true;
			this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(474, 9);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Zapisz";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(561, 406);
			this.textBox1.TabIndex = 1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "cs";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "pliki C#|*.cs|Wszystkie pliki|*.*";
			this.openFileDialog1.InitialDirectory = "E:\\Informatyka\\C#";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Prosty edytor plików";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnOpen;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

