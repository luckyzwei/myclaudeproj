using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAuctionOrganize", false, false)]
public class PageAuctionOrganize : UIBase
{
	[Header("LevelInfo")]
	[SerializeField]
	private Text RoundCountText;

	[SerializeField]
	private Text TotalCoinText;

	[Header("EquipInfo")]
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject AddManagerItem;

	[Header("Btn")]
	[SerializeField]
	private Button PlayBtn;

	[SerializeField]
	private Text UseStamina;

	[SerializeField]
	private Button ResetBtn;

	[SerializeField]
	private Button AutoOrganizeBtn;

	[Header("HUD")]
	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text StaminaRemainTime;

	[SerializeField]
	private GameObject StaminaTimeRoot;

	[SerializeField]
	private Button StanimaShopBtn;

	[SerializeField]
	private Text GemText;

	[SerializeField]
	private Button GemShopBtn;

	[SerializeField]
	private GameObject Point2xTrialNotiObj;

	[SerializeField]
	private Button Point2xTrialBtn;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void UpdateRoundSlot()
	{
	}

	private void OnClickAuto()
	{
	}

	private void OnClickSpy()
	{
	}

	private void OnClickStartAuction()
	{
	}

	private void OnClickReset()
	{
	}

	private void OnClickStaminaShop()
	{
	}

	private void OnClickGemShop()
	{
	}

	private void OnClickPoint2xTrial()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
