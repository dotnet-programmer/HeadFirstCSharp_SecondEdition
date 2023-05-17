namespace Kaczki_sortowanie
{
	public class Duck
	{
		public int Size { get; set; }
		public KindOfDuck Kind { get; set; }

		public string DuckInfo => Kind.ToString() + " - " + Size.ToString();

		public override string ToString() => Size + "-centymetrowa kaczka " + Kind.ToString();
	}
}