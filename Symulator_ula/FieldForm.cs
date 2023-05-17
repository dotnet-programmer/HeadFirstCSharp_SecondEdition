using System.Windows.Forms;

namespace Symulator_ula
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