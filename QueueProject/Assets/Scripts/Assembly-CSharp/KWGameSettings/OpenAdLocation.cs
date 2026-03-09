using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class OpenAdLocation
	{
		public abstract string Location { get; set; }

		public abstract bool CanShow { get; set; }

		public abstract float Probability { get; set; }
	}
}
