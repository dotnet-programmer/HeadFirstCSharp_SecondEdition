using System.Windows.Forms;

namespace Symulator_ula
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