using Nakama;

namespace SocialLogin
{
	public class GoogleLoginButton : SocialLoginButton
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
