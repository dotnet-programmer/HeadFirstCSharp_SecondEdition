namespace Riddle_pool_3
{
	internal class Triangle
	{
		private double area;
		private int height;
		private int length;

		public static void Main()
		{
			string results = "";
			int x = 0;
			Triangle[] ta = new Triangle[4];
			while (x < 4)
			{
				ta[x] = new Triangle
				{
					height = (x + 1) * 2,
					length = x + 4
				};
				ta[x].setArea();
				results += "trójkąt " + x + ", pole";
				results += " = " + ta[x].area + "\n";
				x++;
			}
			int y = x;
			x = 27;
			Triangle t5 = ta[2];
			ta[2].area = 343;
			results += "y = " + y;
			System.Windows.Forms.MessageBox.Show(results + ", t5 pole = " + t5.area);
		}

		private void setArea() => area = (height * length) / 2;
	}
}