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
		if (rewardTable == null) return;
		RewardTableIdx = rewardTable.RewardIdx;
		if (RewardCountText != null)
			RewardCountText.text = rewardTable.RewardValue.ToString();
	}

	public void OnActivePremium()
	{
		if (ItemPassReward_Premium != null)
			ItemPassReward_Premium.gameObject.SetActive(true);
	}

	private void UpdateMilestoneProgress(int curSlotIndex, int milestoneStepIndex, int maxStepCount)
	{
		SetMilestoneProgressStepText(milestoneStepIndex);
		float ratio = maxStepCount > 0 ? (float)curSlotIndex / maxStepCount : 0f;
		SetMilestoneProgressRatio(ratio);
	}

	private void SetMilestoneProgressStepText(int step)
	{
		if (MilestoneProgressStepText != null)
			MilestoneProgressStepText.text = step.ToString();
	}

	private void SetMilestoneProgressRatio(float ratio)
	{
		if (MilestoneProgressSlider != null)
			MilestoneProgressSlider.value = Mathf.Clamp01(ratio);
	}

	private void OnClickedRewardClaimBtn(int rewardTableIdx, bool bPremium)
	{
		// Claim milestone reward
	}

	private void UpdateSlotState(bool bPlayAni)
	{
		// Update reward slot claimed/unclaimed/locked state
	}
}
