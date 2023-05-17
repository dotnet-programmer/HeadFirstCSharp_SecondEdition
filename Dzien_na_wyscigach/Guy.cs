using System.Windows.Forms;

namespace Dzien_na_wyscigach
{
	internal class Guy
	{
		public string Name; // nazwa faceta
		public int Cash; // jak duzo pieniedzy posiada
		public Bet MyBet; // instancja klasy bet przechowujaca dane o zakladzie

		public RadioButton MyRadioButton; // moje pole wyboru
		public Label MyLabel; // moja etykieta

		// ustaw moje pole tekstowe na opis zakladu, a napis obok pola wyboru tak, aby pokazywal ilosc pieniedzy ("Janek ma 43 zl")
		public void UpdateLabels()
		{
			MyLabel.Text = MyBet != null ? MyBet.GetDescription() : Name + " nie zawarł zakładu";
			MyRadioButton.Text = Name + " ma " + Cash + " zł";
		}

		// wyczysc moj zaklad, aby byl rowny zero
		public void ClearBet() => MyBet = null;

		// zwroc true, jezeli facet ma wystarczajaca ilosc pieniedzy aby obstawic
		public bool PlaceBet(int Amount, int Dog)
		{
			if (Cash >= Amount)
			{
				// ustal nowy zaklad i przechowuj go w polu MyBet
				MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
				return true;
			}
			else
			{
				return false;
			}
		}

		// popros o wyplate zakladu
		public void Collect(int Winner)
		{
			if (MyBet != null)
			{
				Cash += MyBet.PayOut(Winner + 1);
			}
		}
	}
}