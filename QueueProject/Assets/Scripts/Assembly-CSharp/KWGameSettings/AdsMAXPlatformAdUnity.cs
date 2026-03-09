using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsMAXPlatformAdUnity
	{
		public abstract string AdUnit { get; set; }

		public abstract bool Enabled { get; set; }
	}
}
