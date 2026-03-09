using Balancy.Models.SmartObjects;
using UnityEngine;

public class DailyChallengeMilestoneCell : MilestoneCell
{
	private const string ANIM_COLLECTED_ALREADY = "Collected-Already";

	[SerializeField]
	private GameObject m_bubble;

	[SerializeField]
	private RewardWidget m_rewardWidget;

	private bool m_isShowingBubble;

	private float m_lastHideTime;

	public void SetReward(Reward reward)
	{
	}

	public void Clicked()
	{
	}

	private void SetBubbleVisibility(bool value)
	{
	}

	private void Update()
	{
	}

	public override void SetCollected()
	{
	}
}
