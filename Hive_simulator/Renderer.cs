using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hive_simulator
{
	internal class Renderer
	{
		private readonly World _world;
		private readonly HiveForm _hiveForm;
		private readonly FieldForm _fieldForm;

		private readonly Dictionary<Flower, PictureBox> _flowerLookup = new Dictionary<Flower, PictureBox>();
		private readonly List<Flower> _deadFlowers = new List<Flower>();

		private readonly Dictionary<Bee, BeeControl> _beeLookup = new Dictionary<Bee, BeeControl>();
		private readonly List<Bee> _retiredBees = new List<Bee>();

		public Renderer(World world, HiveForm hiveForm, FieldForm fieldForm)
		{
			_world = world;
			_hiveForm = hiveForm;
			_fieldForm = fieldForm;
		}

		public void Render()
		{
			DrawBees();
			DrawFlowers();
			RemoveRetiredBeesAndDeadFlowers();
		}

		public void Reset()
		{
			foreach (var item in _flowerLookup.Values)
			{
				_fieldForm.Controls.Remove(item);
				item.Dispose();
			}

			foreach (var item in _beeLookup.Values)
			{
				_hiveForm.Controls.Remove(item);
				_fieldForm.Controls.Remove(item);
				item.Dispose();
			}

			_flowerLookup.Clear();
			_beeLookup.Clear();
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

		private void DrawFlowers()
		{
			foreach (var item in _world.Flowers)
			{
				if (!_flowerLookup.ContainsKey(item))
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
					_flowerLookup.Add(item, flowerControl);
					_fieldForm.Controls.Add(flowerControl);

					//using (Graphics g = fieldForm.CreateGraphics())
					//{
					//	DrawFlower(g, new Rectangle(new Point(item.Location.X, item.Location.Y), new Size(45, 55) ));
					//}
				}
			}

			foreach (var item in _flowerLookup.Keys)
			{
				if (!_world.Flowers.Contains(item))
				{
					PictureBox flowerControlToRemove = _flowerLookup[item];
					_fieldForm.Controls.Remove(flowerControlToRemove);
					flowerControlToRemove.Dispose();
					_deadFlowers.Add(item);
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
			foreach (var item in _world.Bees)
			{
				beeControl = GetBeeControl(item);
				if (item.InsideHive)
				{
					if (_fieldForm.Controls.Contains(beeControl))
					{
						MoveBeeFromFieldToHive(beeControl);
					}
				}
				else if (_hiveForm.Controls.Contains(beeControl))
				{
					MoveBeeFromHiveToField(beeControl);
				}

				beeControl.Location = item.Location;
			}

			foreach (var item in _beeLookup.Keys)
			{
				if (!_world.Bees.Contains(item))
				{
					beeControl = _beeLookup[item];
					if (_fieldForm.Controls.Contains(beeControl))
					{
						_fieldForm.Controls.Remove(beeControl);
					}

					if (_hiveForm.Controls.Contains(beeControl))
					{
						_hiveForm.Controls.Remove(beeControl);
					}

					beeControl.Dispose();
					_retiredBees.Add(item);
				}
			}
		}

		private BeeControl GetBeeControl(Bee bee)
		{
			BeeControl beeControl;
			if (!_beeLookup.ContainsKey(bee))
			{
				beeControl = new BeeControl() { Width = 40, Height = 40 };
				_beeLookup.Add(bee, beeControl);
				_hiveForm.Controls.Add(beeControl);
				beeControl.BringToFront();
			}
			else
			{
				beeControl = _beeLookup[bee];
			}

			return beeControl;
		}

		private void MoveBeeFromHiveToField(BeeControl beeControl)
		{
			_hiveForm.Controls.Remove(beeControl);
			beeControl.Size = new Size(20, 20);
			_fieldForm.Controls.Add(beeControl);
			beeControl.BringToFront();
		}

		private void MoveBeeFromFieldToHive(BeeControl beeControl)
		{
			_fieldForm.Controls.Remove(beeControl);
			beeControl.Size = new Size(40, 40);
			_hiveForm.Controls.Add(beeControl);
			beeControl.BringToFront();
		}

		private void RemoveRetiredBeesAndDeadFlowers()
		{
			foreach (var item in _retiredBees)
			{
				_beeLookup.Remove(item);
			}

			_retiredBees.Clear();
			foreach (var item in _deadFlowers)
			{
				_flowerLookup.Remove(item);
			}

			_deadFlowers.Clear();
		}
	}
}