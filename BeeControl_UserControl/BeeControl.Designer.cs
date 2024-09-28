namespace BeeControl_UserControl
{
	partial class BeeControl
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

		#region Kod wygenerowany przez Projektanta składników

		/// <summary> 
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// AnimationTimer
			// 
			this.AnimationTimer.Enabled = true;
			this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
			// 
			// BeeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Name = "BeeControl";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer AnimationTimer;
	}
}
