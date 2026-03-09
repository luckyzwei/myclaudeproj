using System;
using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public class BasicRewardPopup : RewardPopupBase
{
	public const string PREFAB_NAME = "Prefabs/KWReward/Popup-BasicReward";

	[SerializeField]
	protected RewardWidget m_rewardWdiget;

	private Action m_closedCallback;

	protected Action m_rewardGivenCallback;

	protected Reward m_reward;

	private new AnimatorHelper m_animatorHelper;

	protected Button[] m_allButtons;

	private void Awake()
	{
	}

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	public virtual void OnCollectButtonPressed()
	{
	}

	protected new void DisableAllButtons()
	{
	}

	protected void GiveRewardActions()
	{
	}
}
