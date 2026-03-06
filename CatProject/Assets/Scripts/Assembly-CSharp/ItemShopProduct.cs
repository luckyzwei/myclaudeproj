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
		disposables = new CompositeDisposable();
		if (cashBtn != null) cashBtn.onClick.AddListener(OnClickCash);
		if (gemBtn != null) gemBtn.onClick.AddListener(OnClickPurchase);
		if (freeBtn != null) freeBtn.onClick.AddListener(OnClickFree);
		if (adsBtn != null) adsBtn.onClick.AddListener(OnClickAds);
		if (keyBtn != null) keyBtn.onClick.AddListener(OnClickKey);
		if (moreBtn != null) moreBtn.onClick.AddListener(OnClickMoreGem);
		if (OtherBtn != null) OtherBtn.onClick.AddListener(OnClickOtherBtn);
		if (infoBtn != null) infoBtn.onClick.AddListener(OnClickInfo);
	}

	public void Set()
	{
		SetIdx(TableIdx);
	}

	public void ForceSet(int idx)
	{
		TableIdx = idx;
		SetIdx(idx);
	}

	public void ForceRegion(int region)
	{
		shopRewardRegion = region;
	}

	protected virtual void SetIdx(int idx, int region = -1)
	{
		ShopGoodsIdx = idx;
		if (region >= 0) shopRewardRegion = region;

		if (cashBtn != null) cashBtn.gameObject.SetActive(false);
		if (gemBtn != null) gemBtn.gameObject.SetActive(false);
		if (freeBtn != null) freeBtn.gameObject.SetActive(false);
		if (adsBtn != null) adsBtn.gameObject.SetActive(false);
		if (keyBtn != null) keyBtn.gameObject.SetActive(false);
		if (OtherBtn != null) OtherBtn.gameObject.SetActive(false);

		switch (myPriceType)
		{
			case PriceType.Cash:
				if (cashBtn != null) cashBtn.gameObject.SetActive(true);
				break;
			case PriceType.Purchase:
				if (gemBtn != null) gemBtn.gameObject.SetActive(true);
				break;
			case PriceType.Free:
				if (freeBtn != null) freeBtn.gameObject.SetActive(true);
				break;
			case PriceType.Ad:
				if (adsBtn != null) adsBtn.gameObject.SetActive(true);
				break;
			case PriceType.NormalKey:
			case PriceType.PremiumKey:
				if (keyBtn != null) keyBtn.gameObject.SetActive(true);
				break;
			case PriceType.Money:
				if (OtherBtn != null) OtherBtn.gameObject.SetActive(true);
				break;
		}
	}

	private void UpdateKeyCountInfo(int hasCount, int needCost)
	{
		if (keyBtnText != null)
			keyBtnText.text = hasCount + "/" + needCost;
	}

	public void SetParams(params object[] a_params)
	{
		LogUseGemParams = a_params;
	}

	public void OnClickMoreGem()
	{
		ProjectUtility.GotoInsufficientShop((int)Config.CurrencyID.Gem, 0, BigInteger.Zero);
	}

	private void OnClickInfo()
	{
		clickAction?.Invoke(ShopGoodsIdx);
	}

	private void OnClickAds()
	{
		ProjectUtility.ShowInterAdPage(TpMaxProp.AdInterType.None, () =>
		{
			purchaseAction?.Invoke();
		});
	}

	private void OnClickFree()
	{
		purchaseAction?.Invoke();
	}

	protected virtual void OnClickCash()
	{
		int needCash = GetNeedCashCost(PriceType.Cash);
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		BigInteger hasCash = root.UserData.Cash.Value;
		if (hasCash < needCash)
		{
			ProjectUtility.GotoInsufficientShop((int)Config.CurrencyID.Gem, 0, needCash - hasCash);
			return;
		}
		SendConsumeCashLog(needCash);
		purchaseAction?.Invoke();
	}

	private int GetNeedCashCost(PriceType priceType)
	{
		if (shopTd == null) return 0;
		return shopRewardValue;
	}

	private TpAnalyticsProp.LogCostCashType GetLogCostCashType()
	{
		return GetLogCostCashType(shopRewardType, shopRewardIdx);
	}

	private TpAnalyticsProp.LogCostCashType GetLogCostCashType(int rewardType, int rewardIdx)
	{
		return TpAnalyticsProp.LogCostCashType.None;
	}

	private void SendConsumeCashLog(int needCashCost)
	{
		var logType = GetLogCostCashType();
		ProjectUtility.ConsumeCashLog(needCashCost, logType, TpAnalyticsProp.LogCostCashPlace.None, LogUseGemParams);
	}

	private void OnClickOtherBtn()
	{
		purchaseAction?.Invoke();
	}

	private void OnClickPurchase()
	{
		CheckAndOpenOfferWall();
	}

	private void OnClickKey()
	{
		OpenManagerBox(myPriceType);
	}

	private BigInteger GetMainRewardValue(int rewardType, int rewardIdx, int rewardRegion, int rewardValue)
	{
		return new BigInteger(rewardValue);
	}

	private void OpenManagerBox(PriceType keyType)
	{
		purchaseAction?.Invoke();
	}

	private void CheckAndOpenOfferWall()
	{
		if (OpenOfferWall)
		{
			// Open offer wall
		}
		else
		{
			purchaseAction?.Invoke();
		}
	}

	public void ShowArrow()
	{
		isShowArrow = true;
		if (Arrow != null) Arrow.SetActive(true);
		PlayArrowTween();
	}

	public void HideArrow()
	{
		isShowArrow = false;
		if (Arrow != null) Arrow.SetActive(false);
		if (ArrowTweenSequence != null)
		{
			ArrowTweenSequence.Kill();
			ArrowTweenSequence = null;
		}
	}

	private void PlayArrowTween()
	{
		if (Arrow == null) return;
		if (ArrowTweenSequence != null) ArrowTweenSequence.Kill();
		var rt = Arrow.GetComponent<RectTransform>();
		if (rt == null) return;
		ArrowTweenSequence = DOTween.Sequence();
		ArrowTweenSequence.Append(rt.DOAnchorPosY(rt.anchoredPosition.y + 10f, 0.5f));
		ArrowTweenSequence.Append(rt.DOAnchorPosY(rt.anchoredPosition.y, 0.5f));
		ArrowTweenSequence.SetLoops(-1);
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
		if (ArrowTweenSequence != null)
		{
			ArrowTweenSequence.Kill();
			ArrowTweenSequence = null;
		}
	}

	private void OnDisable()
	{
		if (IsAutoReset)
			Reset();
	}

	public void SetIsAutoReset(bool isAutoReset)
	{
		IsAutoReset = isAutoReset;
	}

	public void Reset()
	{
		HideArrow();
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
		shopTd = null;
	}
}
