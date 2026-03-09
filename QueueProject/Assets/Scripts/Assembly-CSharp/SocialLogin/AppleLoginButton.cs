using Nakama;

namespace SocialLogin
{
	public class AppleLoginButton : SocialLoginButton
	{
		protected override void Awake()
		{
		}

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
