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
	}

	public void SetRewardLevelValue(int level)
	{
	}

	private void SetSlotImageList(List<int> currencyIdxList)
	{
	}

	private void SetRewardIconImage(string iconKey)
	{
	}

	private void SetRewardValueText(int value, bool isTimeValue)
	{
	}

	private void SetRewardGetProbabilityText(float probability)
	{
	}
}
