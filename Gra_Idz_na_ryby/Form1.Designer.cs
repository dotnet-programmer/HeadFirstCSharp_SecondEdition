namespace Gra_Idz_na_ryby
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.listHand = new System.Windows.Forms.ListBox();
			this.buttonAsk = new System.Windows.Forms.Button();
			this.textProgress = new System.Windows.Forms.TextBox();
			this.textBooks = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Imię";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Postępy gry";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Grupy";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(290, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ręka";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(15, 27);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(152, 20);
			this.textName.TabIndex = 4;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(173, 25);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(100, 23);
			this.buttonStart.TabIndex = 5;
			this.buttonStart.Text = "Rozpocznij grę!";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// listHand
			// 
			this.listHand.FormattingEnabled = true;
			this.listHand.Location = new System.Drawing.Point(293, 27);
			this.listHand.Name = "listHand";
			this.listHand.Size = new System.Drawing.Size(133, 342);
			this.listHand.TabIndex = 6;
			// 
			// buttonAsk
			// 
			this.buttonAsk.Enabled = false;
			this.buttonAsk.Location = new System.Drawing.Point(293, 377);
			this.buttonAsk.Name = "buttonAsk";
			this.buttonAsk.Size = new System.Drawing.Size(133, 23);
			this.buttonAsk.TabIndex = 7;
			this.buttonAsk.Text = "Zażądaj karty";
			this.buttonAsk.UseVisualStyleBackColor = true;
			this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
			// 
			// textProgress
			// 
			this.textProgress.Location = new System.Drawing.Point(15, 72);
			this.textProgress.Multiline = true;
			this.textProgress.Name = "textProgress";
			this.textProgress.ReadOnly = true;
			this.textProgress.Size = new System.Drawing.Size(258, 180);
			this.textProgress.TabIndex = 8;
			// 
			// textBooks
			// 
			this.textBooks.Location = new System.Drawing.Point(15, 283);
			this.textBooks.Multiline = true;
			this.textBooks.Name = "textBooks";
			this.textBooks.ReadOnly = true;
			this.textBooks.Size = new System.Drawing.Size(257, 117);
			this.textBooks.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 421);
			this.Controls.Add(this.textBooks);
			this.Controls.Add(this.textProgress);
			this.Controls.Add(this.buttonAsk);
			this.Controls.Add(this.listHand);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Idź na ryby!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.ListBox listHand;
		private System.Windows.Forms.Button buttonAsk;
		private System.Windows.Forms.TextBox textProgress;
		private System.Windows.Forms.TextBox textBooks;
	}
}

