using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Hive_simulator
{
	public partial class Form1 : Form
	{
		private readonly HiveForm _hiveForm = new HiveForm();
		private readonly FieldForm _fieldForm = new FieldForm();
		private readonly Random _random = new Random();

		private Renderer _renderer;
		private World _world;
		private DateTime _start = DateTime.Now;
		private DateTime _end;
		private int _framesRun = 0;

		public Form1()
		{
			InitializeComponent();

			MoveChildForms();
			_hiveForm.Show(this);
			_fieldForm.Show(this);
			ResetSimulator();

			timer1.Interval = 50;
			timer1.Tick += new EventHandler(RunFrame);
			timer1.Enabled = false;
			UpdateStats(new TimeSpan());
		}

		public void RunFrame(object sender, EventArgs e)
		{
			_framesRun++;
			_world.Go(_random);
			_renderer.Render();
			_end = DateTime.Now;
			TimeSpan frameDuration = _end - _start;
			_start = _end;
			UpdateStats(frameDuration);
		}

		private void MoveChildForms()
		{
			_hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
			_fieldForm.Location = new Point(Location.X, Location.Y + Math.Max(Height, _hiveForm.Height) + 10);
		}

		private void UpdateStats(TimeSpan frameDuration)
		{
			Bees.Text = _world.Bees.Count.ToString();
			Flowers.Text = _world.Flowers.Count.ToString();
			HoneyInHive.Text = string.Format("{0:f3}", _world.Hive.Honey);
			double nectar = 0;
			foreach (var item in _world.Flowers)
			{
				nectar += item.Nectar;
			}

			NectarInFlowers.Text = string.Format("{0:f3}", nectar);
			FramesRun.Text = _framesRun.ToString();
			double milliSeconds = frameDuration.TotalMilliseconds;
			FrameRate.Text = milliSeconds != 0.0 ? string.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds) : "brak";
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
			_renderer.Reset();
			ResetSimulator();
			if (!timer1.Enabled)
			{
				toolStrip1.Items[0].Text = "Rozpocznij symulację";
			}
		}

		private void SendMessage(int ID, string Message)
		{
			statusStrip1.Items[0].Text = "Pszczoła numer " + ID + ": " + Message;

			var beeGroups = from bee in _world.Bees group bee by bee.CurrentState into beeGroup orderby beeGroup.Key select beeGroup;

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

				if (item.Key == BeeState.Idle && item.Count() == _world.Bees.Count() && _framesRun > 0)
				{
					listBox1.Items.Add("Symulacja zakończona: wszytkie pszczoły są bezrobotne.");
					toolStrip1.Items[0].Text = statusStrip1.Items[0].Text = "Symulacja zakończona";
					timer1.Enabled = false;
				}
			}
		}

		private void otwórzToolStripButton_Click(object sender, EventArgs e)
		{
			World currentWorld = _world;
			int currentFramesRun = _framesRun;

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
						_world = (World)formatter.Deserialize(stream);
						_framesRun = (int)formatter.Deserialize(stream);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nie można odczytać pliku symulatora.\r\n" + ex.Message, "Błąd symulatora ula", MessageBoxButtons.OK, MessageBoxIcon.Error);
					_world = currentWorld;
					_framesRun = currentFramesRun;
				}
			}

			_world.Hive.MessageSender = new BeeMessage(SendMessage);
			foreach (var item in _world.Bees)
			{
				item.MessageSender = new BeeMessage(SendMessage);
			}

			if (enabled)
			{
				timer1.Start();
			}

			_renderer.Reset();
			_renderer = new Renderer(_world, _hiveForm, _fieldForm);
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
						formatter.Serialize(stream, _world);
						formatter.Serialize(stream, _framesRun);
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

		private void Form1_Move(object sender, EventArgs e)
			=> MoveChildForms();

		private void ResetSimulator()
		{
			_framesRun = 0;
			_world = new World(new BeeMessage(SendMessage));
			_renderer = new Renderer(_world, _hiveForm, _fieldForm);
		}
	}
}