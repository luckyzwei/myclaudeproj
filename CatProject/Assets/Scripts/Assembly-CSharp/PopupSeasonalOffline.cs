using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalOffline", false, false)]
public class PopupSeasonalOffline : UIBase
{
	private enum E_RewardGetType
	{
		Normal = 0,
		ViewAds = 1,
		UseGem = 2
	}

	[SerializeField]
	private Text CurOfflineTimeText;

	[SerializeField]
	private Text MaxOfflineTimeText;

	[SerializeField]
	private Slider OfflineTimeRatio;

	[SerializeField]
	private Text MultipleRewardReceiveText;

	[SerializeField]
	private Button MultipleRewardReceiveBtn;

	[SerializeField]
	private Text GemUseCostText;

	[SerializeField]
	private Text GemUseBtnText;

	[SerializeField]
	private Button GemUseBtn;

	[SerializeField]
	private GameObject OfflineRewardBox;

	[SerializeField]
	private GameObject OfflineRewardSlotPrefab;

	[SerializeField]
	private Transform RewardGoodsEffectStartTr;

	[SerializeField]
	private Transform RewardGoodsEffectEndTr;

	[Header("IAP")]
	[SerializeField]
	private ItemPopupNoAdsBanner NoAdsBanner;

	private Dictionary<int, BigInteger> OfflineRewardMap_PerMile;

	private List<ItemArticle> ItemArticleList;

	private int OfflineTimeSec;

	private bool IsRewarded;

	private int GEM_USE_REWARD_MULTIPLY;

	private int GEM_USE_COST_MULTIPLY;

	private int GemUseCost;

	private Dictionary<E_RewardGetType, int> RewardMultipleMap;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void Hide()
	{
	}

	public void Init(int offlineTimeSec, Dictionary<int, BigInteger> offlineRewardMap_PerMile)
	{
	}

	private void SetGemUseCostText(int useCost)
	{
	}

	private void SetOfflineTimeInfo(int curTimeSec, int maxTimeSec)
	{
	}

	private void SetOfflineRewardSlots(Dictionary<int, BigInteger> offlineReward_PerMile, int offlineTimeSec)
	{
	}

	private void OnClickedRewardReceiveBtn()
	{
	}

	private void OnClickedGemUseBtn()
	{
	}

	private void GetReward(E_RewardGetType getType)
	{
	}
}
