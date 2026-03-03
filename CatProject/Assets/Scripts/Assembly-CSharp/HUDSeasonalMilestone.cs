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
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	private void UpdateAllRewarded()
	{
	}

	private void UpdateTopProgress()
	{
	}

	private void SetTopProgressInfo(List<int> showStepList)
	{
	}

	private List<int> MakeTopProgressStepList()
	{
		return null;
	}

	private void OnClickedMilestoneDetailPopupBtn()
	{
	}
}
