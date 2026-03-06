using System;
using Treeplla;
using UnityEngine;
using UnityEngine.Networking;
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
		base.Awake();
		autoSave = false;

		if (GoogleLoginBtn != null) GoogleLoginBtn.onClick.AddListener(OnClickGoogleLogin);
		if (AppleLoginBtn != null) AppleLoginBtn.onClick.AddListener(OnClickAppleLogin);
		if (SaveBtn != null) SaveBtn.onClick.AddListener(OnClickSave);
		if (LoadBtn != null) LoadBtn.onClick.AddListener(OnClickLoad);
		if (LogOutBtn != null) LogOutBtn.onClick.AddListener(OnClickLogout);
		if (DelBtn != null) DelBtn.onClick.AddListener(OnClickAccountDelete);
		if (TestBtn != null) TestBtn.onClick.AddListener(Test);
		if (PostBtn != null) PostBtn.onClick.AddListener(OnClickPost);
	}

	public override void OnShowBefore()
	{
		ShowLogin(true);
		ShowUserInfo(false);
		CheckPost();
	}

	private void CheckPost()
	{
		if (PostRoot != null) PostRoot.SetActive(false);
	}

	public override void OnHideAfter()
	{
		if (autoSave)
		{
			autoSave = false;
			OnClickSave();
		}
	}

	public void SetAutoSave(bool value)
	{
		autoSave = value;
	}

	private void OnClickGoogleLogin()
	{
		cb_LoginCallback?.Invoke(true);
	}

	private void OnClickAppleLogin()
	{
		cb_LoginCallback?.Invoke(true);
	}

	private void ShowLogin(bool value)
	{
		if (GoogleLoginBtn != null) GoogleLoginBtn.gameObject.SetActive(value);
		if (AppleLoginBtn != null)
		{
			#if UNITY_IOS
			AppleLoginBtn.gameObject.SetActive(value);
			#else
			AppleLoginBtn.gameObject.SetActive(false);
			#endif
		}
		if (SaveRoot != null) SaveRoot.SetActive(!value);
		if (LoadRoot != null) LoadRoot.SetActive(!value);
	}

	private void ShowUserInfo(bool value)
	{
		if (UserInfoText != null)
		{
			UserInfoText.text = value ? "" : "";
		}
	}

	private void OnClickSave()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickLoad()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickLogout()
	{
		ShowLogin(true);
		ShowUserInfo(false);
	}

	private void OnClickAccountDelete()
	{
		ShowLogin(true);
		ShowUserInfo(false);
	}

	private string EscapeURL(string url)
	{
		return UnityWebRequest.EscapeURL(url);
	}

	private void Test()
	{
		Debug.Log("[PopupDataSave] Test");
	}

	private void ReloadData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void OnClickPost()
	{
		OpenMailBox();
	}

	private void OpenMailBox()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMailBox>();
	}
}
