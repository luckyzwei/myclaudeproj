using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemArcadeMachineRewardInfo : MonoBehaviour
{
	[SerializeField]
	private List<Image> SlotImageList;

	[SerializeField]
	private Image RewardIconImage;

	[SerializeField]
	private Text RewardValueText;

	[SerializeField]
	private Image RewardTypeIconImage;

	[SerializeField]
	private Text RewardGetProbabilityText;

	private bool IsTimeReward;

	private List<int> LevelRewardValueList;

	public void Init(SeasonalRouletteRewardData rewardData, int level)
	{
		IsTimeReward = false;
		LevelRewardValueList = new List<int>();
		SetRewardLevelValue(level);
	}

	public void SetRewardLevelValue(int level)
	{
		if (LevelRewardValueList == null || level < 0 || level >= LevelRewardValueList.Count) return;
		int value = LevelRewardValueList[level];
		SetRewardValueText(value, IsTimeReward);
	}

	private void SetSlotImageList(List<int> currencyIdxList)
	{
		if (SlotImageList == null || currencyIdxList == null) return;
		for (int i = 0; i < SlotImageList.Count; i++)
		{
			if (SlotImageList[i] != null)
				SlotImageList[i].gameObject.SetActive(i < currencyIdxList.Count);
		}
	}

	private void SetRewardIconImage(string iconKey)
	{
		// Set icon from atlas by key
	}

	private void SetRewardValueText(int value, bool isTimeValue)
	{
		if (RewardValueText != null)
			RewardValueText.text = isTimeValue ? ProjectUtility.GetTimeStringFormattingShort(value) : value.ToString();
	}

	private void SetRewardGetProbabilityText(float probability)
	{
		if (RewardGetProbabilityText != null)
			RewardGetProbabilityText.text = $"{probability:F1}%";
	}
}
