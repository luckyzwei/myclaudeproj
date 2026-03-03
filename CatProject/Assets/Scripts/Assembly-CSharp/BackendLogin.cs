using System;
using BackEnd;

public class BackendLogin
{
	private static BackendLogin _instance;

	public static BackendLogin Instance => null;

	public bool CustomLogin(string id, string pw)
	{
		return false;
	}

	public void AsyncCustomLogin(string id, string pw, Action cbAction)
	{
	}

	public void UpdateNickname(string nickname)
	{
	}

	public bool PlatformLogin(string token, FederationType federationType, bool isAutoLogin = false)
	{
		return false;
	}

	public bool IsLogin()
	{
		return false;
	}

	public bool IsAccessTokenAlive()
	{
		return false;
	}

	public bool BackEndTokenLogin()
	{
		return false;
	}

	public void AsyncBackEndTokenLogin(Action cbAction)
	{
	}

	public bool RefreshTheBackendToken()
	{
		return false;
	}

	public void AsyncRefreshTheBackendToken(Action cbAction)
	{
	}
}
