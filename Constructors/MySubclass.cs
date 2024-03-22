namespace Constructors
{
	internal class MySubclass : MyBaseClass
	{
		public MySubclass(string baseClassNeedThis, int anotherValue) : base(baseClassNeedThis)
			=> System.Windows.Forms.MessageBox.Show("To jest klasa pochodna: " + baseClassNeedThis + " i " + anotherValue);
	}
}