using System;
using System.Windows.Forms;

namespace Events_1
{
	public partial class Form1 : Form
	{
		private readonly Ball _ball = new Ball();
		private readonly Pitcher _pitcher;
		private readonly Fan _fan;

		public Form1()
		{
			InitializeComponent();
			_pitcher = new Pitcher(_ball);
			_fan = new Fan(_ball);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bat bat = _ball.GetNewBat();
			BallEventArgs ballEventArgs = new BallEventArgs((int)numericUpDown1.Value, (int)numericUpDown2.Value);
			bat.HitTheBall(ballEventArgs);
		}
	}
}