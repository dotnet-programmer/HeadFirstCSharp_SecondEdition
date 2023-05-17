using System;
using System.IO;

namespace Zarzadzanie_wymowkami
{
	internal class Excuse
	{
		public string Description { get; set; }
		public string Results { get; set; }
		public DateTime LastUsed { get; set; }
		public string ExcusePath { get; set; }

		public Excuse() => ExcusePath = "";

		public Excuse(string excusePath) => OpenFile(excusePath);

		public Excuse(Random random, string folder)
		{
			string[] fileNames = Directory.GetFiles(folder, "*.txt");
			OpenFile(fileNames[random.Next(fileNames.Length)]);
		}

		public void OpenFile(string excusePath)
		{
			ExcusePath = excusePath;
			using (StreamReader streamReader = new StreamReader(excusePath))
			{
				Description = streamReader.ReadLine();
				Results = streamReader.ReadLine();
				LastUsed = Convert.ToDateTime(streamReader.ReadLine());
			}
		}

		public void Save(string fileName)
		{
			using (StreamWriter streamWriter = new StreamWriter(fileName))
			{
				streamWriter.WriteLine(Description);
				streamWriter.WriteLine(Results);
				streamWriter.WriteLine(LastUsed);
			}
		}
	}
}