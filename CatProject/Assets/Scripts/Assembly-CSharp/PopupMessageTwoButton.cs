using System;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMessageTwoButton", false, false)]
public class PopupMessageTwoButton : UIBase
{
	[SerializeField]
	private Text textTitle;

	[SerializeField]
	private Text textMessage;

	[SerializeField]
	private Text textYesBtn;

	[SerializeField]
	private Text textNoBtn;

	[SerializeField]
	private Text textPurchaseBtn;

	[SerializeField]
	private Button YesBtn;

	[SerializeField]
	private Button NoBtn;

	[SerializeField]
	private Button PurchaseBtn;

	private Action OnYes;

	private Action OnNo;

	private bool ClickHide;

	protected override void Awake()
	{
	}

	public void Show(string title, string message, Action onYes = null, Action onNo = null, string yes_str_key = "str_get", string no_str_key = "str_cancel", bool clickHide = true)
	{
	}

	public void ShowText(string title, string message, Action onYes = null, Action onNo = null, string yes_str_key = "str_get", string no_str_key = "str_cancel", bool clickHide = true)
	{
	}

	public void ShowLimitMoney(int region, Action onYes = null, Action onNo = null)
	{
	}

	public void ShowGemPurchase(string title, string message, BigInteger price, Action onYes = null, Action onNo = null, bool clickHide = true)
	{
	}

	private void SetButtonType(bool isPurchase)
	{
	}

	private void OnClickYes()
	{
	}

	private void OnClickNo()
	{
	}
}
