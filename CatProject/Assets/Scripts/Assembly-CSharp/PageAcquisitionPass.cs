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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	private void SetPassInfo(int passIdx)
	{
	}

	private void SetStageInfo()
	{
	}

	private void SetPurchaseInfo(int passIdx)
	{
	}

	private void SetAllClaimButtonState()
	{
	}

	private void OnClickBuyBtn()
	{
	}

	private void OnClickedClaimAllBtn()
	{
	}

	private void OnRewardedUpdate()
	{
	}
}
