using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;

public class ItemAmountOnlyRewardWidget : RewardWidget
{
	[SerializeField]
	private TextMeshProUGUI m_rewardAmount;

	public override void Configure(Reward price)
	{
	}
}
