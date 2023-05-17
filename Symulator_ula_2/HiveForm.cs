using System.Windows.Forms;

namespace Symulator_ula_2
{
	public partial class HiveForm : Form
	{
		public Renderer Renderer { get; set; }

		public HiveForm() => InitializeComponent();//BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_, ClientRectangle.Width, ClientRectangle.Height);

		private void HiveForm_Paint(object sender, PaintEventArgs e) => Renderer.PaintHive(e.Graphics);
	}
}