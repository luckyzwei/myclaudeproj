using System;
using BackEnd;

public class TpBackEndProp
{
	private bool doUpdate;

	private Action initAction;

	public bool isInit { get; private set; }

	public void Update()
	{
	}

	private void ExceptionEvent(Exception e)
	{
	}

	private void InitResult(BackendReturnObject bro)
	{
	}

	public void Init()
	{
	}

	public bool CheckInit()
	{
		return false;
	}

	public void CustomLogin(string id, Action cbAction)
	{
	}

	public bool IsLogin()
	{
		return false;
	}

	public bool IsBackendTokenAlive()
	{
		return false;
	}

	public void BackendTokenLogin(Action cbAction)
	{
	}

	public bool RefreshTheBackendToken()
	{
		return false;
	}

	public bool PlatformLogin(Action logout)
	{
		return false;
	}

	public void CheckPost(Action cbAction)
	{
	}
}
