using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMissionMilestone : MonoBehaviour
{
	[SerializeField]
	private Image MilestoneRewardIcon;

	[SerializeField]
	private GameObject NextStepLinkObj;

	[SerializeField]
	private GameObject StepDoneObj;

	[SerializeField]
	private GameObject NotReachedObj;

	[SerializeField]
	private GameObject NowProgressStepObj;

	[SerializeField]
	private GameObject CanClaimObj;

	[SerializeField]
	private GameObject ClaimedObj;

	[SerializeField]
	private Button ClaimBtn;

	[SerializeField]
	private Button ShortCutBtn;

	[SerializeField]
	private ProgressText StepProgressText;

	[SerializeField]
	private List<ItemArticle> RewardItemList;

	private Action<int, bool> OnClaimedMilestoneReward;

	public int RegionIdx { get; private set; }

	public int OrderIdx { get; private set; }

	public bool IsClaimed { get; private set; }

	private void Awake()
	{
		if (ClaimBtn != null) ClaimBtn.onClick.AddListener(OnClickedClaimBtn);
		if (ShortCutBtn != null) ShortCutBtn.onClick.AddListener(OnClickedShortCutBtn);
	}

	public void SetData(int regionIdx, int orderIdx, bool isLastStep, Action<int, bool> onClaimedMilestoneReward)
	{
		RegionIdx = regionIdx;
		OrderIdx = orderIdx;
		OnClaimedMilestoneReward = onClaimedMilestoneReward;
		if (NextStepLinkObj != null) NextStepLinkObj.SetActive(!isLastStep);
		SetMilestoneReward();
		UpdateData();
	}

	public void UpdateData()
	{
	}

	private void SetMilestoneReward()
	{
	}

	private void OnClickedClaimBtn()
	{
		OnClaimedMilestoneReward?.Invoke(OrderIdx, true);
	}

	private void OnClickedShortCutBtn()
	{
	}
}
