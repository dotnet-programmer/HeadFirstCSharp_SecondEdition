using System.Drawing;

namespace Hive_simulator_2
{
	public class Renderer
	{
		private readonly World _world;
		private readonly HiveForm _hiveForm;
		private readonly FieldForm _fieldForm;

		private Bitmap _hiveInside;
		private Bitmap _hiveOutside;
		private Bitmap _flower;

		private Bitmap[] _beeAnimationLarge;
		private Bitmap[] _beeAnimationSmall;

		private int _cell = 0;
		private int _frame = 0;

		public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
		{
			_world = world;
			_hiveForm = hiveForm;
			_fieldForm = fieldForm;
			hiveForm.Renderer = this;
			fieldForm.Renderer = this;
			InitializeImages();
		}

		public void PaintHive(Graphics g)
		{
			g.FillRectangle(Brushes.SkyBlue, _hiveForm.ClientRectangle);
			g.DrawImageUnscaled(_hiveInside, 0, 0);
			foreach (var item in _world.Bees)
			{
				if (item.InsideHive)
				{
					g.DrawImageUnscaled(_beeAnimationLarge[_cell], item.Location.X, item.Location.Y);
				}
			}
		}

		public void PaintField(Graphics g)
		{
			using (Pen brownPen = new Pen(Color.Brown, 6.0F))
			using (Pen yellowPen = new Pen(Color.Yellow, 3.0F))
			{
				g.FillRectangle(Brushes.SkyBlue, 0, 0, _fieldForm.ClientSize.Width, _fieldForm.ClientSize.Height / 2);
				g.FillRectangle(Brushes.Green, 0, _fieldForm.ClientSize.Height / 2, _fieldForm.ClientSize.Width, _fieldForm.ClientSize.Height / 2);
				g.FillEllipse(Brushes.Yellow, new RectangleF(50, 15, 70, 70));
				g.DrawLine(yellowPen, 96, 92, 110, 129);
				g.DrawLine(yellowPen, 124, 73, 173, 100);
				g.DrawLine(yellowPen, 131, 45, 194, 35);
				g.DrawLine(yellowPen, 50, 78, 28, 113);

				g.DrawLine(brownPen, new Point(593, 0), new Point(593, 30));
				g.DrawImageUnscaled(_hiveOutside, 550, 20);
				foreach (var item in _world.Flowers)
				{
					g.DrawImageUnscaled(_flower, item.Location.X, item.Location.Y);
				}

				foreach (var item in _world.Bees)
				{
					if (!item.InsideHive)
					{
						g.DrawImageUnscaled(_beeAnimationLarge[_cell], item.Location.X, item.Location.Y);
					}
				}
			}
		}

