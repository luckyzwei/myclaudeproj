using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemMilestoneRewardClaimBox : MonoBehaviour
{
	public static readonly int REWARD_SLOT_COUNT;

	[SerializeField]
	private Slider RewardProgressSlider;

	[SerializeField]
	private List<ItemMilestoneRewardClaimSlot> RewardSlotList;

	public void SetRewardClaimSlots(List<SeasonalRewardData> rewardData)
	{
	}

	private void SetRewardProgressSliderValue(float ratio)
	{
	}

	private ItemMilestoneRewardClaimSlot.E_MilestoneRewardSlotState GetMilestoneRewardType(int rewardIdx)
	{
		return default(ItemMilestoneRewardClaimSlot.E_MilestoneRewardSlotState);
	}
}
