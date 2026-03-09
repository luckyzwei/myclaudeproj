using System.Threading.Tasks;
using Facebook.Unity;
using Nakama;

public class NakamaSocialLoginFacebook : NakamaSocialLogin
{
	private const string PLATFORM_NAME = "facebook";

	protected override Task LinkSocial(ISession session, string token)
	{
		return null;
	}

	protected override Task<ISession> AuthSocial(string token)
	{
		return null;
	}

	protected override Task UnlinkSocial(ISession session)
	{
		return null;
	}

	protected override void PlatformLogin()
	{
	}

	public void DebugFBResult(ILoginResult result)
	{
	}

	public override string PlatformName()
	{
		return null;
	}

	protected override void PlatformFinishedActions(ConnectionResult result)
	{
	}
}
