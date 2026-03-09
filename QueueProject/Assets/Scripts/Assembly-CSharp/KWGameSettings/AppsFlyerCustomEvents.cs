using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AppsFlyerCustomEvents
	{
		public abstract string EventName { get; set; }

		public abstract bool Enabled { get; set; }

		public abstract int[] EventValues { get; set; }
	}
}
