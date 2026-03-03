using UnityEngine;
using anzu;

public class TpAnzuProp
{
	public string schema;

	private GameObject anzuSDKInstance;

	private bool isSandBox;

	public void Awake()
	{
	}

	private void OnHook(UriHookData data)
	{
	}
}
