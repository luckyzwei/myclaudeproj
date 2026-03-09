using System;
using Balancy.Models.SmartObjects;
using UnityEngine;

public class PopUpDecoramaComplete : RewardPopupBase
{
	public const string PREFAB_NAME = "Prefabs/KWDecorama/Popup-DecoramaComplete";

	private const string ANIM_INTRO = "Intro";

	private const string ANIM_REWARDPOPUPINTRO = "RewardPopupIntro";

	private const string ANIM_REWARDPOPUPOUTRO = "RewardPopupOutro";

	[SerializeField]
	protected RewardWidget m_rewardWidget;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private float m_rewardIntroDelay;

	private Action m_rewardGivenCallback;

	protected Reward m_reward;

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	protected override void FinishedIntroAnimation()
	{
	}

	protected void PlayRewardIntro()
	{
	}

	protected void PlayRewardOutro()
	{
	}
}
