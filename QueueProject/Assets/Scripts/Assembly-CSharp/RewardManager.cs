using System;
using System.Collections.Generic;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class RewardManager : MonoSingleton<RewardManager>
{
	public struct RewardOptions
	{
		public Action rewardFlowFinishedCallback;

		public Action rewardGivenCallback;

		public object[] popupMetaData;

		public bool combineRewards;

		public string displayPopupPath;

		public string rewardBoxPopupPath;

		public string clientId;

		public bool allowNoReward;

		public bool reParentRecevier;

		public bool giveReward;

		public bool pauseBank;

		public RewardOptions(Action rewardFlowFinishedCallback = null, Action rewardGivenCallback = null, string displayPopupPath = null, string rewardBoxPopupPath = null, object[] popupMetaData = null, bool combineRewards = true, string clientId = "default", bool allowNoReward = false, bool pauseBank = true, bool reParentRecevier = false, bool giveReward = true)
		{
			this.rewardFlowFinishedCallback = null;
			this.rewardGivenCallback = null;
			this.popupMetaData = null;
			this.combineRewards = false;
			this.displayPopupPath = null;
			this.rewardBoxPopupPath = null;
			this.clientId = null;
			this.allowNoReward = false;
			this.reParentRecevier = false;
			this.giveReward = false;
			this.pauseBank = false;
		}
	}

	private RewardController m_rewardController;

	protected override void Init()
	{
	}

	public string GetLastRewardGivenAsJsonString()
	{
		return null;
	}

	public virtual void GiveRewards(Reward reward, RewardOptions options)
	{
	}

	public virtual void GiveRewards(List<Reward> rewards, RewardOptions options)
	{
	}

	public static Reward CombineRewards(Reward reward)
	{
		return null;
	}
}
