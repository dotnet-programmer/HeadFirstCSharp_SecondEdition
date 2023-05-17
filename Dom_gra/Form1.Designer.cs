namespace Dom_gra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.goThroughTheDoor = new System.Windows.Forms.Button();
			this.goHere = new System.Windows.Forms.Button();
			this.exits = new System.Windows.Forms.ComboBox();
			this.description = new System.Windows.Forms.TextBox();
			this.check = new System.Windows.Forms.Button();
			this.hide = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picture = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// goThroughTheDoor
			// 
			this.goThroughTheDoor.Location = new System.Drawing.Point(317, 136);
			this.goThroughTheDoor.Name = "goThroughTheDoor";
			this.goThroughTheDoor.Size = new System.Drawing.Size(206, 23);
			this.goThroughTheDoor.TabIndex = 7;
			this.goThroughTheDoor.Text = "Przejdź przez drzwi";
			this.goThroughTheDoor.UseVisualStyleBackColor = true;
			this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
			// 
			// goHere
			// 
			this.goHere.Location = new System.Drawing.Point(30, 135);
			this.goHere.Name = "goHere";
			this.goHere.Size = new System.Drawing.Size(75, 23);
			this.goHere.TabIndex = 6;
			this.goHere.Text = "Idź tutaj:";
			this.goHere.UseVisualStyleBackColor = true;
			this.goHere.Click += new System.EventHandler(this.goHere_Click);
			// 
			// exits
			// 
			this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.exits.FormattingEnabled = true;
			this.exits.Location = new System.Drawing.Point(111, 136);
			this.exits.Name = "exits";
			this.exits.Size = new System.Drawing.Size(197, 21);
			this.exits.TabIndex = 5;
			// 
			// description
			// 
			this.description.Location = new System.Drawing.Point(30, 15);
			this.description.Multiline = true;
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(742, 103);
			this.description.TabIndex = 4;
			// 
			// check
			// 
			this.check.Location = new System.Drawing.Point(529, 136);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(243, 23);
			this.check.TabIndex = 8;
			this.check.Text = "----";
			this.check.UseVisualStyleBackColor = true;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// hide
			// 
			this.hide.Location = new System.Drawing.Point(171, 165);
			this.hide.Name = "hide";
			this.hide.Size = new System.Drawing.Size(479, 22);
			this.hide.TabIndex = 9;
			this.hide.Text = "Kryj się!";
			this.hide.UseVisualStyleBackColor = true;
			this.hide.Click += new System.EventHandler(this.hide_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.hide);
			this.panel1.Controls.Add(this.description);
			this.panel1.Controls.Add(this.exits);
			this.panel1.Controls.Add(this.goHere);
			this.panel1.Controls.Add(this.check);
			this.panel1.Controls.Add(this.goThroughTheDoor);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 500);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 200);
			this.panel1.TabIndex = 11;
			// 
			// picture
			// 
			this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picture.Image = global::Dom_gra.Properties.Resources.salon;
			this.picture.Location = new System.Drawing.Point(0, 0);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(800, 500);
			this.picture.TabIndex = 12;
			this.picture.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(698, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 320);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.DoorButtonRightClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 700);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picture);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button goThroughTheDoor;
		private System.Windows.Forms.Button goHere;
		private System.Windows.Forms.ComboBox exits;
		private System.Windows.Forms.TextBox description;
		private System.Windows.Forms.Button check;
		private System.Windows.Forms.Button hide;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

