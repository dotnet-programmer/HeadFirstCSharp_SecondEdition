﻿using System;

namespace Birds
{
	internal class Bird
	{
		public string Name { get; set; }

		public virtual void Fly()
			=> Console.WriteLine("Frr... frrr...");

		public override string ToString()
			=> "Ptak " + Name;
	}
}