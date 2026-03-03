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
	}

	public void SetData(int orderIdx, bool bPlayAnim, Action<int> onClaimedMilestoneReward)
	{
	}

	public void ReadyAnimPlay(int orderIdx)
	{
	}

	public void OnAnimationEnd()
	{
	}

	public float GetAnimationDuration()
	{
		return 0f;
	}

	private void SetButtonState(bool isClearMilestone, bool isClaimedMilestone)
	{
	}

	private void SetMilestoneRewardIcon()
	{
	}

	private void UpdateRewardDataList()
	{
	}

	private void OnClickedMilestoneRewardInfo()
	{
	}

	private void OnClickedMilestoneRewardBtn()
	{
	}
}
