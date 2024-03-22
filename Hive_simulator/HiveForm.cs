using System.Windows.Forms;

namespace Hive_simulator
{
	public partial class HiveForm : Form
	{
		public HiveForm()
		{
			InitializeComponent();
			BackgroundImage = Renderer.ResizeImage(Properties.Resources.Hive__inside_, ClientRectangle.Width, ClientRectangle.Height);
		}
	}
}