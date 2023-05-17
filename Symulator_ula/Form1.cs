using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Symulator_ula
{
	public partial class Form1 : Form
	{
		private readonly HiveForm hiveForm = new HiveForm();
		private readonly FieldForm fieldForm = new FieldForm();
		private Renderer renderer;

		private World world;
		private readonly Random random = new Random();
		private DateTime start = DateTime.Now;
		private DateTime end;
		private int framesRun = 0;

		public Form1()
		{
			InitializeComponent();

			MoveChildForms();
			hiveForm.Show(this);
			fieldForm.Show(this);
			ResetSimulator();

			timer1.Interval = 50;
			timer1.Tick += new EventHandler(RunFrame);
			timer1.Enabled = false;
			UpdateStats(new TimeSpan());
		}

		private void MoveChildForms()
		{
			hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
			fieldForm.Location = new Point(Location.X, Location.Y + Math.Max(Height, hiveForm.Height) + 10);
		}

		private void UpdateStats(TimeSpan frameDuration)
		{
			Bees.Text = world.Bees.Count.ToString();
			Flowers.Text = world.Flowers.Count.ToString();
			HoneyInHive.Text = string.Format("{0:f3}", world.Hive.Honey);
			double nectar = 0;
			foreach (var item in world.Flowers)
			{
				nectar += item.Nectar;
			}

			NectarInFlowers.Text = string.Format("{0:f3}", nectar);
			FramesRun.Text = framesRun.ToString();
			double milliSeconds = frameDuration.TotalMilliseconds;
			FrameRate.Text = milliSeconds != 0.0 ? string.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds) : "brak";
		}

		public void RunFrame(object sender, EventArgs e)
		{
			framesRun++;
			world.Go(random);
			renderer.Render();
			end = DateTime.Now;
			TimeSpan frameDuration = end - start;
			start = end;
			UpdateStats(frameDuration);
		}

		private void startSimulation_Click(object sender, EventArgs e)
		{
			if (timer1.Enabled)
			{
				toolStrip1.Items[0].Text = "Wznów symulację";
				timer1.Stop();
			}
			else
			{
				toolStrip1.Items[0].Text = "Zatrzymaj symulację";
				timer1.Start();
			}
		}

		private void reset_Click(object sender, EventArgs e)
		{
			renderer.Reset();
			ResetSimulator();
			if (!timer1.Enabled)
			{
				toolStrip1.Items[0].Text = "Rozpocznij symulację";
			}
		}

		private void SendMessage(int ID, string Message)
		{
			statusStrip1.Items[0].Text = "Pszczoła numer " + ID + ": " + Message;

			var beeGroups = from bee in world.Bees group bee by bee.CurrentState into beeGroup orderby beeGroup.Key select beeGroup;

			listBox1.Items.Clear();
			foreach (var item in beeGroups)
			{
				string s = item.Count() == 1 ? "pszczoła" : item.Count() > 4 ? "pszczół" : "pszczoły";
				string stringState;
				switch (item.Key)
				{
					case BeeState.FlyingToFlower:
						stringState = "Lot w kierunku kwiatu";
						break;
					case BeeState.GatheringNectar:
						stringState = "Zbieranie nektaru";
						break;
					case BeeState.ReturningToHive:
						stringState = "Powrót do ula";
						break;
					case BeeState.MakingHoney:
						stringState = "Wytwarzanie miodu";
						break;
					case BeeState.Retired:
						stringState = "Na emeryturze";
						break;
					default:
						stringState = "Bezrobocie";
						break;
				}

				listBox1.Items.Add(stringState + ": " + item.Count() + " " + s);

				if (item.Key == BeeState.Idle && item.Count() == world.Bees.Count() && framesRun > 0)
				{
					listBox1.Items.Add("Symulacja zakończona: wszytkie pszczoły są bezrobotne.");
					toolStrip1.Items[0].Text = statusStrip1.Items[0].Text = "Symulacja zakończona";
					timer1.Enabled = false;
				}
			}
		}

		private void otwórzToolStripButton_Click(object sender, EventArgs e)
		{
			World currentWorld = world;
			int currentFramesRun = framesRun;

			bool enabled = timer1.Enabled;
			if (enabled)
			{
				timer1.Stop();
			}

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Stream stream = File.OpenRead(openFileDialog1.FileName))
					{
						BinaryFormatter formatter = new BinaryFormatter();
						world = (World)formatter.Deserialize(stream);
						framesRun = (int)formatter.Deserialize(stream);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie można odczytać pliku symulatora.\r\n" + ex.Message, "Błąd symulatora ula", MessageBoxButtons.OK, MessageBoxIcon.Error);
					world = currentWorld;
					framesRun = currentFramesRun;
				}
			}

			world.Hive.MessageSender = new BeeMessage(SendMessage);
			foreach (var item in world.Bees)
			{
				item.MessageSender = new BeeMessage(SendMessage);
			}

			if (enabled)
			{
				timer1.Start();
			}

			renderer.Reset();
			renderer = new Renderer(world, hiveForm, fieldForm);
		}

		private void zapiszToolStripButton_Click(object sender, EventArgs e)
		{
			bool enabled = timer1.Enabled;
			if (enabled)
			{
				timer1.Stop();
			}

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Stream stream = File.Create(saveFileDialog1.FileName))
					{
						BinaryFormatter formatter = new BinaryFormatter();
						formatter.Serialize(stream, world);
						formatter.Serialize(stream, framesRun);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie można zapisać pliku symulatora.\r\n" + ex.Message, "Błąd symulatora ula", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			if (enabled)
			{
				timer1.Start();
			}
		}

		private void drukujToolStripButton_Click(object sender, EventArgs e)
		{
		}

		private void Form1_Move(object sender, EventArgs e) => MoveChildForms();

		private void ResetSimulator()
		{
			framesRun = 0;
			world = new World(new BeeMessage(SendMessage));
			renderer = new Renderer(world, hiveForm, fieldForm);
		}
	}
}