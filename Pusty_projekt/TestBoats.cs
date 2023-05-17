namespace Zagadkowy_basen_4
{
	internal class TestBoats
	{
		private static void Main() // static void
		{
			string xyz = ""; // string
			Boat b1 = new Boat(); // Boat
			Sailboat b2 = new Sailboat(); // Sailboat
			Rowboat b3 = new Rowboat(); // b3
			b2.setLength(32);
			xyz = b1.move(); // move
			xyz += b3.move(); // move
			xyz += b2.move(); // b2
			System.Windows.Forms.MessageBox.Show(xyz);
		}
	}
}