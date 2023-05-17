namespace Zarzadzanie_wymowkami
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtExcuse = new System.Windows.Forms.TextBox();
			this.TxtEffect = new System.Windows.Forms.TextBox();
			this.DateLastUse = new System.Windows.Forms.DateTimePicker();
			this.TxtFileDate = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnRandomExcuse = new System.Windows.Forms.Button();
			this.BtnOpen = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.BtnDirectory = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.TxtExcuse, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TxtEffect, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.DateLastUse, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxtFileDate, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 123);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wymówka";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Wyniki";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ostatnie użycie";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Data pliku";
			// 
			// TxtExcuse
			// 
			this.TxtExcuse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtExcuse.Location = new System.Drawing.Point(115, 3);
			this.TxtExcuse.Name = "TxtExcuse";
			this.TxtExcuse.Size = new System.Drawing.Size(256, 20);
			this.TxtExcuse.TabIndex = 4;
			this.TxtExcuse.TextChanged += new System.EventHandler(this.TxtExcuse_TextChanged);
			// 
			// TxtEffect
			// 
			this.TxtEffect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtEffect.Location = new System.Drawing.Point(115, 33);
			this.TxtEffect.Name = "TxtEffect";
			this.TxtEffect.Size = new System.Drawing.Size(256, 20);
			this.TxtEffect.TabIndex = 5;
			this.TxtEffect.TextChanged += new System.EventHandler(this.TxtEffect_TextChanged);
			// 
			// DateLastUse
			// 
			this.DateLastUse.CustomFormat = "";
			this.DateLastUse.Location = new System.Drawing.Point(115, 63);
			this.DateLastUse.Name = "DateLastUse";
			this.DateLastUse.Size = new System.Drawing.Size(199, 20);
			this.DateLastUse.TabIndex = 6;
			this.DateLastUse.ValueChanged += new System.EventHandler(this.DateLastUse_ValueChanged);
			// 
			// TxtFileDate
			// 
			this.TxtFileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TxtFileDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.TxtFileDate.Enabled = false;
			this.TxtFileDate.Location = new System.Drawing.Point(115, 90);
			this.TxtFileDate.Name = "TxtFileDate";
			this.TxtFileDate.Size = new System.Drawing.Size(256, 23);
			this.TxtFileDate.TabIndex = 7;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Controls.Add(this.BtnRandomExcuse, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.BtnOpen, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.BtnSave, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.BtnDirectory, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 141);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 30);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// BtnRandomExcuse
			// 
			this.BtnRandomExcuse.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnRandomExcuse.Enabled = false;
			this.BtnRandomExcuse.Location = new System.Drawing.Point(225, 3);
			this.BtnRandomExcuse.Name = "BtnRandomExcuse";
			this.BtnRandomExcuse.Size = new System.Drawing.Size(146, 23);
			this.BtnRandomExcuse.TabIndex = 3;
			this.BtnRandomExcuse.Text = "Losowa wymówka";
			this.BtnRandomExcuse.UseVisualStyleBackColor = true;
			this.BtnRandomExcuse.Click += new System.EventHandler(this.BtnRandomExcuse_Click);
			// 
			// BtnOpen
			// 
			this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnOpen.Enabled = false;
			this.BtnOpen.Location = new System.Drawing.Point(151, 3);
			this.BtnOpen.Name = "BtnOpen";
			this.BtnOpen.Size = new System.Drawing.Size(68, 23);
			this.BtnOpen.TabIndex = 2;
			this.BtnOpen.Text = "Otwórz";
			this.BtnOpen.UseVisualStyleBackColor = true;
			this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnSave.Enabled = false;
			this.BtnSave.Location = new System.Drawing.Point(77, 3);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(68, 23);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Zapisz";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// BtnDirectory
			// 
			this.BtnDirectory.Dock = System.Windows.Forms.DockStyle.Top;
			this.BtnDirectory.Location = new System.Drawing.Point(3, 3);
			this.BtnDirectory.Name = "BtnDirectory";
			this.BtnDirectory.Size = new System.Drawing.Size(68, 23);
			this.BtnDirectory.TabIndex = 0;
			this.BtnDirectory.Text = "Folder";
			this.BtnDirectory.UseVisualStyleBackColor = true;
			this.BtnDirectory.Click += new System.EventHandler(this.BtnDirectory_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 184);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Zarządzanie wymówkami";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtExcuse;
		private System.Windows.Forms.TextBox TxtEffect;
		private System.Windows.Forms.DateTimePicker DateLastUse;
		private System.Windows.Forms.Label TxtFileDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button BtnRandomExcuse;
		private System.Windows.Forms.Button BtnOpen;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Button BtnDirectory;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

