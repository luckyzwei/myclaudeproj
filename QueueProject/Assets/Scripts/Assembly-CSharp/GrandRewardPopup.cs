using System;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class GrandRewardPopup : RewardPopupBase
{
	public const string PREFAB_NAME = "Prefabs/KWReward/Popup-GrandReward";

	[SerializeField]
	protected RewardWidget m_rewardWdiget;

	private Action m_rewardGivenCallback;

	protected Reward m_reward;

	private Canvas m_addedCanvas;

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	private void PlaySfx(Reward reward)
	{
	}

	protected override void FinishedIntroAnimation()
	{
	}

	protected void GiveRewardActions()
	{
	}

	private void PlayOnlyCoinSfx()
	{
	}

	private void PlayCoinSfx()
	{
	}

	private void PlayNoCoinRewardSfx()
	{
	}
}
