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

	public HUDType[] HudType => null;

	public bool IsScreenAction => false;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SyncData()
	{
	}

	public void OnClickSetting()
	{
	}

	private void OnClickMoney()
	{
	}

	private void OnClickCash()
	{
	}

	private void UpdateBoost(float value)
	{
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID idx)
	{
		return default(Vector3);
	}

	public override void SaveOringSortingData()
	{
	}

	public override void RecoverySortingData()
	{
	}

	public void ScreenAction(bool value)
	{
	}

	public override void CustomSortingOrder()
	{
	}

	public void ScreenTopOn(bool value)
	{
	}

	public bool IsScreenTopOn()
	{
		return false;
	}

	public void OnScreenActionStep()
	{
	}

	public void OnScreenActionComplete()
	{
	}
}
