namespace Drwale_nalesniki
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
			this.NameText = new System.Windows.Forms.TextBox();
			this.AddLumberjackBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Line = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.howMany = new System.Windows.Forms.NumericUpDown();
			this.Crispy = new System.Windows.Forms.RadioButton();
			this.Soggy = new System.Windows.Forms.RadioButton();
			this.Browned = new System.Windows.Forms.RadioButton();
			this.Banana = new System.Windows.Forms.RadioButton();
			this.AddFlapjackBtn = new System.Windows.Forms.Button();
			this.NextInLine = new System.Windows.Forms.Label();
			this.NextLumberjackBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Imię drwala";
			// 
			// NameText
			// 
			this.NameText.Location = new System.Drawing.Point(78, 18);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(200, 20);
			this.NameText.TabIndex = 1;
			// 
			// AddLumberjackBtn
			// 
			this.AddLumberjackBtn.Location = new System.Drawing.Point(15, 53);
			this.AddLumberjackBtn.Name = "AddLumberjackBtn";
			this.AddLumberjackBtn.Size = new System.Drawing.Size(263, 23);
			this.AddLumberjackBtn.TabIndex = 2;
			this.AddLumberjackBtn.Text = "Dodaj drwala";
			this.AddLumberjackBtn.UseVisualStyleBackColor = true;
			this.AddLumberjackBtn.Click += new System.EventHandler(this.AddLumberjackBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kolejka do śniadania";
			// 
			// Line
			// 
			this.Line.FormattingEnabled = true;
			this.Line.Location = new System.Drawing.Point(15, 106);
			this.Line.MultiColumn = true;
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(120, 277);
			this.Line.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NextLumberjackBtn);
			this.groupBox1.Controls.Add(this.NextInLine);
			this.groupBox1.Controls.Add(this.AddFlapjackBtn);
			this.groupBox1.Controls.Add(this.Banana);
			this.groupBox1.Controls.Add(this.Browned);
			this.groupBox1.Controls.Add(this.Soggy);
			this.groupBox1.Controls.Add(this.Crispy);
			this.groupBox1.Controls.Add(this.howMany);
			this.groupBox1.Location = new System.Drawing.Point(141, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 296);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nakarm drwala";
			// 
			// howMany
			// 
			this.howMany.Location = new System.Drawing.Point(6, 19);
			this.howMany.Name = "howMany";
			this.howMany.Size = new System.Drawing.Size(120, 20);
			this.howMany.TabIndex = 0;
			// 
			// Crispy
			// 
			this.Crispy.AutoSize = true;
			this.Crispy.Location = new System.Drawing.Point(7, 46);
			this.Crispy.Name = "Crispy";
			this.Crispy.Size = new System.Drawing.Size(79, 17);
			this.Crispy.TabIndex = 1;
			this.Crispy.TabStop = true;
			this.Crispy.Text = "Chrupkiego";
			this.Crispy.UseVisualStyleBackColor = true;
			// 
			// Soggy
			// 
			this.Soggy.AutoSize = true;
			this.Soggy.Location = new System.Drawing.Point(6, 70);
			this.Soggy.Name = "Soggy";
			this.Soggy.Size = new System.Drawing.Size(79, 17);
			this.Soggy.TabIndex = 2;
			this.Soggy.TabStop = true;
			this.Soggy.Text = "Wilgotnego";
			this.Soggy.UseVisualStyleBackColor = true;
			// 
			// Browned
			// 
			this.Browned.AutoSize = true;
			this.Browned.Location = new System.Drawing.Point(6, 94);
			this.Browned.Name = "Browned";
			this.Browned.Size = new System.Drawing.Size(79, 17);
			this.Browned.TabIndex = 3;
			this.Browned.TabStop = true;
			this.Browned.Text = "Rumianego";
			this.Browned.UseVisualStyleBackColor = true;
			// 
			// Banana
			// 
			this.Banana.AutoSize = true;
			this.Banana.Location = new System.Drawing.Point(6, 117);
			this.Banana.Name = "Banana";
			this.Banana.Size = new System.Drawing.Size(88, 17);
			this.Banana.TabIndex = 4;
			this.Banana.TabStop = true;
			this.Banana.Text = "Bananowego";
			this.Banana.UseVisualStyleBackColor = true;
			// 
			// AddFlapjackBtn
			// 
			this.AddFlapjackBtn.Location = new System.Drawing.Point(6, 140);
			this.AddFlapjackBtn.Name = "AddFlapjackBtn";
			this.AddFlapjackBtn.Size = new System.Drawing.Size(120, 23);
			this.AddFlapjackBtn.TabIndex = 5;
			this.AddFlapjackBtn.Text = "Dodaj naleśniki";
			this.AddFlapjackBtn.UseVisualStyleBackColor = true;
			this.AddFlapjackBtn.Click += new System.EventHandler(this.AddFlapjackBtn_Click);
			// 
			// NextInLine
			// 
			this.NextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.NextInLine.Location = new System.Drawing.Point(6, 177);
			this.NextInLine.Name = "NextInLine";
			this.NextInLine.Size = new System.Drawing.Size(120, 54);
			this.NextInLine.TabIndex = 6;
			// 
			// NextLumberjackBtn
			// 
			this.NextLumberjackBtn.Location = new System.Drawing.Point(6, 259);
			this.NextLumberjackBtn.Name = "NextLumberjackBtn";
			this.NextLumberjackBtn.Size = new System.Drawing.Size(119, 23);
			this.NextLumberjackBtn.TabIndex = 7;
			this.NextLumberjackBtn.Text = "Następny drwal";
			this.NextLumberjackBtn.UseVisualStyleBackColor = true;
			this.NextLumberjackBtn.Click += new System.EventHandler(this.NextLumberjackBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 396);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Line);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AddLumberjackBtn);
			this.Controls.Add(this.NameText);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Śniadanie dla drwali";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameText;
		private System.Windows.Forms.Button AddLumberjackBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox Line;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button NextLumberjackBtn;
		private System.Windows.Forms.Label NextInLine;
		private System.Windows.Forms.Button AddFlapjackBtn;
		private System.Windows.Forms.RadioButton Banana;
		private System.Windows.Forms.RadioButton Browned;
		private System.Windows.Forms.RadioButton Soggy;
		private System.Windows.Forms.RadioButton Crispy;
		private System.Windows.Forms.NumericUpDown howMany;
	}
}

