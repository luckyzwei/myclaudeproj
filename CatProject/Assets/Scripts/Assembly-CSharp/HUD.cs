using DG.Tweening;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUD", true, false)]
public class HUD : UIBase, IScreenAction
{
	private HUDType[] aniType;

	[SerializeField]
	private Text MoneyText;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private Text MaterialText;

	[SerializeField]
	private Button MenuBtn;

	[SerializeField]
	private Button MoneyBtn;

	[SerializeField]
	private Button CashBtn;

	[SerializeField]
	private DOTweenAnimation appearTween;

	private bool appear;

	private bool screenAction;

	public HUDType[] HudType { get { return aniType; } }

	public bool IsScreenAction { get { return screenAction; } }

	protected override void Awake()
	{
		base.Awake();
		if (MenuBtn != null) MenuBtn.onClick.AddListener(OnClickSetting);
		if (MoneyBtn != null) MoneyBtn.onClick.AddListener(OnClickMoney);
		if (CashBtn != null) CashBtn.onClick.AddListener(OnClickCash);
	}

	public override void OnShowBefore()
	{
		SyncData();
	}

	public void SyncData()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (MoneyText != null && root.UserData.HUDMoney != null)
			MoneyText.text = root.UserData.HUDMoney.Value.ToString();
		if (CashText != null && root.UserData.HUDCash != null)
			CashText.text = root.UserData.HUDCash.Value.ToString();
	}

	public void OnClickSetting()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOption>();
	}

	private void OnClickMoney()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickCash()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void UpdateBoost(float value)
	{
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID idx)
	{
		switch (idx)
		{
			case Config.CurrencyID.Gold:
				return MoneyText != null ? MoneyText.transform.position : default(Vector3);
			case Config.CurrencyID.Cash:
				return CashText != null ? CashText.transform.position : default(Vector3);
			default:
				return default(Vector3);
		}
	}

	public override void SaveOringSortingData()
	{
	}

	public override void RecoverySortingData()
	{
	}

	public void ScreenAction(bool value)
	{
		screenAction = value;
		if (appearTween != null)
		{
			if (value)
				appearTween.DOPlayForward();
			else
				appearTween.DOPlayBackwards();
		}
		appear = !value;
	}

	public override void CustomSortingOrder()
	{
	}

	public void ScreenTopOn(bool value)
	{
		screenAction = value;
	}

	public bool IsScreenTopOn()
	{
		return screenAction;
	}

	public void OnScreenActionStep()
	{
	}

	public void OnScreenActionComplete()
	{
		screenAction = false;
		appear = true;
	}
}
