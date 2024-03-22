namespace Riddle_pool_5
{
	internal abstract class Picasso : Nose // Picasso
	{
		public virtual int Ear() => 7;

		public Picasso(string face) => this.face = face; // this.face

		public virtual string Face => face;  // get / return face;

		private readonly string face;
	}
}