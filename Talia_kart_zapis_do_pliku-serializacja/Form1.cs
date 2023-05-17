using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Talia_kart_zapis_do_pliku_serializacja
{
	public partial class Form1 : Form
	{
		private readonly Random random = new Random();

		public Form1() => InitializeComponent();

		private Deck RandomDeck(int Number)
		{
			Deck myDeck = new Deck(new Card[] { });
			for (int i = 0; i < Number; i++)
			{
				myDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
			}
			return myDeck;
		}

		private void DealCards(Deck deckToDeal, string Title)
		{
			Console.WriteLine(Title);
			while (deckToDeal.Count > 0)
			{
				Card nextCard = deckToDeal.Deal(0);
				Console.WriteLine(nextCard.Name);
			}
			Console.WriteLine("--------------------------------------------");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Deck deckToWrite = RandomDeck(5);
			using (Stream output = File.Create("Zestaw1.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, deckToWrite);
			}
			DealCards(deckToWrite, "To, co zapisałem do pliku");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Deck deckFromFile;
			using (Stream input = File.OpenRead("Zestaw1.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				deckFromFile = (Deck)formatter.Deserialize(input);
				DealCards(deckFromFile, "To, co z pliku odczytałem");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (Stream output = File.Create("Zestaw2.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				for (int i = 0; i <= 5; i++)
				{
					Deck deckToWrite = RandomDeck(random.Next(1, 10));
					formatter.Serialize(output, deckToWrite);
					DealCards(deckToWrite, "Zestaw numer " + i + " zapisany");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (Stream input = File.OpenRead("Zestaw2.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				for (int i = 0; i <= 5; i++)
				{
					Deck deckToRead = (Deck)formatter.Deserialize(input);
					DealCards(deckToRead, "Zestaw numer " + i + " odczytany.");
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Card card1 = new Card((Suits)1, (Values)3);
			Card card2 = new Card((Suits)3, (Values)6);

			using (Stream output = File.Create("Karta1.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, card1);
			}

			using (Stream output = File.Create("Karta2.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output, card2);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			byte[] firstFile = File.ReadAllBytes("karta1.dat");
			byte[] secondFile = File.ReadAllBytes("karta2.dat");
			for (int i = 0; i < firstFile.Length; i++)
			{
				if (firstFile[i] != secondFile[i])
				{
					Console.WriteLine("Bajt numer {0}: {1} i {2}", i, firstFile[i], secondFile[i]);
				}
			}

			//Bajt numer 353: 1 i 3
			//Bajt numer 426: 3 i 6
			firstFile[353] = (byte)Suits.Hearts;
			firstFile[426] = (byte)Values.Six;

			for (int i = 0; i < firstFile.Length; i++)
			{
				if (firstFile[i] != secondFile[i])
				{
					Console.WriteLine("Bajt numer {0}: {1} i {2}", i, firstFile[i], secondFile[i]);
				}
			}
			File.Delete("karta3.dat");
			File.WriteAllBytes("karta3.dat", firstFile);

			Card cardFromFile;
			using (Stream input = File.OpenRead("karta3.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				cardFromFile = (Card)formatter.Deserialize(input);
				Console.WriteLine("karta3.dat - " + cardFromFile.Name);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			using (StreamReader reader = new StreamReader("karta1.dat"))
			using (StreamWriter writer = new StreamWriter("karta1-plik_wyjsciowy2.txt"))
			{
				int position = 0;
				while (!reader.EndOfStream)
				{
					char[] buffer = new char[16];
					int charactersRead = reader.ReadBlock(buffer, 0, 16);
					writer.Write("{0}: ", string.Format("{0:x4}", position));
					position += charactersRead;
					for (int i = 0; i < 16; i++)
					{
						if (i < charactersRead)
						{
							string hex = string.Format("{0:x2}", (byte)buffer[i]);
							writer.Write(hex + " ");
						}
						else
						{
							writer.Write("   ");
						}

						if (i == 7)
						{
							writer.Write("-- ");
						}

						if (buffer[i] < 32 || buffer[i] > 250)
						{
							buffer[i] = '.';
						}
					}
					string bufferContents = new string(buffer);
					//writer.WriteLine("   " + bufferContents.Substring(0, charactersRead));
					writer.WriteLine("   " + bufferContents);
				}
			}
		}
	}
}