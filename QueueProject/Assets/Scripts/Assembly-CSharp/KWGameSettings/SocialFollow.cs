using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class SocialFollow
	{
		public abstract bool Enabled { get; set; }

		public abstract int ShowOnBoot { get; set; }

		public abstract int ShowAfterXGames { get; set; }

		public abstract string SocialPlatform { get; set; }

		public abstract string SocialUrl { get; set; }

		public abstract string RewardType { get; set; }

		public abstract int RewardAmount { get; set; }

		public abstract long OutOfAppMinTime { get; set; }

		public abstract bool TiktokBanEnabled { get; set; }

		public abstract string[] TiktokBanCountries { get; set; }

		public abstract string TiktokBanFallbackPlatform { get; set; }

		public abstract string TiktokBanFallbackUrl { get; set; }
	}
}
