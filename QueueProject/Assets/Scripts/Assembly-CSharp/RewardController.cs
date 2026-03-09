using System.Collections.Generic;
using Balancy.Models.Inventory;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class RewardController : MonoBehaviour
{
	public virtual string GetLastRewardGivenAsJsonString()
	{
		return null;
	}

	public virtual void GiveRewards(Reward reward, RewardManager.RewardOptions options)
	{
	}

	public virtual void GiveRewards(List<Reward> rewards, RewardManager.RewardOptions options)
	{
	}

	protected virtual void DoStandardFlow(Reward reward, RewardManager.RewardOptions options)
	{
	}

	protected virtual void DoBoxFlow(Reward fullReward, RewardManager.RewardOptions options)
	{
	}

	private void DoRewardFlow(Reward reward, RewardManager.RewardOptions options)
	{
	}

	private RewardBox GetRewardBox(Reward reward)
	{
		return null;
	}

	private Reward GetRewardBoxContent(Reward primaryReward)
	{
		return null;
	}

	public static Reward CombineRewards(Reward reward)
	{
		return null;
	}
}
