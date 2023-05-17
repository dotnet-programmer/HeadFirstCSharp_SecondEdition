using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Symulator_ula_2
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

			timer1.Interval = 32;
			//timer1.Interval = 50;
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
			//renderer.Render();
			end = DateTime.Now;
			TimeSpan frameDuration = end - start;
			start = end;
			UpdateStats(frameDuration);

			hiveForm.Invalidate();
			fieldForm.Invalidate();
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
			//renderer.Reset();
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

			//renderer.Reset();
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
			bool stoppedTimer = false;
			if (timer1.Enabled)
			{
				timer1.Stop();
				stoppedTimer = true;
			}

			PrintPreviewDialog previewDialog = new PrintPreviewDialog();
			PrintDocument document = new PrintDocument();
			previewDialog.Document = document;
			document.PrintPage += Document_PrintPage;
			previewDialog.ShowDialog(this);

			if (stoppedTimer)
			{
				timer1.Start();
			}
		}

		private void Document_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Size stringSize;
			using (Font arial24bold = new Font("Arial", 24, FontStyle.Bold))
			{
				stringSize = Size.Ceiling(g.MeasureString("Symulator ula", arial24bold));
				g.FillEllipse(Brushes.Gray, new Rectangle(e.MarginBounds.X + 2, e.MarginBounds.Y + 2, stringSize.Width + 30, stringSize.Height + 30));
				g.FillEllipse(Brushes.Black, new Rectangle(e.MarginBounds.X, e.MarginBounds.Y, stringSize.Width + 30, stringSize.Height + 30));
				g.DrawString("Symulator ula", arial24bold, Brushes.Gray, e.MarginBounds.X + 17, e.MarginBounds.Y + 17);
				g.DrawString("Symulator ula", arial24bold, Brushes.White, e.MarginBounds.X + 15, e.MarginBounds.Y + 15);
			}

			int tableX = e.MarginBounds.X + (int)stringSize.Width + 50;
			int tableWidth = e.MarginBounds.X + e.MarginBounds.Width - tableX - 20;
			int firstColumnX = tableX + 2;
			int secondColumnX = tableX + (tableWidth / 2) + 55;
			int tableY = e.MarginBounds.Y;
			g.DrawLine(Pens.Black, tableX, tableY, tableX + tableWidth, tableY);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość pszczół", Bees.Text);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość kwiatów", Flowers.Text);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość miodu w ulu", HoneyInHive.Text);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość nektaru na polu", NectarInFlowers.Text);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość wyświetlonych klatek", FramesRun.Text);
			tableY = PrintTableRow(g, tableX, tableWidth, firstColumnX, secondColumnX, tableY, "Ilość klatek na sekundę", FrameRate.Text);
			g.DrawLine(Pens.Black, tableX, e.MarginBounds.Y, tableX, tableY);
			g.DrawLine(Pens.Black, secondColumnX, e.MarginBounds.Y, secondColumnX, tableY);
			g.DrawLine(Pens.Black, tableX + tableWidth, e.MarginBounds.Y, tableX + tableWidth, tableY);

			using (Pen blackPen = new Pen(Color.Black, 2.0F))
			using (Bitmap hiveBitmap = new Bitmap(hiveForm.ClientSize.Width, hiveForm.ClientSize.Height))
			using (Bitmap fieldBitmap = new Bitmap(fieldForm.ClientSize.Width, fieldForm.ClientSize.Height))
			{
				using (Graphics hiveGraphics = Graphics.FromImage(hiveBitmap))
				{
					renderer.PaintHive(hiveGraphics);
				}
				int hiveWidth = e.MarginBounds.Width / 2;
				float ratio = (float)hiveBitmap.Height / (float)hiveBitmap.Width;
				int hiveHeight = (int)(hiveWidth * ratio);
				int hiveX = e.MarginBounds.X + (e.MarginBounds.Width - hiveWidth) / 2;
				int hiveY = e.MarginBounds.Height / 3;
				g.DrawImage(hiveBitmap, hiveX, hiveY, hiveWidth, hiveHeight);
				g.DrawRectangle(blackPen, hiveX, hiveY, hiveWidth, hiveHeight);

				using (Graphics fieldGraphics = Graphics.FromImage(fieldBitmap))
				{
					renderer.PaintField(fieldGraphics);
				}
				int fieldWidth = e.MarginBounds.Width;
				ratio = (float)fieldBitmap.Height / (float)fieldBitmap.Width;
				int fieldHeight = (int)(fieldWidth * ratio);
				int fieldX = e.MarginBounds.X;
				int fieldY = e.MarginBounds.Y + e.MarginBounds.Height - fieldHeight;
				g.DrawImage(fieldBitmap, fieldX, fieldY, fieldWidth, fieldHeight);
				g.DrawRectangle(blackPen, fieldX, fieldY, fieldWidth, fieldHeight);
			}
		}

		private int PrintTableRow(Graphics printGraphics, int tableX, int tableWidth, int firstColumnX, int secondColumnX, int tableY, string firstColumn, string secondColumn)
		{
			Font arial12 = new Font("Arial", 12);
			Size stringSize = Size.Ceiling(printGraphics.MeasureString(firstColumn, arial12));
			tableY += 2;
			printGraphics.DrawString(firstColumn, arial12, Brushes.Black, firstColumnX, tableY);
			printGraphics.DrawString(secondColumn, arial12, Brushes.Black, secondColumnX, tableY);
			tableY += (int)stringSize.Height + 2;
			printGraphics.DrawLine(Pens.Black, tableX, tableY, tableX + tableWidth, tableY);
			arial12.Dispose();
			return tableY;
		}

		private void Form1_Move(object sender, EventArgs e) => MoveChildForms();

		private void ResetSimulator()
		{
			framesRun = 0;
			world = new World(new BeeMessage(SendMessage));
			renderer = new Renderer(world, hiveForm, fieldForm);
		}

		private void timer2_Tick(object sender, EventArgs e) => renderer.AnimateBees();
	}
}