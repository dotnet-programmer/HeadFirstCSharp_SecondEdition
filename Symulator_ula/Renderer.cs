using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Symulator_ula
{
	internal class Renderer
	{
		private readonly World world;
		private readonly HiveForm hiveForm;
		private readonly FieldForm fieldForm;

		private readonly Dictionary<Flower, PictureBox> flowerLookup = new Dictionary<Flower, PictureBox>();
		private readonly List<Flower> deadFlowers = new List<Flower>();

		private readonly Dictionary<Bee, BeeControl> beeLookup = new Dictionary<Bee, BeeControl>();
		private readonly List<Bee> retiredBees = new List<Bee>();

		public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
		{
			this.world = world;
			this.hiveForm = hiveForm;
			this.fieldForm = fieldForm;
		}

		public void Render()
		{
			DrawBees();
			DrawFlowers();
			RemoveRetiredBeesAndDeadFlowers();
		}

		public void Reset()
		{
			foreach (var item in flowerLookup.Values)
			{
				fieldForm.Controls.Remove(item);
				item.Dispose();
			}

			foreach (var item in beeLookup.Values)
			{
				hiveForm.Controls.Remove(item);
				fieldForm.Controls.Remove(item);
				item.Dispose();
			}

			flowerLookup.Clear();
			beeLookup.Clear();
		}

		private void DrawFlowers()
		{
			foreach (var item in world.Flowers)
			{
				if (!flowerLookup.ContainsKey(item))
				{
					PictureBox flowerControl = new PictureBox()
					{
						Width = 45,
						Height = 55,
						Image = Properties.Resources.Flower,
						SizeMode = PictureBoxSizeMode.Zoom,
						Location = item.Location,
						BackColor = Color.Transparent
					};
					flowerLookup.Add(item, flowerControl);
					fieldForm.Controls.Add(flowerControl);

					//using (Graphics g = fieldForm.CreateGraphics())
					//{
					//	DrawFlower(g, new Rectangle(new Point(item.Location.X, item.Location.Y), new Size(45, 55) ));
					//}
				}
			}

			foreach (var item in flowerLookup.Keys)
			{
				if (!world.Flowers.Contains(item))
				{
					PictureBox flowerControlToRemove = flowerLookup[item];
					fieldForm.Controls.Remove(flowerControlToRemove);
					flowerControlToRemove.Dispose();
					deadFlowers.Add(item);
				}
			}
		}

		//private void DrawFlower(Graphics g, Rectangle r)
		//{
		//	g.DrawImage(Properties.Resources.Flower, r);
		//}

		private void DrawBees()
		{
			BeeControl beeControl;
			foreach (var item in world.Bees)
			{
				beeControl = GetBeeControl(item);
				if (item.InsideHive)
				{
					if (fieldForm.Controls.Contains(beeControl))
					{
						MoveBeeFromFieldToHive(beeControl);
					}
				}
				else if (hiveForm.Controls.Contains(beeControl))
				{
					MoveBeeFromHiveToField(beeControl);
				}

				beeControl.Location = item.Location;
			}

			foreach (var item in beeLookup.Keys)
			{
				if (!world.Bees.Contains(item))
				{
					beeControl = beeLookup[item];
					if (fieldForm.Controls.Contains(beeControl))
					{
						fieldForm.Controls.Remove(beeControl);
					}

					if (hiveForm.Controls.Contains(beeControl))
					{
						hiveForm.Controls.Remove(beeControl);
					}

					beeControl.Dispose();
					retiredBees.Add(item);
				}
			}
		}

		private BeeControl GetBeeControl(Bee bee)
		{
			BeeControl beeControl;
			if (!beeLookup.ContainsKey(bee))
			{
				beeControl = new BeeControl() { Width = 40, Height = 40 };
				beeLookup.Add(bee, beeControl);
				hiveForm.Controls.Add(beeControl);
				beeControl.BringToFront();
			}
			else
			{
				beeControl = beeLookup[bee];
			}

			return beeControl;
		}

		private void MoveBeeFromHiveToField(BeeControl beeControl)
		{
			hiveForm.Controls.Remove(beeControl);
			beeControl.Size = new Size(20, 20);
			fieldForm.Controls.Add(beeControl);
			beeControl.BringToFront();
		}

		private void MoveBeeFromFieldToHive(BeeControl beeControl)
		{
			fieldForm.Controls.Remove(beeControl);
			beeControl.Size = new Size(40, 40);
			hiveForm.Controls.Add(beeControl);
			beeControl.BringToFront();
		}

		private void RemoveRetiredBeesAndDeadFlowers()
		{
			foreach (var item in retiredBees)
			{
				beeLookup.Remove(item);
			}

			retiredBees.Clear();
			foreach (var item in deadFlowers)
			{
				flowerLookup.Remove(item);
			}

			deadFlowers.Clear();
		}

		public static Bitmap ResizeImage(Bitmap picture, int width, int height)
		{
			Bitmap resizedPicture = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(resizedPicture))
			{
				graphics.DrawImage(picture, 0, 0, width, height);
			}
			return resizedPicture;
		}
	}
}