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
		base.Awake();
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
		if (RejectBtn != null) RejectBtn.onClick.AddListener(OnClickReject);
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	private void OnDisable()
	{
		isShowAds = false;
	}

	private void OnDestroy()
	{
	}

	public void Init(AdSupplySystem.ShowType type)
	{
		PopupShowType = type;
		isShowAds = false;
	}

	private void OnClickReward()
	{
		if (isShowAds) return;
		isShowAds = true;
		// Watch ad and get seasonal reward
		Hide();
	}

	private void ShowRewardGoodsEffect(int currency_idx, BigInteger value)
	{
		if (RewardGoodsEffectEndTr == null) return;
		// Play reward goods fly effect to RewardGoodsEffectEndTr
	}

	private void OnClickReject()
	{
		Hide();
	}

	public override void Hide()
	{
		base.Hide();
	}
}
