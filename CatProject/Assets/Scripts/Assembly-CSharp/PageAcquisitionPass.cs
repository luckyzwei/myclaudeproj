using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionPass", false, false)]
public class PageAcquisitionPass : UIBase
{
	[SerializeField]
	private Text CurBizAcqStageText;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Text PriceText;

	[Header("ClaimAllBtn")]
	[SerializeField]
	private GameObject ClaimAllObj;

	[SerializeField]
	private Button ClaimAllBtn;

	[Header("Sale")]
	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text BeforePriceText;

	[SerializeField]
	private Text SaleRatioText;

	[Header("PurchaseObj")]
	[SerializeField]
	private GameObject PurchaseObj;

	[SerializeField]
	private Animator PurchaseAnimator;

	[Header("PassItem")]
	[SerializeField]
	private ScrollRect ScrollRect;

	[SerializeField]
	private GameObject PassItemPrefab;

	private List<ItemAcquisitionPass> PassItems;

	private int PassGroupIdx;

	private int PassStepCount;

	private bool IsNoAds;

	protected override void Awake()
	{
		base.Awake();
		PassItems = new List<ItemAcquisitionPass>();
		IsNoAds = false;
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBuyBtn);
		if (ClaimAllBtn != null) ClaimAllBtn.onClick.AddListener(OnClickedClaimAllBtn);
	}

	public override void OnShowBefore()
	{
		SetStageInfo();
		SetPassInfo(PassGroupIdx);
		SetPurchaseInfo(PassGroupIdx);
		SetAllClaimButtonState();
	}

	public override void OnHideBefore()
	{
		// Cleanup before hide
	}

	public override void OnRefresh()
	{
		OnRewardedUpdate();
	}

	private void SetPassInfo(int passIdx)
	{
		PassGroupIdx = passIdx;
		// Create pass items from PassItemPrefab if not created yet
	}

	private void SetStageInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (CurBizAcqStageText != null) CurBizAcqStageText.text = "";
	}

	private void SetPurchaseInfo(int passIdx)
	{
		bool isPurchased = IsNoAds;
		if (PurchaseObj != null) PurchaseObj.SetActive(!isPurchased);
		if (SaleObj != null) SaleObj.SetActive(false);
	}

	private void SetAllClaimButtonState()
	{
		bool hasClaimable = false;
		// Check if any pass items are claimable
		if (ClaimAllObj != null) ClaimAllObj.SetActive(hasClaimable);
	}

	private void OnClickBuyBtn()
	{
		// Process BizAcq pass purchase
	}

	private void OnClickedClaimAllBtn()
	{
		// Claim all available pass rewards
		OnRewardedUpdate();
	}

	private void OnRewardedUpdate()
	{
		SetAllClaimButtonState();
	}
}
