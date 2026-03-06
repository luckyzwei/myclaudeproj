using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageFAQ", false, false)]
public class PageFAQ : UIBase
{
	[SerializeField]
	private Button btn_GoBack;

	[SerializeField]
	private Button btn_Forward;

	[SerializeField]
	private Button btn_Close;

	[SerializeField]
	private Button btn_Mail;

	[SerializeField]
	private Image imgWebSize;

	private WebViewObject webViewObject;

	private Action cb_mail;

	private float timer;

	protected override void Awake()
	{
		base.Awake();
		if (btn_GoBack != null) btn_GoBack.onClick.AddListener(() => OnClick_Arrow("GoBack"));
		if (btn_Forward != null) btn_Forward.onClick.AddListener(() => OnClick_Arrow("Forward"));
		if (btn_Close != null) btn_Close.onClick.AddListener(OnClick_Close);
		if (btn_Mail != null) btn_Mail.onClick.AddListener(OnClick_Mail);
	}

	public override void Hide()
	{
		if (webViewObject != null)
		{
			webViewObject.SetVisibility(false);
			Destroy(webViewObject.gameObject);
			webViewObject = null;
		}
		base.Hide();
	}

	private void Update()
	{
		Redraw_Arrow();
	}

	public void ShowFAQ(Action cbMail)
	{
		cb_mail = cbMail;
		timer = 0f;
		Redraw_Arrow();
		Show();
	}

	private void Redraw_Arrow()
	{
		if (btn_GoBack != null) btn_GoBack.interactable = webViewObject != null;
		if (btn_Forward != null) btn_Forward.interactable = webViewObject != null;
	}

	private void OnClick_Arrow(string key)
	{
		if (webViewObject == null) return;
		if (key == "GoBack")
			webViewObject.GoBack();
		else if (key == "Forward")
			webViewObject.GoForward();
	}

	private void OnClick_Mail()
	{
		cb_mail?.Invoke();
	}

	private void OnClick_Close()
	{
		Hide();
	}
}
