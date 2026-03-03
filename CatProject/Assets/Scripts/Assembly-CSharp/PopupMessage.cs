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
	}

	public void Show(string title, string message, Action onYes = null, string yes_str_key = "str_yes", bool clickHide = true)
	{
	}

	private void OnClickYes()
	{
	}
}
