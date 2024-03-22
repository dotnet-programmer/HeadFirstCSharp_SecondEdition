namespace Borrowing_money_2
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
			this.TxtJoe = new System.Windows.Forms.Label();
			this.TxtBob = new System.Windows.Forms.Label();
			this.TxtBank = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.BtnSaveJoe = new System.Windows.Forms.Button();
			this.BtnLoadJoe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtJoe
			// 
			this.TxtJoe.AutoSize = true;
			this.TxtJoe.Location = new System.Drawing.Point(83, 25);
			this.TxtJoe.Name = "TxtJoe";
			this.TxtJoe.Size = new System.Drawing.Size(24, 13);
			this.TxtJoe.TabIndex = 0;
			this.TxtJoe.Text = "txt1";
			// 
			// TxtBob
			// 
			this.TxtBob.AutoSize = true;
			this.TxtBob.Location = new System.Drawing.Point(81, 67);
			this.TxtBob.Name = "TxtBob";
			this.TxtBob.Size = new System.Drawing.Size(24, 13);
			this.TxtBob.TabIndex = 1;
			this.TxtBob.Text = "txt2";
			// 
			// TxtBank
			// 
			this.TxtBank.AutoSize = true;
			this.TxtBank.Location = new System.Drawing.Point(81, 104);
			this.TxtBank.Name = "TxtBank";
			this.TxtBank.Size = new System.Drawing.Size(24, 13);
			this.TxtBank.TabIndex = 4;
			this.TxtBank.Text = "txt3";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 40);
			this.button1.TabIndex = 6;
			this.button1.Text = "Daj 10 zł Joemu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(130, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 40);
			this.button2.TabIndex = 7;
			this.button2.Text = "Weź 5 zł od Boba";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(25, 189);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 40);
			this.button3.TabIndex = 8;
			this.button3.Text = "Joe daje 10 zł Bobowi";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(130, 189);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(71, 40);
			this.button4.TabIndex = 9;
			this.button4.Text = "Bob daje 5 zł Joemu";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// BtnSaveJoe
			// 
			this.BtnSaveJoe.Location = new System.Drawing.Point(25, 235);
			this.BtnSaveJoe.Name = "BtnSaveJoe";
			this.BtnSaveJoe.Size = new System.Drawing.Size(71, 36);
			this.BtnSaveJoe.TabIndex = 10;
			this.BtnSaveJoe.Text = "Zapisz Joego";
			this.BtnSaveJoe.UseVisualStyleBackColor = true;
			this.BtnSaveJoe.Click += new System.EventHandler(this.BtnSaveJoe_Click);
			// 
			// BtnLoadJoe
			// 
			this.BtnLoadJoe.Location = new System.Drawing.Point(130, 235);
			this.BtnLoadJoe.Name = "BtnLoadJoe";
			this.BtnLoadJoe.Size = new System.Drawing.Size(71, 36);
			this.BtnLoadJoe.TabIndex = 11;
			this.BtnLoadJoe.Text = "Wczytaj Joego";
			this.BtnLoadJoe.UseVisualStyleBackColor = true;
			this.BtnLoadJoe.Click += new System.EventHandler(this.BtnLoadJoe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 293);
			this.Controls.Add(this.BtnLoadJoe);
			this.Controls.Add(this.BtnSaveJoe);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TxtBank);
			this.Controls.Add(this.TxtBob);
			this.Controls.Add(this.TxtJoe);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TxtJoe;
		private System.Windows.Forms.Label TxtBob;
		private System.Windows.Forms.Label TxtBank;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button BtnSaveJoe;
		private System.Windows.Forms.Button BtnLoadJoe;
	}
}

