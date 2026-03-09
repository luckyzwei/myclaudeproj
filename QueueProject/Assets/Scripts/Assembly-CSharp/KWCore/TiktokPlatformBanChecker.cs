namespace KWCore
{
	public class TiktokPlatformBanChecker : SocialPlatformBanCheckerBase
	{
		public override bool IsSocialPlatformBanned()
		{
			return false;
		}

		public override string GetFallbackSocialMediaName()
		{
			return null;
		}

		public override string GetFallbackSocialMediaUrl()
		{
			return null;
		}
	}
}
