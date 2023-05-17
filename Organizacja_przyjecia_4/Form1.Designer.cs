namespace Organizacja_przyjecia_4
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.LbTotalCost = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ChHealthyOption = new System.Windows.Forms.CheckBox();
			this.ChDecoration = new System.Windows.Forms.CheckBox();
			this.NmNumberOfPeople = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.TxtCakeWriting = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.LbTotalCostBth = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ChDecorationBth = new System.Windows.Forms.CheckBox();
			this.NmNumberOfPeopleBth = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeople)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeopleBth)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(284, 175);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.LbTotalCost);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.ChHealthyOption);
			this.tabPage1.Controls.Add(this.ChDecoration);
			this.tabPage1.Controls.Add(this.NmNumberOfPeople);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(276, 149);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Impreza okolicznościowa";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// LbTotalCost
			// 
			this.LbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LbTotalCost.Location = new System.Drawing.Point(92, 95);
			this.LbTotalCost.Name = "LbTotalCost";
			this.LbTotalCost.Size = new System.Drawing.Size(100, 22);
			this.LbTotalCost.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Koszt:";
			// 
			// ChHealthyOption
			// 
			this.ChHealthyOption.AutoSize = true;
			this.ChHealthyOption.Location = new System.Drawing.Point(53, 64);
			this.ChHealthyOption.Name = "ChHealthyOption";
			this.ChHealthyOption.Size = new System.Drawing.Size(91, 17);
			this.ChHealthyOption.TabIndex = 9;
			this.ChHealthyOption.Text = "Opcja zdrowa";
			this.ChHealthyOption.UseVisualStyleBackColor = true;
			this.ChHealthyOption.CheckedChanged += new System.EventHandler(this.ChHealthyOption_CheckedChanged);
			// 
			// ChDecoration
			// 
			this.ChDecoration.AutoSize = true;
			this.ChDecoration.Checked = true;
			this.ChDecoration.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChDecoration.Location = new System.Drawing.Point(53, 41);
			this.ChDecoration.Name = "ChDecoration";
			this.ChDecoration.Size = new System.Drawing.Size(126, 17);
			this.ChDecoration.TabIndex = 8;
			this.ChDecoration.Text = "Dekoracje fantazyjne";
			this.ChDecoration.UseVisualStyleBackColor = true;
			this.ChDecoration.CheckedChanged += new System.EventHandler(this.ChDecoration_CheckedChanged);
			// 
			// NmNumberOfPeople
			// 
			this.NmNumberOfPeople.Location = new System.Drawing.Point(112, 15);
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
			this.NmNumberOfPeople.TabIndex = 7;
			this.NmNumberOfPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NmNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.NmNumberOfPeople.ValueChanged += new System.EventHandler(this.NmNumberOfPeople_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ilość ludzi:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.TxtCakeWriting);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.LbTotalCostBth);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.ChDecorationBth);
			this.tabPage2.Controls.Add(this.NmNumberOfPeopleBth);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(276, 149);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Przyjęcie urodzinowe";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// TxtCakeWriting
			// 
			this.TxtCakeWriting.Location = new System.Drawing.Point(122, 70);
			this.TxtCakeWriting.Name = "TxtCakeWriting";
			this.TxtCakeWriting.Size = new System.Drawing.Size(100, 20);
			this.TxtCakeWriting.TabIndex = 19;
			this.TxtCakeWriting.Text = "Sto lat!";
			this.TxtCakeWriting.TextChanged += new System.EventHandler(this.TxtCakeWriting_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Napis na torcie:";
			// 
			// LbTotalCostBth
			// 
			this.LbTotalCostBth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LbTotalCostBth.Location = new System.Drawing.Point(122, 101);
			this.LbTotalCostBth.Name = "LbTotalCostBth";
			this.LbTotalCostBth.Size = new System.Drawing.Size(100, 22);
			this.LbTotalCostBth.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(80, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Koszt:";
			// 
			// ChDecorationBth
			// 
			this.ChDecorationBth.AutoSize = true;
			this.ChDecorationBth.Checked = true;
			this.ChDecorationBth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChDecorationBth.Location = new System.Drawing.Point(63, 44);
			this.ChDecorationBth.Name = "ChDecorationBth";
			this.ChDecorationBth.Size = new System.Drawing.Size(126, 17);
			this.ChDecorationBth.TabIndex = 14;
			this.ChDecorationBth.Text = "Dekoracje fantazyjne";
			this.ChDecorationBth.UseVisualStyleBackColor = true;
			this.ChDecorationBth.CheckedChanged += new System.EventHandler(this.ChDecorationBth_CheckedChanged);
			// 
			// NmNumberOfPeopleBth
			// 
			this.NmNumberOfPeopleBth.Location = new System.Drawing.Point(122, 18);
			this.NmNumberOfPeopleBth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NmNumberOfPeopleBth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NmNumberOfPeopleBth.Name = "NmNumberOfPeopleBth";
			this.NmNumberOfPeopleBth.Size = new System.Drawing.Size(52, 20);
			this.NmNumberOfPeopleBth.TabIndex = 13;
			this.NmNumberOfPeopleBth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.NmNumberOfPeopleBth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.NmNumberOfPeopleBth.ValueChanged += new System.EventHandler(this.NmNumberOfPeopleBth_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Ilość ludzi:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 175);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeople)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NmNumberOfPeopleBth)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label LbTotalCost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox ChHealthyOption;
		private System.Windows.Forms.CheckBox ChDecoration;
		private System.Windows.Forms.NumericUpDown NmNumberOfPeople;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox TxtCakeWriting;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label LbTotalCostBth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ChDecorationBth;
		private System.Windows.Forms.NumericUpDown NmNumberOfPeopleBth;
		private System.Windows.Forms.Label label5;
	}
}

