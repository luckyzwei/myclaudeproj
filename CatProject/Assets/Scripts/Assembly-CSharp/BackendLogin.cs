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
		// Would call backend SDK login
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
		// Would call backend SDK to update nickname
	}

	public bool PlatformLogin(string token, FederationType federationType, bool isAutoLogin = false)
	{
		if (string.IsNullOrEmpty(token))
			return false;
		// Would call backend SDK platform login
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
		// Would call backend SDK token login
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
		// Would call backend SDK token refresh
		return true;
	}

	public void AsyncRefreshTheBackendToken(Action cbAction)
	{
		RefreshTheBackendToken();
		cbAction?.Invoke();
	}
}
