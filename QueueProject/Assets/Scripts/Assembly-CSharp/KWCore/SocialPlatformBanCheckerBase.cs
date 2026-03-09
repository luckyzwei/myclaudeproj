namespace KWCore
{
	public abstract class SocialPlatformBanCheckerBase
	{
		public abstract bool IsSocialPlatformBanned();

		public abstract string GetFallbackSocialMediaName();

		public abstract string GetFallbackSocialMediaUrl();
	}
}
