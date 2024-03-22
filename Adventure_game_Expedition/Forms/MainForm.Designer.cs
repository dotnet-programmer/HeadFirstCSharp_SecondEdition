namespace Adventure_game_Expedition
{
	partial class MainForm
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
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnNewGame = new System.Windows.Forms.Button();
			this.BtnStats = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnExit
			// 
			this.BtnExit.BackColor = System.Drawing.Color.Transparent;
			this.BtnExit.Location = new System.Drawing.Point(417, 392);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(75, 23);
			this.BtnExit.TabIndex = 1;
			this.BtnExit.Text = "Wyjdź";
			this.BtnExit.UseVisualStyleBackColor = false;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnNewGame
			// 
			this.BtnNewGame.BackColor = System.Drawing.Color.Transparent;
			this.BtnNewGame.Location = new System.Drawing.Point(182, 392);
			this.BtnNewGame.Name = "BtnNewGame";
			this.BtnNewGame.Size = new System.Drawing.Size(75, 23);
			this.BtnNewGame.TabIndex = 0;
			this.BtnNewGame.Text = "Nowa gra";
			this.BtnNewGame.UseVisualStyleBackColor = false;
			this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
			// 
			// BtnStats
			// 
			this.BtnStats.BackColor = System.Drawing.Color.Transparent;
			this.BtnStats.Location = new System.Drawing.Point(300, 392);
			this.BtnStats.Name = "BtnStats";
			this.BtnStats.Size = new System.Drawing.Size(75, 23);
			this.BtnStats.TabIndex = 2;
			this.BtnStats.Text = "Statystyki";
			this.BtnStats.UseVisualStyleBackColor = false;
			this.BtnStats.Click += new System.EventHandler(this.BtnStats_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Adventure_game_Expedition.Properties.Resources.mainMenu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(678, 450);
			this.Controls.Add(this.BtnStats);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnNewGame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wyprawa";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnNewGame;
		private System.Windows.Forms.Button BtnStats;
	}
}