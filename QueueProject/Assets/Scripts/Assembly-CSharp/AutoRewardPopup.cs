using System;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class AutoRewardPopup : RewardPopupBase
{
	public const string PREFAB_NAME = "Prefabs/KWReward/Popup-AutoReward";

	[SerializeField]
	protected RewardWidget m_rewardWdiget;

	private Action m_rewardGivenCallback;

	protected Reward m_reward;

	private new AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	protected override void FinishedIntroAnimation()
	{
	}

	protected void GiveRewardActions()
	{
	}

	private void PlaySfx(Reward reward)
	{
	}

	private void PlayOnlyCoinSfx()
	{
	}

	private void PlayCoinSfx()
	{
	}

	private void PlayNoCoinRewardSfx(string otherItemsIds)
	{
	}
}
