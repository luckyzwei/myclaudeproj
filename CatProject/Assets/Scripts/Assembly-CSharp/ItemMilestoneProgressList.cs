using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMilestoneProgressList : MonoBehaviour
{
	[SerializeField]
	private Image SeasonMainIconImage;

	[SerializeField]
	private Text MilestoneProgressText;

	[SerializeField]
	private Slider MilestoneProgressSlider;

	[SerializeField]
	private ScrollRect MilestoneRewardListObj;

	[SerializeField]
	private GameObject MilestoneRewardPrefab;

	private List<ItemMilestoneReward> MilestoneRewardSlotList;

	private int SeasonInfoIdx;

	private int SeasonalRewardGroup;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void FocusToIndex(int idx)
	{
	}

	public void OnActivePremium()
	{
	}

	private void SetSeasonMainIcon(string iconKey)
	{
	}

	private void SetMilestoneProgressInfo(int curStep, int maxStep)
	{
	}

	private void SetMilestoneProgressText(int curStep, int maxStep)
	{
	}

	private void SetMilestoneProgressSlider(int curStep, int maxStep)
	{
	}

	private void SetMilestoneRewardList()
	{
	}
}
