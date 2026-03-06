using System;
using BackEnd;

public class BackendLogin
{
	private static BackendLogin _instance;

	private bool _isLoggedIn;

	private string _accessToken;

	public static BackendLogin Instance
	{
		get
		{
			if (_instance == null)
				_instance = new BackendLogin();
			return _instance;
		}
	}

	public bool CustomLogin(string id, string pw)
	{
		if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
			return false;
		_isLoggedIn = true;
		return true;
	}

	public void AsyncCustomLogin(string id, string pw, Action cbAction)
	{
		bool result = CustomLogin(id, pw);
		cbAction?.Invoke();
	}

	public void UpdateNickname(string nickname)
	{
		if (string.IsNullOrEmpty(nickname)) return;
	}

	public bool PlatformLogin(string token, FederationType federationType, bool isAutoLogin = false)
	{
		if (string.IsNullOrEmpty(token))
			return false;
		_isLoggedIn = true;
		_accessToken = token;
		return true;
	}

	public bool IsLogin()
	{
		return _isLoggedIn;
	}

	public bool IsAccessTokenAlive()
	{
		return _isLoggedIn && !string.IsNullOrEmpty(_accessToken);
	}

	public bool BackEndTokenLogin()
	{
		if (string.IsNullOrEmpty(_accessToken))
			return false;
		_isLoggedIn = true;
		return true;
	}

	public void AsyncBackEndTokenLogin(Action cbAction)
	{
		BackEndTokenLogin();
		cbAction?.Invoke();
	}

	public bool RefreshTheBackendToken()
	{
		if (!_isLoggedIn) return false;
		return true;
	}

	public void AsyncRefreshTheBackendToken(Action cbAction)
	{
		RefreshTheBackendToken();
		cbAction?.Invoke();
	}
}
