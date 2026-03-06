using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		ItemArticleList = new List<ItemArticle>();
		RewardMultipleMap = new Dictionary<E_RewardGetType, int>
		{
			{ E_RewardGetType.Normal, 1 },
			{ E_RewardGetType.ViewAds, 2 },
			{ E_RewardGetType.UseGem, 3 }
		};
		GEM_USE_REWARD_MULTIPLY = 3;
		GEM_USE_COST_MULTIPLY = 1;
		IsRewarded = false;

		if (MultipleRewardReceiveBtn != null) MultipleRewardReceiveBtn.onClick.AddListener(OnClickedRewardReceiveBtn);
		if (GemUseBtn != null) GemUseBtn.onClick.AddListener(OnClickedGemUseBtn);
	}

	public override void OnShowBefore()
	{
		IsRewarded = false;
	}

	public override void Hide()
	{
		if (!IsRewarded)
			GetReward(E_RewardGetType.Normal);
		base.Hide();
	}

	public void Init(int offlineTimeSec, Dictionary<int, BigInteger> offlineRewardMap_PerMile)
	{
		OfflineTimeSec = offlineTimeSec;
		OfflineRewardMap_PerMile = offlineRewardMap_PerMile;
		GemUseCost = GEM_USE_COST_MULTIPLY;

		SetOfflineTimeInfo(offlineTimeSec, 28800); // 8 hours max
		SetOfflineRewardSlots(offlineRewardMap_PerMile, offlineTimeSec);
		SetGemUseCostText(GemUseCost);
	}

	private void SetGemUseCostText(int useCost)
	{
		if (GemUseCostText != null) GemUseCostText.text = useCost.ToString();
	}

	private void SetOfflineTimeInfo(int curTimeSec, int maxTimeSec)
	{
		if (CurOfflineTimeText != null)
			CurOfflineTimeText.text = ProjectUtility.GetTimeStringFormattingShort(curTimeSec);
		if (MaxOfflineTimeText != null)
			MaxOfflineTimeText.text = ProjectUtility.GetTimeStringFormattingShort(maxTimeSec);
		if (OfflineTimeRatio != null && maxTimeSec > 0)
			OfflineTimeRatio.value = Mathf.Clamp01((float)curTimeSec / maxTimeSec);
	}

	private void SetOfflineRewardSlots(Dictionary<int, BigInteger> offlineReward_PerMile, int offlineTimeSec)
	{
		if (OfflineRewardBox == null || OfflineRewardSlotPrefab == null) return;
		// Clear existing slots
		if (ItemArticleList != null) ItemArticleList.Clear();
		// Create reward slots from offline reward data
	}

	private void OnClickedRewardReceiveBtn()
	{
		GetReward(E_RewardGetType.ViewAds);
	}

	private void OnClickedGemUseBtn()
	{
		GetReward(E_RewardGetType.UseGem);
	}

	private void GetReward(E_RewardGetType getType)
	{
		if (IsRewarded) return;
		IsRewarded = true;
		int multiply = RewardMultipleMap.ContainsKey(getType) ? RewardMultipleMap[getType] : 1;
		// Apply multiplied offline rewards to user data
		base.Hide();
	}
}
