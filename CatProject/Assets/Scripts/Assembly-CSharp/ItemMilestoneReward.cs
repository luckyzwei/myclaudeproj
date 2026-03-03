using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemMilestoneReward : MonoBehaviour
{
	[SerializeField]
	private Text RewardCountText;

	[SerializeField]
	private Text MilestoneProgressStepText;

	[SerializeField]
	private Slider MilestoneProgressSlider;

	[SerializeField]
	private ItemPassReward ItemPassReward_Normal;

	[SerializeField]
	private ItemPassReward ItemPassReward_Premium;

	private int RewardTableIdx;

	public void SetData(int seasonInfoIdx, SeasonalRewardData rewardTable)
	{
	}

	public void OnActivePremium()
	{
	}

	private void UpdateMilestoneProgress(int curSlotIndex, int milestoneStepIndex, int maxStepCount)
	{
	}

	private void SetMilestoneProgressStepText(int step)
	{
	}

	private void SetMilestoneProgressRatio(float ratio)
	{
	}

	private void OnClickedRewardClaimBtn(int rewardTableIdx, bool bPremium)
	{
	}

	private void UpdateSlotState(bool bPlayAni)
	{
	}
}
