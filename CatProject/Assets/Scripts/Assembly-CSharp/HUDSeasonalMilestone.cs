using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HUDSeasonalMilestone : MonoBehaviour
{
	[Header("TopRewardProgress")]
	[SerializeField]
	private List<ItemHUDSeasonalMilestoneStep> MilestoneTopRewardSlotList;

	[SerializeField]
	private Slider MilestoneStepRewardProgress;

	[Header("BottomRewardProgress")]
	[SerializeField]
	private ItemMilestoneProgress MilestoneProgress;

	[SerializeField]
	private GameObject AllRewardedCheckBox;

	[Header("RewardPopup")]
	[SerializeField]
	private Button MilestoneDetailPopupBtn;

	private readonly int TOP_PROGRESS_SHOW_COUNT;

	private List<int> TopProgressStepList;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		if (MilestoneDetailPopupBtn != null)
			MilestoneDetailPopupBtn.onClick.AddListener(OnClickedMilestoneDetailPopupBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init()
	{
		TopProgressStepList = MakeTopProgressStepList();
		UpdateTopProgress();
		UpdateAllRewarded();
	}

	private void UpdateAllRewarded()
	{
		if (AllRewardedCheckBox != null)
			AllRewardedCheckBox.SetActive(false);
	}

	private void UpdateTopProgress()
	{
		if (TopProgressStepList == null) return;
		SetTopProgressInfo(TopProgressStepList);
	}

	private void SetTopProgressInfo(List<int> showStepList)
	{
		if (MilestoneTopRewardSlotList == null || showStepList == null) return;
		for (int i = 0; i < MilestoneTopRewardSlotList.Count; i++)
		{
			if (MilestoneTopRewardSlotList[i] == null) continue;
			if (i < showStepList.Count)
			{
				MilestoneTopRewardSlotList[i].gameObject.SetActive(true);
			}
			else
			{
				MilestoneTopRewardSlotList[i].gameObject.SetActive(false);
			}
		}
		// Update progress slider
		if (MilestoneStepRewardProgress != null && showStepList.Count > 0)
			MilestoneStepRewardProgress.value = 0f;
	}

	private List<int> MakeTopProgressStepList()
	{
		var list = new List<int>();
		// Build step list from milestone data
		return list;
	}

	private void OnClickedMilestoneDetailPopupBtn()
	{
		// Open milestone detail popup
	}
}
