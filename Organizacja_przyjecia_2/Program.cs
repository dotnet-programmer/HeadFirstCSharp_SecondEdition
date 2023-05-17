using System;
using System.Windows.Forms;

namespace Organizacja_przyjecia_2
{
	internal static class Program
	{
		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}