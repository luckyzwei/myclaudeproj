using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMessage", false, false)]
public class PopupMessage : UIBase
{
	[SerializeField]
	private Text textTitle;

	[SerializeField]
	private Text textMessage;

	[SerializeField]
	private Text textYesBtn;

	[SerializeField]
	private Button YesBtn;

	private Action OnYes;

	private bool ClickHide;

	protected override void Awake()
	{
		base.Awake();
		if (YesBtn != null) YesBtn.onClick.AddListener(OnClickYes);
	}

	public void Show(string title, string message, Action onYes = null, string yes_str_key = "str_yes", bool clickHide = true)
	{
		OnYes = onYes;
		ClickHide = clickHide;
		if (textTitle != null) textTitle.text = title;
		if (textMessage != null) textMessage.text = message;
		if (textYesBtn != null) textYesBtn.text = yes_str_key;
		Show();
	}

	private void OnClickYes()
	{
		OnYes?.Invoke();
		if (ClickHide) Hide();
	}
}
