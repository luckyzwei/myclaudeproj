using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalAdsSupply", false, false)]
public class PopupSeasonalAdsSupply : UIBase
{
	public enum ShowType
	{
		HUD = 0,
		VIP = 1
	}

	[SerializeField]
	private Image CurrencyImg;

	[SerializeField]
	private Text RewardText;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button RejectBtn;

	[SerializeField]
	private Transform RewardGoodsEffectEndTr;

	[Header("IAP")]
	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	private AdSupplySystem.ShowType PopupShowType;

	private bool isShowAds;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(AdSupplySystem.ShowType type)
	{
	}

	private void OnClickReward()
	{
	}

	private void ShowRewardGoodsEffect(int currency_idx, BigInteger value)
	{
	}

	private void OnClickReject()
	{
	}

	public override void Hide()
	{
	}
}
