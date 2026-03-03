using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupDataSave", false, false)]
public class PopupDataSave : UIBase
{
	[Header("Login")]
	[SerializeField]
	private Button GoogleLoginBtn;

	[SerializeField]
	private Button AppleLoginBtn;

	[Header("Info")]
	[SerializeField]
	private Text UserInfoText;

	[SerializeField]
	private GameObject SaveRoot;

	[SerializeField]
	private GameObject LoadRoot;

	[SerializeField]
	private Button SaveBtn;

	[SerializeField]
	private Button LoadBtn;

	[SerializeField]
	private Button LogOutBtn;

	[SerializeField]
	private Button DelBtn;

	[SerializeField]
	private Button TestBtn;

	[SerializeField]
	private GameObject PostRoot;

	[SerializeField]
	private Button PostBtn;

	private bool autoSave;

	public Action<bool> cb_LoginCallback;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void CheckPost()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void SetAutoSave(bool value)
	{
	}

	private void OnClickGoogleLogin()
	{
	}

	private void OnClickAppleLogin()
	{
	}

	private void ShowLogin(bool value)
	{
	}

	private void ShowUserInfo(bool value)
	{
	}

	private void OnClickSave()
	{
	}

	private void OnClickLoad()
	{
	}

	private void OnClickLogout()
	{
	}

	private void OnClickAccountDelete()
	{
	}

	private string EscapeURL(string url)
	{
		return null;
	}

	private void Test()
	{
	}

	private void ReloadData()
	{
	}

	private void OnClickPost()
	{
	}

	private void OpenMailBox()
	{
	}
}
