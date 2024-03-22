namespace Lists
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
			this.LblCards1 = new System.Windows.Forms.Label();
			this.LblCards2 = new System.Windows.Forms.Label();
			this.ListCard1 = new System.Windows.Forms.ListBox();
			this.ListCard2 = new System.Windows.Forms.ListBox();
			this.BtnMoveToList2 = new System.Windows.Forms.Button();
			this.BtnMoveToList1 = new System.Windows.Forms.Button();
			this.BtnResetList1 = new System.Windows.Forms.Button();
			this.BtnShuffle1 = new System.Windows.Forms.Button();
			this.BtnShuffle2 = new System.Windows.Forms.Button();
			this.BtnResetList2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblCards1
			// 
			this.LblCards1.AutoSize = true;
			this.LblCards1.Location = new System.Drawing.Point(46, 26);
			this.LblCards1.Name = "LblCards1";
			this.LblCards1.Size = new System.Drawing.Size(93, 13);
			this.LblCards1.TabIndex = 0;
			this.LblCards1.Text = "Zestaw 1 (10 kart)";
			// 
			// LblCards2
			// 
			this.LblCards2.AutoSize = true;
			this.LblCards2.Location = new System.Drawing.Point(244, 26);
			this.LblCards2.Name = "LblCards2";
			this.LblCards2.Size = new System.Drawing.Size(93, 13);
			this.LblCards2.TabIndex = 1;
			this.LblCards2.Text = "Zestaw 2 (52 kart)";
			// 
			// ListCard1
			// 
			this.ListCard1.FormattingEnabled = true;
			this.ListCard1.Location = new System.Drawing.Point(29, 42);
			this.ListCard1.Name = "ListCard1";
			this.ListCard1.Size = new System.Drawing.Size(137, 225);
			this.ListCard1.TabIndex = 2;
			// 
			// ListCard2
			// 
			this.ListCard2.FormattingEnabled = true;
			this.ListCard2.Location = new System.Drawing.Point(224, 42);
			this.ListCard2.Name = "ListCard2";
			this.ListCard2.Size = new System.Drawing.Size(137, 225);
			this.ListCard2.TabIndex = 3;
			// 
			// BtnMoveToList2
			// 
			this.BtnMoveToList2.Location = new System.Drawing.Point(172, 114);
			this.BtnMoveToList2.Name = "BtnMoveToList2";
			this.BtnMoveToList2.Size = new System.Drawing.Size(46, 23);
			this.BtnMoveToList2.TabIndex = 4;
			this.BtnMoveToList2.Text = ">>";
			this.BtnMoveToList2.UseVisualStyleBackColor = true;
			this.BtnMoveToList2.Click += new System.EventHandler(this.BtnMoveToList2_Click);
			// 
			// BtnMoveToList1
			// 
			this.BtnMoveToList1.Location = new System.Drawing.Point(172, 143);
			this.BtnMoveToList1.Name = "BtnMoveToList1";
			this.BtnMoveToList1.Size = new System.Drawing.Size(46, 23);
			this.BtnMoveToList1.TabIndex = 5;
			this.BtnMoveToList1.Text = "<<";
			this.BtnMoveToList1.UseVisualStyleBackColor = true;
			this.BtnMoveToList1.Click += new System.EventHandler(this.BtnMoveToList1_Click);
			// 
			// BtnResetList1
			// 
			this.BtnResetList1.Location = new System.Drawing.Point(29, 282);
			this.BtnResetList1.Name = "BtnResetList1";
			this.BtnResetList1.Size = new System.Drawing.Size(137, 23);
			this.BtnResetList1.TabIndex = 6;
			this.BtnResetList1.Text = "Przywróć zestaw 1";
			this.BtnResetList1.UseVisualStyleBackColor = true;
			this.BtnResetList1.Click += new System.EventHandler(this.BtnResetList1_Click);
			// 
			// BtnShuffle1
			// 
			this.BtnShuffle1.Location = new System.Drawing.Point(29, 320);
			this.BtnShuffle1.Name = "BtnShuffle1";
			this.BtnShuffle1.Size = new System.Drawing.Size(137, 23);
			this.BtnShuffle1.TabIndex = 7;
			this.BtnShuffle1.Text = "Wymieszaj zestaw 1";
			this.BtnShuffle1.UseVisualStyleBackColor = true;
			this.BtnShuffle1.Click += new System.EventHandler(this.BtnShuffle1_Click);
			// 
			// BtnShuffle2
			// 
			this.BtnShuffle2.Location = new System.Drawing.Point(224, 320);
			this.BtnShuffle2.Name = "BtnShuffle2";
			this.BtnShuffle2.Size = new System.Drawing.Size(137, 23);
			this.BtnShuffle2.TabIndex = 9;
			this.BtnShuffle2.Text = "Wymieszaj zestaw 2";
			this.BtnShuffle2.UseVisualStyleBackColor = true;
			this.BtnShuffle2.Click += new System.EventHandler(this.BtnShuffle2_Click);
			// 
			// BtnResetList2
			// 
			this.BtnResetList2.Location = new System.Drawing.Point(224, 282);
			this.BtnResetList2.Name = "BtnResetList2";
			this.BtnResetList2.Size = new System.Drawing.Size(137, 23);
			this.BtnResetList2.TabIndex = 8;
			this.BtnResetList2.Text = "Przywróć zestaw 2";
			this.BtnResetList2.UseVisualStyleBackColor = true;
			this.BtnResetList2.Click += new System.EventHandler(this.BtnResetList2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 362);
			this.Controls.Add(this.BtnShuffle2);
			this.Controls.Add(this.BtnResetList2);
			this.Controls.Add(this.BtnShuffle1);
			this.Controls.Add(this.BtnResetList1);
			this.Controls.Add(this.BtnMoveToList1);
			this.Controls.Add(this.BtnMoveToList2);
			this.Controls.Add(this.ListCard2);
			this.Controls.Add(this.ListCard1);
			this.Controls.Add(this.LblCards2);
			this.Controls.Add(this.LblCards1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblCards1;
		private System.Windows.Forms.Label LblCards2;
		private System.Windows.Forms.ListBox ListCard1;
		private System.Windows.Forms.ListBox ListCard2;
		private System.Windows.Forms.Button BtnMoveToList2;
		private System.Windows.Forms.Button BtnMoveToList1;
		private System.Windows.Forms.Button BtnResetList1;
		private System.Windows.Forms.Button BtnShuffle1;
		private System.Windows.Forms.Button BtnShuffle2;
		private System.Windows.Forms.Button BtnResetList2;
	}
}

