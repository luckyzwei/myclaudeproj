using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class FacebookSettings
	{
		public abstract FacebookCustomEventSettings[] CustomEvents { get; set; }
	}
}
