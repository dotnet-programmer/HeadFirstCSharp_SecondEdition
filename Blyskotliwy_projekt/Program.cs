using System;
using System.Windows.Forms;

namespace Blyskotliwy_projekt
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