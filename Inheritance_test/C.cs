namespace Inheritance_test
{
	internal class C : B
	{
		public override string m3() => "C m3, " + (ivar + 6);

		public void ShowMessage() => System.Windows.Forms.MessageBox.Show("dziala");
	}
}