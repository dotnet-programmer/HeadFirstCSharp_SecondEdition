using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Excuses_management_2
{
	[Serializable]
	internal class Excuse
	{
		public Excuse() 
			=> ExcusePath = "";

		public Excuse(string excusePath) 
			=> OpenFile(excusePath);

		public Excuse(Random random, string folder)
		{
			string[] fileNames = Directory.GetFiles(folder, "*.excuse");
			OpenFile(fileNames[random.Next(fileNames.Length)]);
		}

		public string Description { get; set; }
		public string Results { get; set; }
		public DateTime LastUsed { get; set; }
		public string ExcusePath { get; set; }

		public void OpenFile(string excusePath)
		{
			//ExcusePath = excusePath;
			//using (StreamReader streamReader = new StreamReader(excusePath))
			//{
			//	Description = streamReader.ReadLine();
			//	Results = streamReader.ReadLine();
			//	LastUsed = Convert.ToDateTime(streamReader.ReadLine());
			//}

			ExcusePath = excusePath;
			Excuse tmpExcuse;
			using (Stream input = File.OpenRead(excusePath))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				tmpExcuse = (Excuse)formatter.Deserialize(input);
			}

			Description = tmpExcuse.Description;
			Results = tmpExcuse.Results;
			LastUsed = tmpExcuse.LastUsed;
		}

		public void Save(string fileName)
		{
			//using (StreamWriter streamWriter = new StreamWriter(fileName))
			//{
			//	streamWriter.WriteLine(Description);
			//	streamWriter.WriteLine(Results);
			//	streamWriter.WriteLine(LastUsed);
			//}

			using (Stream output = File.Create(fileName))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, this);
			}
		}
	}
}