		public void AnimateBees()
		{
			_frame++;
			//if (frame >= 6)
			//	frame = 0;
			switch (_frame)
			{
				case 0: _cell = 0; break;
				case 1: _cell = 1; break;
				case 2: _cell = 2; break;
				case 3: _cell = 3; break;
				case 4: _cell = 2; break;
				case 5: _cell = 1; break;
				case 6: _cell = 0; _frame = 0; break;
			}
			_hiveForm.Invalidate();
			_fieldForm.Invalidate();
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

		private void InitializeImages()
		{
			_hiveOutside = ResizeImage(Properties.Resources.Hive__outside_, 85, 100);
			_hiveInside = ResizeImage(Properties.Resources.Hive__inside_, _hiveForm.ClientRectangle.Width, _hiveForm.ClientRectangle.Height);
			_flower = ResizeImage(Properties.Resources.Flower, 75, 75);

			_beeAnimationLarge = new Bitmap[4];
			_beeAnimationLarge[0] = ResizeImage(Properties.Resources.Bee_animation_1, 40, 40);
			_beeAnimationLarge[1] = ResizeImage(Properties.Resources.Bee_animation_2, 40, 40);
			_beeAnimationLarge[2] = ResizeImage(Properties.Resources.Bee_animation_3, 40, 40);
			_beeAnimationLarge[3] = ResizeImage(Properties.Resources.Bee_animation_4, 40, 40);

			_beeAnimationSmall = new Bitmap[4];
			_beeAnimationSmall[0] = ResizeImage(Properties.Resources.Bee_animation_1, 20, 20);
			_beeAnimationSmall[1] = ResizeImage(Properties.Resources.Bee_animation_2, 20, 40);
			_beeAnimationSmall[2] = ResizeImage(Properties.Resources.Bee_animation_3, 20, 20);
			_beeAnimationSmall[3] = ResizeImage(Properties.Resources.Bee_animation_4, 20, 20);
		}

		//public void Render()
		//{
		//	DrawBees();
		//	DrawFlowers();
		//	RemoveRetiredBeesAndDeadFlowers();
		//}

		//public void Reset()
		//{
		//	foreach (var item in flowerLookup.Values)
		//	{
		//		fieldForm.Controls.Remove(item);
		//		item.Dispose();
		//	}

		//	foreach (var item in beeLookup.Values)
		//	{
		//		hiveForm.Controls.Remove(item);
		//		fieldForm.Controls.Remove(item);
		//		item.Dispose();
		//	}

		//	flowerLookup.Clear();
		//	beeLookup.Clear();
		//}

		//private void DrawFlowers()
		//{
		//	foreach (var item in world.Flowers)
		//		if (!flowerLookup.ContainsKey(item))
		//		{
		//			PictureBox flowerControl = new PictureBox()
		//			{
		//				Width = 45,
		//				Height = 55,
		//				Image = Properties.Resources.Flower,
		//				SizeMode = PictureBoxSizeMode.Zoom,
		//				Location = item.Location,
		//				BackColor = Color.Transparent
		//			};
		//			flowerLookup.Add(item, flowerControl);
		//			fieldForm.Controls.Add(flowerControl);

		//			//using (Graphics g = fieldForm.CreateGraphics())
		//			//{
		//			//	DrawFlower(g, new Rectangle(new Point(item.Location.X, item.Location.Y), new Size(45, 55) ));
		//			//}
		//		}

		//	foreach (var item in flowerLookup.Keys)
		//		if (!world.Flowers.Contains(item))
		//		{
		//			PictureBox flowerControlToRemove = flowerLookup[item];
		//			fieldForm.Controls.Remove(flowerControlToRemove);
		//			flowerControlToRemove.Dispose();
		//			deadFlowers.Add(item);
		//		}
		//}

		//private void DrawFlower(Graphics g, Rectangle r)
		//{
		//	g.DrawImage(Properties.Resources.Flower, r);
		//}

		//private void DrawBees()
		//{
		//	BeeControl beeControl;
		//	foreach (var item in world.Bees)
		//	{
		//		beeControl = GetBeeControl(item);
		//		if (item.InsideHive)
		//		{
		//			if (fieldForm.Controls.Contains(beeControl))
		//				MoveBeeFromFieldToHive(beeControl);
		//		}
		//		else if (hiveForm.Controls.Contains(beeControl))
		//			MoveBeeFromHiveToField(beeControl);
		//		beeControl.Location = item.Location;
		//	}

		//	foreach (var item in beeLookup.Keys)
		//		if (!world.Bees.Contains(item))
		//		{
		//			beeControl = beeLookup[item];
		//			if (fieldForm.Controls.Contains(beeControl))
		//				fieldForm.Controls.Remove(beeControl);
		//			if (hiveForm.Controls.Contains(beeControl))
		//				hiveForm.Controls.Remove(beeControl);
		//			beeControl.Dispose();
		//			retiredBees.Add(item);
		//		}
		//}

		//private BeeControl GetBeeControl(Bee bee)
		//{
		//	BeeControl beeControl;
		//	if (!beeLookup.ContainsKey(bee))
		//	{
		//		beeControl = new BeeControl() { Width = 40, Height = 40 };
		//		beeLookup.Add(bee, beeControl);
		//		hiveForm.Controls.Add(beeControl);
		//		beeControl.BringToFront();
		//	}
		//	else
		//		beeControl = beeLookup[bee];
		//	return beeControl;
		//}

		//private void MoveBeeFromHiveToField(BeeControl beeControl)
		//{
		//	hiveForm.Controls.Remove(beeControl);
		//	beeControl.Size = new Size(20, 20);
		//	fieldForm.Controls.Add(beeControl);
		//	beeControl.BringToFront();
		//}

		//private void MoveBeeFromFieldToHive(BeeControl beeControl)
		//{
		//	fieldForm.Controls.Remove(beeControl);
		//	beeControl.Size = new Size(40, 40);
		//	hiveForm.Controls.Add(beeControl);
		//	beeControl.BringToFront();
		//}

		//private void RemoveRetiredBeesAndDeadFlowers()
		//{
		//	foreach (var item in retiredBees)
		//		beeLookup.Remove(item);
		//	retiredBees.Clear();
		//	foreach (var item in deadFlowers)
		//		flowerLookup.Remove(item);
		//	deadFlowers.Clear();
		//}
	}
}