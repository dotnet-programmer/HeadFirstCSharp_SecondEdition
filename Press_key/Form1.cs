using System.Windows.Forms;

namespace Press_key
{
	public partial class Form1 : Form
	{
		public Form1() 
			=> InitializeComponent();

		private void Form1_KeyDown(object sender, KeyEventArgs e) 
			=> listBox1.Items.Add(e.KeyCode);
	}
}