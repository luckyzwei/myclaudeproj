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
	}

	public override void Hide()
	{
	}

	private void Update()
	{
	}

	public void ShowFAQ(Action cbMail)
	{
	}

	private void Redraw_Arrow()
	{
	}

	private void OnClick_Arrow(string key)
	{
	}

	private void OnClick_Mail()
	{
	}

	private void OnClick_Close()
	{
	}
}
