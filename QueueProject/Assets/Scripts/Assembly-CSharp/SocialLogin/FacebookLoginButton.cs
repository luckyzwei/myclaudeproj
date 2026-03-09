using Nakama;

namespace SocialLogin
{
	public class FacebookLoginButton : SocialLoginButton
	{
		protected override NakamaSocialLogin CreateSocialLoginPlatform()
		{
			return null;
		}

		protected override string GetConnectionId(IApiAccount account)
		{
			return null;
		}
	}
}
