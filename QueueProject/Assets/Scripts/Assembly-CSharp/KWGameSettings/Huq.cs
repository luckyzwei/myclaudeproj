using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Huq
	{
		public abstract bool Enabled { get; set; }

		public abstract string[] HuqCountries { get; set; }
	}
}
