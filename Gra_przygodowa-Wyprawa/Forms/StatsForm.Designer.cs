namespace Gra_przygodowa_Wyprawa
{
	partial class StatsForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LblWin = new System.Windows.Forms.Label();
			this.ValueWin = new System.Windows.Forms.Label();
			this.LblLose = new System.Windows.Forms.Label();
			this.ValueLose = new System.Windows.Forms.Label();
			this.LblKilledEnemies = new System.Windows.Forms.Label();
			this.ValueKilledEnemies = new System.Windows.Forms.Label();
			this.LblFindItems = new System.Windows.Forms.Label();
			this.ValueFindItems = new System.Windows.Forms.Label();
			this.LblDrinkPotions = new System.Windows.Forms.Label();
			this.ValueDrinkPotions = new System.Windows.Forms.Label();
			this.LblGamesCount = new System.Windows.Forms.Label();
			this.ValueGamesCount = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.ValueGamesCount, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblDrinkPotions, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.LblFindItems, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.LblKilledEnemies, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.LblLose, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ValueDrinkPotions, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.ValueFindItems, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.ValueKilledEnemies, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.ValueLose, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.ValueWin, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LblWin, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LblGamesCount, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 161);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// LblWin
			// 
			this.LblWin.AutoSize = true;
			this.LblWin.Location = new System.Drawing.Point(3, 26);
			this.LblWin.Name = "LblWin";
			this.LblWin.Size = new System.Drawing.Size(50, 13);
			this.LblWin.TabIndex = 0;
			this.LblWin.Text = "Wygrane";
			// 
			// ValueWin
			// 
			this.ValueWin.AutoSize = true;
			this.ValueWin.Location = new System.Drawing.Point(147, 26);
			this.ValueWin.Name = "ValueWin";
			this.ValueWin.Size = new System.Drawing.Size(13, 13);
			this.ValueWin.TabIndex = 1;
			this.ValueWin.Text = "0";
			// 
			// LblLose
			// 
			this.LblLose.AutoSize = true;
			this.LblLose.Location = new System.Drawing.Point(3, 52);
			this.LblLose.Name = "LblLose";
			this.LblLose.Size = new System.Drawing.Size(55, 13);
			this.LblLose.TabIndex = 2;
			this.LblLose.Text = "Przegrane";
			// 
			// ValueLose
			// 
			this.ValueLose.AutoSize = true;
			this.ValueLose.Location = new System.Drawing.Point(147, 52);
			this.ValueLose.Name = "ValueLose";
			this.ValueLose.Size = new System.Drawing.Size(13, 13);
			this.ValueLose.TabIndex = 3;
			this.ValueLose.Text = "0";
			// 
			// LblKilledEnemies
			// 
			this.LblKilledEnemies.AutoSize = true;
			this.LblKilledEnemies.Location = new System.Drawing.Point(3, 78);
			this.LblKilledEnemies.Name = "LblKilledEnemies";
			this.LblKilledEnemies.Size = new System.Drawing.Size(77, 13);
			this.LblKilledEnemies.TabIndex = 4;
			this.LblKilledEnemies.Text = "Zabite potwory";
			// 
			// ValueKilledEnemies
			// 
			this.ValueKilledEnemies.AutoSize = true;
			this.ValueKilledEnemies.Location = new System.Drawing.Point(147, 78);
			this.ValueKilledEnemies.Name = "ValueKilledEnemies";
			this.ValueKilledEnemies.Size = new System.Drawing.Size(13, 13);
			this.ValueKilledEnemies.TabIndex = 5;
			this.ValueKilledEnemies.Text = "0";
			// 
			// LblFindItems
			// 
			this.LblFindItems.AutoSize = true;
			this.LblFindItems.Location = new System.Drawing.Point(3, 104);
			this.LblFindItems.Name = "LblFindItems";
			this.LblFindItems.Size = new System.Drawing.Size(112, 13);
			this.LblFindItems.TabIndex = 6;
			this.LblFindItems.Text = "Znalezione przedmioty";
			// 
			// ValueFindItems
			// 
			this.ValueFindItems.AutoSize = true;
			this.ValueFindItems.Location = new System.Drawing.Point(147, 104);
			this.ValueFindItems.Name = "ValueFindItems";
			this.ValueFindItems.Size = new System.Drawing.Size(13, 13);
			this.ValueFindItems.TabIndex = 7;
			this.ValueFindItems.Text = "0";
			// 
			// LblDrinkPotions
			// 
			this.LblDrinkPotions.AutoSize = true;
			this.LblDrinkPotions.Location = new System.Drawing.Point(3, 130);
			this.LblDrinkPotions.Name = "LblDrinkPotions";
			this.LblDrinkPotions.Size = new System.Drawing.Size(81, 13);
			this.LblDrinkPotions.TabIndex = 8;
			this.LblDrinkPotions.Text = "Wypite mikstury";
			// 
			// ValueDrinkPotions
			// 
			this.ValueDrinkPotions.AutoSize = true;
			this.ValueDrinkPotions.Location = new System.Drawing.Point(147, 130);
			this.ValueDrinkPotions.Name = "ValueDrinkPotions";
			this.ValueDrinkPotions.Size = new System.Drawing.Size(13, 13);
			this.ValueDrinkPotions.TabIndex = 9;
			this.ValueDrinkPotions.Text = "0";
			// 
			// LblGamesCount
			// 
			this.LblGamesCount.AutoSize = true;
			this.LblGamesCount.Location = new System.Drawing.Point(3, 0);
			this.LblGamesCount.Name = "LblGamesCount";
			this.LblGamesCount.Size = new System.Drawing.Size(90, 13);
			this.LblGamesCount.TabIndex = 10;
			this.LblGamesCount.Text = "Rozegranych gier";
			// 
			// ValueGamesCount
			// 
			this.ValueGamesCount.AutoSize = true;
			this.ValueGamesCount.Location = new System.Drawing.Point(147, 0);
			this.ValueGamesCount.Name = "ValueGamesCount";
			this.ValueGamesCount.Size = new System.Drawing.Size(13, 13);
			this.ValueGamesCount.TabIndex = 11;
			this.ValueGamesCount.Text = "0";
			// 
			// StatsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 212);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StatsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Statystyki";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label ValueDrinkPotions;
		private System.Windows.Forms.Label LblDrinkPotions;
		private System.Windows.Forms.Label ValueFindItems;
		private System.Windows.Forms.Label LblFindItems;
		private System.Windows.Forms.Label ValueKilledEnemies;
		private System.Windows.Forms.Label LblKilledEnemies;
		private System.Windows.Forms.Label ValueLose;
		private System.Windows.Forms.Label LblLose;
		private System.Windows.Forms.Label ValueWin;
		private System.Windows.Forms.Label LblWin;
		private System.Windows.Forms.Label ValueGamesCount;
		private System.Windows.Forms.Label LblGamesCount;
	}
}