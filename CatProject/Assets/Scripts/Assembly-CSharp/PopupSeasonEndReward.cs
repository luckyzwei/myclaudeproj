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
	}

	private void Update()
	{
	}

	public void Init(int seasonInfoIndex)
	{
	}

	private void SetOrCreateItemSlots(in List<(IRewardItemData itemData, bool bPremium)> itemList)
	{
	}

	private void SetOrCreateItemSlots(in List<IRewardItemData> itemList, GameObject rootObj, Transform rootTr)
	{
	}

	private void SetRewardRemainTimeText(int remainTimeSec)
	{
	}

	private void SetRewardClaimWarningMessage()
	{
	}

	private List<(IRewardItemData, bool)> MakeUnReceivedRewards(int seasonInfoIndex)
	{
		return null;
	}

	public void OnClickedRewardClaimBtn()
	{
	}
}
