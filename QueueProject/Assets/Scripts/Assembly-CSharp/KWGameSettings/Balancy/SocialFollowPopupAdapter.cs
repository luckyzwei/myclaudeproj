namespace KWGameSettings.Balancy
{
	public class SocialFollowPopupAdapter : SocialFollow
	{
		public override bool Enabled { get; set; }

		public override int ShowOnBoot { get; set; }

		public override int ShowAfterXGames { get; set; }

		public override string SocialPlatform { get; set; }

		public override string SocialUrl { get; set; }

		public override string RewardType { get; set; }

		public override int RewardAmount { get; set; }

		public override long OutOfAppMinTime { get; set; }

		public override bool TiktokBanEnabled { get; set; }

		public override string[] TiktokBanCountries { get; set; }

		public override string TiktokBanFallbackPlatform { get; set; }

		public override string TiktokBanFallbackUrl { get; set; }
	}
}
