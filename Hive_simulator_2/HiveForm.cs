using System.Windows.Forms;

namespace Hive_simulator_2
{
	public partial class HiveForm : Form
	{
		public HiveForm()
			=> InitializeComponent();

		public Renderer Renderer { get; set; }
		//BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_, ClientRectangle.Width, ClientRectangle.Height);

		private void HiveForm_Paint(object sender, PaintEventArgs e)
			=> Renderer.PaintHive(e.Graphics);
	}
}