using System.Windows.Forms;

namespace Hive_simulator
{
	public partial class FieldForm : Form
	{
		public FieldForm()
		{
			InitializeComponent();
			BackgroundImage = Renderer.ResizeImage(Properties.Resources.background, ClientRectangle.Width, ClientRectangle.Height);
		}
	}
}