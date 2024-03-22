using System;
using System.IO;
using System.Windows.Forms;

namespace Binary_data
{
	public partial class Form1 : Form
	{
		private readonly int _intValue = 48769414;
		private readonly string _stringValue = "Witaj!";
		private readonly byte[] _byteArray = { 47, 129, 0, 116 };
		private readonly float _floatValue = 491.695F;
		private readonly char _charValue = 'E';

		public Form1() 
			=> InitializeComponent();

		private void button1_Click(object sender, EventArgs e)
		{
			using (FileStream output = File.Create("danebinarne.dat"))
			using (BinaryWriter writer = new BinaryWriter(output))
			{
				writer.Write(_intValue);
				writer.Write(_stringValue);
				writer.Write(_byteArray);
				writer.Write(_floatValue);
				writer.Write(_charValue);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			byte[] dataWritten = File.ReadAllBytes("danebinarne.dat");
			foreach (var item in dataWritten)
			{
				Console.Write("{0:x2} ", item);
			}
			Console.WriteLine(" - {0} bajtów", dataWritten.Length);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (FileStream input = File.OpenRead("danebinarne.dat"))
			using (BinaryReader reader = new BinaryReader(input))
			{
				int intRead = reader.ReadInt32();
				string stringRead = reader.ReadString();
				byte[] byteArrayRead = reader.ReadBytes(4);
				float floatRead = reader.ReadSingle();
				char charRead = reader.ReadChar();

				Console.Write("int: {0} string: {1} bajty: ", intRead, stringRead);
				foreach (var item in byteArrayRead)
				{
					Console.Write("{0} ", item);
				}

				Console.Write(" float: {0} char: {1} ", floatRead, charRead);
			}
			Console.WriteLine();
		}
	}
}