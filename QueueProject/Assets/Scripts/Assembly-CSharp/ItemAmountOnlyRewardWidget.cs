using Balancy.Models.SmartObjects;
using UnityEngine.UI;
using UnityEngine;

public class ItemAmountOnlyRewardWidget : RewardWidget
{
	[SerializeField]
	private Text m_rewardAmount;

	public override void Configure(Reward price)
	{
	}
}
