using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class GameCore
	{
		public abstract bool EnableBankAnalytics { get; set; }

		public abstract bool ShowNoAds { get; set; }
	}
}
