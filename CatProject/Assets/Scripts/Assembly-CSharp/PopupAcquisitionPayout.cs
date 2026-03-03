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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void SetTimeInfo(DateTime lastRewardGetTime)
	{
	}

	private void UpdateRewardInfo()
	{
	}

	private void UpdateTotalRewardItemDataList()
	{
	}

	private List<RewardItemData> MakeSaleRewardItemDataList()
	{
		return null;
	}

	private void OnClaimButtonClick()
	{
	}

	private void ClaimIdleReward(bool isReceiveAll)
	{
	}

	private void OnInfoButtonClick()
	{
	}
}
