using System.Windows.Forms;

namespace Symulator_ula_2
{
	public partial class FieldForm : Form
	{
		public Renderer Renderer { get; set; }

		public FieldForm() => InitializeComponent();//BackgroundImage = Renderer.ResizeImage(Properties.Resources.background, ClientRectangle.Width, ClientRectangle.Height);

		private void FieldForm_Paint(object sender, PaintEventArgs e) => Renderer.PaintField(e.Graphics);
	}
}