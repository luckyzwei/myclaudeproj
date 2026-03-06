using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		if (YesBtn != null) YesBtn.onClick.AddListener(OnClickYes);
		if (NoBtn != null) NoBtn.onClick.AddListener(OnClickNo);
		if (PurchaseBtn != null) PurchaseBtn.onClick.AddListener(OnClickYes);
	}

	public void Show(string title, string message, Action onYes = null, Action onNo = null, string yes_str_key = "str_get", string no_str_key = "str_cancel", bool clickHide = true)
	{
		OnYes = onYes;
		OnNo = onNo;
		ClickHide = clickHide;

		if (textTitle != null) textTitle.text = title;
		if (textMessage != null) textMessage.text = message;
		if (textYesBtn != null) textYesBtn.text = yes_str_key;
		if (textNoBtn != null) textNoBtn.text = no_str_key;

		SetButtonType(false);
		base.Show();
	}

	public void ShowText(string title, string message, Action onYes = null, Action onNo = null, string yes_str_key = "str_get", string no_str_key = "str_cancel", bool clickHide = true)
	{
		OnYes = onYes;
		OnNo = onNo;
		ClickHide = clickHide;

		if (textTitle != null) textTitle.text = title;
		if (textMessage != null) textMessage.text = message;
		if (textYesBtn != null) textYesBtn.text = yes_str_key;
		if (textNoBtn != null) textNoBtn.text = no_str_key;

		SetButtonType(false);
		base.Show();
	}

	public void ShowLimitMoney(int region, Action onYes = null, Action onNo = null)
	{
		OnYes = onYes;
		OnNo = onNo;
		ClickHide = true;

		if (textTitle != null) textTitle.text = "";
		if (textMessage != null) textMessage.text = "";

		SetButtonType(false);
		base.Show();
	}

	public void ShowGemPurchase(string title, string message, BigInteger price, Action onYes = null, Action onNo = null, bool clickHide = true)
	{
		OnYes = onYes;
		OnNo = onNo;
		ClickHide = clickHide;

		if (textTitle != null) textTitle.text = title;
		if (textMessage != null) textMessage.text = message;
		if (textPurchaseBtn != null) textPurchaseBtn.text = ProjectUtility.GetThousandCommaText(price);

		SetButtonType(true);
		base.Show();
	}

	private void SetButtonType(bool isPurchase)
	{
		if (YesBtn != null) YesBtn.gameObject.SetActive(!isPurchase);
		if (PurchaseBtn != null) PurchaseBtn.gameObject.SetActive(isPurchase);
	}

	private void OnClickYes()
	{
		OnYes?.Invoke();
		if (ClickHide) Hide();
	}

	private void OnClickNo()
	{
		OnNo?.Invoke();
		if (ClickHide) Hide();
	}
}
