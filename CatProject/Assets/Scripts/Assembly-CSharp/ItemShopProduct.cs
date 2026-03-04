using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using DG.Tweening;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopProduct : MonoBehaviour
{
	public enum PriceType
	{
		Purchase = 1,
		Cash = 2,
		Free = 3,
		Ad = 4,
		NormalKey = 5,
		PremiumKey = 6,
		Money = 7
	}

	[SerializeField]
	private int TableIdx;

	[SerializeField]
	private bool OpenOfferWall;

	[SerializeField]
	protected Text titleText;

	[SerializeField]
	protected Image iconImage;

	[SerializeField]
	protected Image iconImageShadow;

	[SerializeField]
	protected GameObject cardBoxObj;

	[SerializeField]
	protected CardBoxComponent cardBoxComponent;

	[SerializeField]
	protected Image rewardIcon;

	[SerializeField]
	protected Text rewardCnt;

	[SerializeField]
	protected GameObject remainTimeObj;

	[SerializeField]
	protected Text remainTimeText;

	[Header("promotion")]
	[SerializeField]
	private Text promotionCount;

	[SerializeField]
	private List<GameObject> promotionObjs;

	[Header("sale")]
	[SerializeField]
	private Text saleCount;

	[SerializeField]
	private GameObject saleObj;

	[Header("buttons")]
	[SerializeField]
	protected Button cashBtn;

	[SerializeField]
	protected Text cashBtnText;

	[Header("-------------------------")]
	[SerializeField]
	protected Button gemBtn;

	[SerializeField]
	protected Text gemBtnText;

	[Header("-----------현금, 젬 외 다른 재화 --------------")]
	[SerializeField]
	protected Button OtherBtn;

	[SerializeField]
	protected Text OtherBtnText;

	[SerializeField]
	protected Image OtherBtnIcon;

	[Header("-------------------------")]
	[SerializeField]
	protected Button freeBtn;

	[SerializeField]
	protected Text freeBtnText;

	[SerializeField]
	protected GameObject freeBtnRoot;

	[SerializeField]
	protected Text freeRemineText;

	[SerializeField]
	protected GameObject remainTextObj;

	[Header("-------------------------")]
	[SerializeField]
	protected Button moreBtn;

	[SerializeField]
	protected GameObject moreEventRoot;

	[SerializeField]
	protected Text moreEventText;

	[Header("-------------------------")]
	[SerializeField]
	protected Button keyBtn;

	[SerializeField]
	protected Image keyBtnIcon;

	[SerializeField]
	protected Text keyBtnText;

	[Header("-------------------------")]
	[SerializeField]
	protected Button adsBtn;

	[SerializeField]
	protected GameObject adsBtnIcon;

	[SerializeField]
	protected Text adsBtnText;

	[Header("-------------------------")]
	[SerializeField]
	protected GameObject Arrow;

	[SerializeField]
	protected GameObject CustomRewardGetRoot;

	[Space(5f)]
	[SerializeField]
	private Button infoBtn;

	private PriceType myPriceType;

	protected CompositeDisposable disposables;

	public Action<int> clickAction;

	public Action purchaseAction;

	public Action<RewardItemData> purchaseFailedAction;

	protected ShopGoodsData shopTd;

	protected int ShopGoodsIdx;

	private int shopRewardType;

	private int shopRewardIdx;

	private int shopRewardValue;

	private int shopRewardRegion;

	private bool isShowArrow;

	private object[] LogUseGemParams;

	private bool IsAutoReset;

	private Sequence ArrowTweenSequence;

	private void Awake()
	{
	}

	public void Set()
	{
	}

	public void ForceSet(int idx)
	{
	}

	public void ForceRegion(int region)
	{
	}

	protected virtual void SetIdx(int idx, int region = -1)
	{
	}

	private void UpdateKeyCountInfo(int hasCount, int needCost)
	{
	}

	public void SetParams(params object[] a_params)
	{
	}

	public void OnClickMoreGem()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickAds()
	{
	}

	private void OnClickFree()
	{
	}

	protected virtual void OnClickCash()
	{
	}

	private int GetNeedCashCost(PriceType priceType)
	{
		return 0;
	}

	private TpAnalyticsProp.LogCostCashType GetLogCostCashType()
	{
		return default(TpAnalyticsProp.LogCostCashType);
	}

	private TpAnalyticsProp.LogCostCashType GetLogCostCashType(int rewardType, int rewardIdx)
	{
		return default(TpAnalyticsProp.LogCostCashType);
	}

	private void SendConsumeCashLog(int needCashCost)
	{
	}

	private void OnClickOtherBtn()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickKey()
	{
	}

	private BigInteger GetMainRewardValue(int rewardType, int rewardIdx, int rewardRegion, int rewardValue)
	{
		return default(BigInteger);
	}

	private void OpenManagerBox(PriceType keyType)
	{
	}

	private void CheckAndOpenOfferWall()
	{
	}

	public void ShowArrow()
	{
	}

	public void HideArrow()
	{
	}

	private void PlayArrowTween()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void SetIsAutoReset(bool isAutoReset)
	{
	}

	public void Reset()
	{
	}
}
