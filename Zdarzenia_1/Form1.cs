using System;
using System.Windows.Forms;

namespace Zdarzenia_1
{
	public partial class Form1 : Form
	{
		private readonly Ball ball = new Ball();
		private readonly Pitcher pitcher;
		private readonly Fan fan;

		public Form1()
		{
			InitializeComponent();
			pitcher = new Pitcher(ball);
			fan = new Fan(ball);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bat bat = ball.GetNewBat();
			BallEventArgs ballEventArgs = new BallEventArgs((int)numericUpDown1.Value, (int)numericUpDown2.Value);
			bat.HitTheBall(ballEventArgs);
		}
	}
}