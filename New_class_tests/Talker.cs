using System.Windows.Forms;

namespace New_class_tests
{
	internal class Talker
	{
		/// <summary>
		/// Funkcja wyświetla przekazany tekst tyle razy, ile wynosi 2 parametr i zwraca długość komunikatu
		/// </summary>
		/// <param name="thingToSay"></param>
		/// <param name="numberOfTimes"></param>
		/// <returns></returns>
		public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
		{
			string finalString = "";
			for (int count = 0; count < numberOfTimes; count++)
			{
				finalString = finalString + thingToSay + "\n";
			}
			MessageBox.Show(finalString);
			return finalString.Length;
		}
	}
}