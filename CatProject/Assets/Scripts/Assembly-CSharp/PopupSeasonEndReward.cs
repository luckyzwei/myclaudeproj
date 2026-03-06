using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupNotification", false, false)]
public class PopupSeasonEndReward : UIBase
{
	[SerializeField]
	private Text SeasonEndDescText;

	[SerializeField]
	private Text RewardRemainTimeText;

	[SerializeField]
	private Button RewardClaimBtn;

	[SerializeField]
	private GameObject NormalRewardRootObj;

	[SerializeField]
	private Transform NormalRewardListTr;

	[SerializeField]
	private GameObject PremiumRewardRootObj;

	[SerializeField]
	private Transform PremiumRewardListTr;

	[SerializeField]
	private GameObject ItemArticlePrefab;

	[SerializeField]
	private GameObject ClaimWarningObj;

	[SerializeField]
	private Text ClaimWarningText;

	private int PrevSeasonInfoIdx;

	private List<IRewardItemData> UnReceivedRewardItemList;

	private RewardItemData UnReceivedCompanyExpReward;

	private DateTime RewardClaimLimitTime;

	protected override void Awake()
	{
		base.Awake();
		UnReceivedRewardItemList = new List<IRewardItemData>();
		if (RewardClaimBtn != null) RewardClaimBtn.onClick.AddListener(OnClickedRewardClaimBtn);
	}

	private void Update()
	{
		if (RewardClaimLimitTime > DateTime.Now)
		{
			int remainSec = (int)(RewardClaimLimitTime - DateTime.Now).TotalSeconds;
			SetRewardRemainTimeText(remainSec);
		}
	}

	public void Init(int seasonInfoIndex)
	{
		PrevSeasonInfoIdx = seasonInfoIndex;

		var rewardList = MakeUnReceivedRewards(seasonInfoIndex);
		if (rewardList != null)
			SetOrCreateItemSlots(in rewardList);

		SetRewardClaimWarningMessage();
		Show();
	}

	private void SetOrCreateItemSlots(in List<(IRewardItemData itemData, bool bPremium)> itemList)
	{
		if (itemList == null) return;
		var normalList = new List<IRewardItemData>();
		var premiumList = new List<IRewardItemData>();
		for (int i = 0; i < itemList.Count; i++)
		{
			if (itemList[i].bPremium)
				premiumList.Add(itemList[i].itemData);
			else
				normalList.Add(itemList[i].itemData);
		}
		SetOrCreateItemSlots(in normalList, NormalRewardRootObj, NormalRewardListTr);
		SetOrCreateItemSlots(in premiumList, PremiumRewardRootObj, PremiumRewardListTr);
	}

	private void SetOrCreateItemSlots(in List<IRewardItemData> itemList, GameObject rootObj, Transform rootTr)
	{
		if (rootObj == null || rootTr == null || ItemArticlePrefab == null) return;
		bool hasItems = itemList != null && itemList.Count > 0;
		rootObj.SetActive(hasItems);
		if (!hasItems) return;
	}

	private void SetRewardRemainTimeText(int remainTimeSec)
	{
		if (RewardRemainTimeText != null)
			RewardRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainTimeSec);
	}

	private void SetRewardClaimWarningMessage()
	{
		if (ClaimWarningObj != null) ClaimWarningObj.SetActive(true);
	}

	private List<(IRewardItemData, bool)> MakeUnReceivedRewards(int seasonInfoIndex)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return null;
		var result = new List<(IRewardItemData, bool)>();
		return result;
	}

	public void OnClickedRewardClaimBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}
}
