namespace Racing
{
	internal class Bet
	{
		// ilosc postawionych pieniedzy
		public int Amount;

		// numer psa, na ktorego postawiono
		public int Dog;

		// facet, ktory zawarl zaklad
		public Guy Bettor;

		// zwraca string, ktory okresla, kto obsawil wyscig, jak duzo pieniedzy postaiwl i na ktorego psa ("Janek postawil 8 zl na psa numer 4")
		// jezeli ilosc jest rowna zero, zaklad nie zostal zawarty ("Janek nie zawarl zakladu")
		public string GetDescription() 
			=> Amount > 0 ? Bettor.Name + " obstawił " + Amount + " zł na psa numer " + Dog : Bettor.Name + " nie zawarł zakładu";

		// Parametrem jest zwyciezca wyscigu, jezeli pies wygral zwroc wartosc postawiona, jak nie zwroc ujemna wartosc postawiona
		public int PayOut(int Winner) 
			=> Dog == Winner ? Amount : -Amount;
	}
}