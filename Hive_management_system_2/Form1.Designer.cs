namespace Hive_management_system_2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Shifts = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.AssignWorkBtn = new System.Windows.Forms.Button();
			this.WorkerBeeJob = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NextShift = new System.Windows.Forms.Button();
			this.ReportTxt = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Shifts)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Shifts);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.AssignWorkBtn);
			this.groupBox1.Controls.Add(this.WorkerBeeJob);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(31, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 126);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Przydział pracy robotnicom";
			// 
			// Shifts
			// 
			this.Shifts.Location = new System.Drawing.Point(210, 44);
			this.Shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Shifts.Name = "Shifts";
			this.Shifts.Size = new System.Drawing.Size(70, 20);
			this.Shifts.TabIndex = 4;
			this.Shifts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(217, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Zmiany";
			// 
			// AssignWorkBtn
			// 
			this.AssignWorkBtn.Location = new System.Drawing.Point(15, 80);
			this.AssignWorkBtn.Name = "AssignWorkBtn";
			this.AssignWorkBtn.Size = new System.Drawing.Size(147, 23);
			this.AssignWorkBtn.TabIndex = 2;
			this.AssignWorkBtn.Text = "Przypisz tę pracę pszczole";
			this.AssignWorkBtn.UseVisualStyleBackColor = true;
			this.AssignWorkBtn.Click += new System.EventHandler(this.AssignWorkBtn_Click);
			// 
			// WorkerBeeJob
			// 
			this.WorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WorkerBeeJob.FormattingEnabled = true;
			this.WorkerBeeJob.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczółek",
            "Utrzymywanie ula",
            "Patrol z żądłami"});
			this.WorkerBeeJob.Location = new System.Drawing.Point(15, 44);
			this.WorkerBeeJob.Name = "WorkerBeeJob";
			this.WorkerBeeJob.Size = new System.Drawing.Size(147, 21);
			this.WorkerBeeJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zadanie robotnicy";
			// 
			// NextShift
			// 
			this.NextShift.Location = new System.Drawing.Point(350, 71);
			this.NextShift.Name = "NextShift";
			this.NextShift.Size = new System.Drawing.Size(76, 59);
			this.NextShift.TabIndex = 1;
			this.NextShift.Text = "Przepracuj następną zmianę";
			this.NextShift.UseVisualStyleBackColor = true;
			this.NextShift.Click += new System.EventHandler(this.NextShift_Click);
			// 
			// ReportTxt
			// 
			this.ReportTxt.Location = new System.Drawing.Point(31, 159);
			this.ReportTxt.Multiline = true;
			this.ReportTxt.Name = "ReportTxt";
			this.ReportTxt.Size = new System.Drawing.Size(395, 193);
			this.ReportTxt.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 378);
			this.Controls.Add(this.ReportTxt);
			this.Controls.Add(this.NextShift);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "System zarządzania ulem";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Shifts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown Shifts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AssignWorkBtn;
		private System.Windows.Forms.ComboBox WorkerBeeJob;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button NextShift;
		private System.Windows.Forms.TextBox ReportTxt;
	}
}

