using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionPayout", false, false)]
public class PopupAcquisitionPayout : UIBase
{
	[SerializeField]
	private GameObject EmptyAcquisitionObj;

	[SerializeField]
	private GameObject AcquisitionObj;

	[SerializeField]
	private Button ClaimButton;

	[SerializeField]
	private Button InfoButton;

	[SerializeField]
	private GameObject RewardItemRoot;

	[SerializeField]
	private GameObject RewardItemPrefab;

	[SerializeField]
	private TimeComponent TimeComponent;

	[SerializeField]
	private Text LimitTimeText;

	private List<ItemArticle> RewardItemArticleList;

	private List<RewardItemData> RewardItemDataList;

	private int RegionMoneyIdx;

	protected override void Awake()
	{
		base.Awake();
		RewardItemArticleList = new List<ItemArticle>();
		RewardItemDataList = new List<RewardItemData>();
		if (ClaimButton != null) ClaimButton.onClick.AddListener(OnClaimButtonClick);
		if (InfoButton != null) InfoButton.onClick.AddListener(OnInfoButtonClick);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateTotalRewardItemDataList();
		UpdateRewardInfo();

		bool hasReward = RewardItemDataList != null && RewardItemDataList.Count > 0;
		if (EmptyAcquisitionObj != null) EmptyAcquisitionObj.SetActive(!hasReward);
		if (AcquisitionObj != null) AcquisitionObj.SetActive(hasReward);
	}

	public override void OnHideBefore()
	{
		RewardItemDataList.Clear();
	}

	private void SetTimeInfo(DateTime lastRewardGetTime)
	{
		if (LimitTimeText == null) return;
		var elapsed = DateTime.UtcNow - lastRewardGetTime;
		int remainSec = Mathf.Max(0, (int)(86400 - elapsed.TotalSeconds));
		LimitTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}

	private void UpdateRewardInfo()
	{
		if (RewardItemRoot == null || RewardItemPrefab == null) return;
		if (RewardItemDataList == null) return;

		while (RewardItemArticleList.Count < RewardItemDataList.Count)
		{
			var obj = Instantiate(RewardItemPrefab, RewardItemRoot.transform);
			var article = obj.GetComponent<ItemArticle>();
			if (article != null) RewardItemArticleList.Add(article);
		}

		for (int i = 0; i < RewardItemArticleList.Count; i++)
		{
			if (RewardItemArticleList[i] != null)
				RewardItemArticleList[i].gameObject.SetActive(i < RewardItemDataList.Count);
		}
	}

	private void UpdateTotalRewardItemDataList()
	{
		RewardItemDataList.Clear();
		var saleRewards = MakeSaleRewardItemDataList();
		if (saleRewards != null)
			RewardItemDataList.AddRange(saleRewards);
	}

	private List<RewardItemData> MakeSaleRewardItemDataList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return null;
		var result = new List<RewardItemData>();
		return result;
	}

	private void OnClaimButtonClick()
	{
		ClaimIdleReward(true);
	}

	private void ClaimIdleReward(bool isReceiveAll)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		Hide();
	}

	private void OnInfoButtonClick()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
