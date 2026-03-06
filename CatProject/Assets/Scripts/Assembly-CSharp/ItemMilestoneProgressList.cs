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
		MilestoneRewardSlotList = new List<ItemMilestoneReward>();
	}

	public void Init()
	{
		SetMilestoneRewardList();
	}

	public void FocusToIndex(int idx)
	{
		if (MilestoneRewardListObj == null || MilestoneRewardSlotList == null) return;
		if (idx < 0 || idx >= MilestoneRewardSlotList.Count) return;
		float normalizedPos = MilestoneRewardSlotList.Count > 1 ? (float)idx / (MilestoneRewardSlotList.Count - 1) : 0f;
		MilestoneRewardListObj.horizontalNormalizedPosition = normalizedPos;
	}

	public void OnActivePremium()
	{
		if (MilestoneRewardSlotList == null) return;
		for (int i = 0; i < MilestoneRewardSlotList.Count; i++)
		{
			if (MilestoneRewardSlotList[i] != null)
				MilestoneRewardSlotList[i].OnActivePremium();
		}
	}

	private void SetSeasonMainIcon(string iconKey)
	{
	}

	private void SetMilestoneProgressInfo(int curStep, int maxStep)
	{
		SetMilestoneProgressText(curStep, maxStep);
		SetMilestoneProgressSlider(curStep, maxStep);
	}

	private void SetMilestoneProgressText(int curStep, int maxStep)
	{
		if (MilestoneProgressText != null)
			MilestoneProgressText.text = curStep + "/" + maxStep;
	}

	private void SetMilestoneProgressSlider(int curStep, int maxStep)
	{
		if (MilestoneProgressSlider != null)
			MilestoneProgressSlider.value = maxStep > 0 ? Mathf.Clamp01((float)curStep / maxStep) : 0f;
	}

	private void SetMilestoneRewardList()
	{
	}
}
