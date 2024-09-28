using System.Windows.Forms;

namespace Hive_simulator_2
{
	public partial class FieldForm : Form
	{
		public FieldForm()
			=> InitializeComponent();

		//BackgroundImage = Renderer.ResizeImage(Properties.Resources.background, ClientRectangle.Width, ClientRectangle.Height);

		public Renderer Renderer { get; set; }

		private void FieldForm_Paint(object sender, PaintEventArgs e)
			=> Renderer.PaintField(e.Graphics);
	}
}