using System;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardPassNormal", false, false)]
public class PopupRewardPassNormal : UIBase
{
	public enum E_PassType
	{
		None = 0,
		PlayerLvPass = 1,
		AcqPass = 2,
		AuctionPass = 3
	}

	[Header("Normal")]
	[SerializeField]
	private GameObject NormalAreaObj;

	[SerializeField]
	private Button NormalPurchaseBtn;

	[SerializeField]
	private Text Price;

	[Header("Sale")]
	[SerializeField]
	private GameObject SaleAreaObj;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text SaleText;

	[Header("DoubleSale")]
	[SerializeField]
	private GameObject DoubleSaleAreaObj;

	[SerializeField]
	private Button DoubleSalePurchaseBtn;

	[SerializeField]
	private Text DoubleSaleText1;

	[SerializeField]
	private Text DoubleSaleText2;

	[SerializeField]
	private Text DoubleSalePrice;

	[SerializeField]
	private Text DoubleSalePrice1;

	[SerializeField]
	private Text DoubleSalePrice2;

	[SerializeField]
	private Text DoubleSaleRemainTime;

	[Header("NormalReward")]
	[SerializeField]
	private ItemArticle RewardItemArticle;

	[Header("PremiumReward")]
	[SerializeField]
	private GameObject PremiumRewardItemPrefab;

	[SerializeField]
	private ScrollRect PremiumRewardScrollRect;

	[SerializeField]
	private GameObject PremiumTotalGemObj;

	[SerializeField]
	private Text PremiumTotalGemText;

	private int GroupIdx;

	private Action OnClickPurchaseBtnEvent;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void Init(E_PassType passType, int groupIdx, int orderIdx, Action onPurchaseBtnClick)
	{
	}

	private void SetCurReward(E_PassType passType, int orderIdx)
	{
	}

	private void SetPremiumRewardList(E_PassType passType, int groupIdx)
	{
	}

	private void SetScrollContentsPivot(int rewardCount)
	{
	}

	private InAppPackageData GetInAppPackageData(E_PassType passType, int groupIdx)
	{
		return null;
	}

	private bool IsDoubleSale(E_PassType passType, int groupIdx)
	{
		return false;
	}

	private void OnClickedPurchaseBtn()
	{
	}
}
