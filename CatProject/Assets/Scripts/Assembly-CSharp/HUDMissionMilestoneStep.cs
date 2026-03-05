using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMissionMilestoneStep : MonoBehaviour
{
	[SerializeField]
	private SliderTextComponent MilestoneProgress;

	[SerializeField]
	private List<Image> MilestoneRewardIconList;

	[SerializeField]
	private Button MilestoneRewardInfo;

	[SerializeField]
	private Button MilestoneRewardBtn;

	[SerializeField]
	private GameObject MilestoneRewardedObj;

	private bool IsPlayingAnim;

	private List<IRewardItemData> RewardDataList;

	private Action<int> OnClickedClaimedRewardEvent;

	public int OrderIdx { get; private set; }

	public bool IsClaimable { get; private set; }

	private void Awake()
	{
		if (MilestoneRewardInfo != null)
			MilestoneRewardInfo.onClick.AddListener(OnClickedMilestoneRewardInfo);
		if (MilestoneRewardBtn != null)
			MilestoneRewardBtn.onClick.AddListener(OnClickedMilestoneRewardBtn);
	}

	public void SetData(int orderIdx, bool bPlayAnim, Action<int> onClaimedMilestoneReward)
	{
		OrderIdx = orderIdx;
		OnClickedClaimedRewardEvent = onClaimedMilestoneReward;
		UpdateRewardDataList();
		SetMilestoneRewardIcon();
	}

	public void ReadyAnimPlay(int orderIdx)
	{
		OrderIdx = orderIdx;
		IsPlayingAnim = true;
	}

	public void OnAnimationEnd()
	{
		IsPlayingAnim = false;
	}

	public float GetAnimationDuration()
	{
		return 0.5f;
	}

	private void SetButtonState(bool isClearMilestone, bool isClaimedMilestone)
	{
		IsClaimable = isClearMilestone && !isClaimedMilestone;
		if (MilestoneRewardBtn != null)
			MilestoneRewardBtn.gameObject.SetActive(IsClaimable);
		if (MilestoneRewardedObj != null)
			MilestoneRewardedObj.SetActive(isClaimedMilestone);
	}

	private void SetMilestoneRewardIcon()
	{
		// Set reward icons from RewardDataList
	}

	private void UpdateRewardDataList()
	{
		if (RewardDataList == null)
			RewardDataList = new List<IRewardItemData>();
		RewardDataList.Clear();
	}

	private void OnClickedMilestoneRewardInfo()
	{
		// Show milestone reward detail popup
	}

	private void OnClickedMilestoneRewardBtn()
	{
		if (!IsClaimable) return;
		OnClickedClaimedRewardEvent?.Invoke(OrderIdx);
	}
}
