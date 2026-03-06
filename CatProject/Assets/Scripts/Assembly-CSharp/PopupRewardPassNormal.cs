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
		base.Awake();
		Disposables = new CompositeDisposable();
		if (NormalPurchaseBtn != null) NormalPurchaseBtn.onClick.AddListener(OnClickedPurchaseBtn);
		if (DoubleSalePurchaseBtn != null) DoubleSalePurchaseBtn.onClick.AddListener(OnClickedPurchaseBtn);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public override void OnShowBefore()
	{
	}

	public void Init(E_PassType passType, int groupIdx, int orderIdx, Action onPurchaseBtnClick)
	{
		GroupIdx = groupIdx;
		OnClickPurchaseBtnEvent = onPurchaseBtnClick;
		SetCurReward(passType, orderIdx);
		SetPremiumRewardList(passType, groupIdx);

		bool isDoubleSale = IsDoubleSale(passType, groupIdx);
		if (NormalAreaObj != null) NormalAreaObj.SetActive(!isDoubleSale);
		if (DoubleSaleAreaObj != null) DoubleSaleAreaObj.SetActive(isDoubleSale);
		if (SaleAreaObj != null) SaleAreaObj.SetActive(false);

		var packageData = GetInAppPackageData(passType, groupIdx);
		if (packageData != null && Price != null)
			Price.text = packageData.ProductId;
	}

	private void SetCurReward(E_PassType passType, int orderIdx)
	{
		if (RewardItemArticle == null) return;
	}

	private void SetPremiumRewardList(E_PassType passType, int groupIdx)
	{
		if (PremiumRewardScrollRect == null || PremiumRewardItemPrefab == null) return;
	}

	private void SetScrollContentsPivot(int rewardCount)
	{
		if (PremiumRewardScrollRect == null) return;
		var content = PremiumRewardScrollRect.content;
		if (content == null) return;
		if (rewardCount <= 3)
			content.pivot = new Vector2(0.5f, 0.5f);
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
		OnClickPurchaseBtnEvent?.Invoke();
		Hide();
	}
}
