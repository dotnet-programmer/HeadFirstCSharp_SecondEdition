namespace Gra_przygodowa_Wyprawa
{
	partial class ChoosePlayerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.TextPlayerName = new System.Windows.Forms.TextBox();
			this.BtnStart = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Imie:";
			// 
			// TextPlayerName
			// 
			this.TextPlayerName.Location = new System.Drawing.Point(79, 28);
			this.TextPlayerName.Name = "TextPlayerName";
			this.TextPlayerName.Size = new System.Drawing.Size(115, 20);
			this.TextPlayerName.TabIndex = 1;
			// 
			// BtnStart
			// 
			this.BtnStart.Location = new System.Drawing.Point(38, 71);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(75, 23);
			this.BtnStart.TabIndex = 2;
			this.BtnStart.Text = "Start!";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(119, 71);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 3;
			this.BtnCancel.Text = "Wróć";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 118);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnStart);
			this.Controls.Add(this.TextPlayerName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Wybór gracza";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextPlayerName;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Button BtnCancel;
	}
}