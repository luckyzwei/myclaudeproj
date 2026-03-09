using System;
using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupJigsawUnclaimedRewards : RewardPopupBase
{
	public const string PREFAB_NAME = "Prefabs/KWReward/Popup-JigsawEventOver";

	private const string CLAIM_KEY = "JigsawEvent.Claim";

	private const string CONTINUE_KEY = "JigsawEvent.Continue";

	private const string ANIM_ANIM_POPUP_JIGSAWREWARD_INTRO = "Anim-Popup-JigsawReward-Intro";

	private const string ANIM_ANIM_POPUP_JIGSAWNOREWARD_INTRO = "Anim-Popup-JigsawNOReward-Intro";

	[SerializeField]
	protected RewardWidget m_rewardWdiget;

	[SerializeField]
	private TextMeshProUGUI m_titleTMP;

	[SerializeField]
	private GameObject m_descriptionText;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private GameObject m_button;

	[SerializeField]
	private GameObject m_rewardContainer;

	[SerializeField]
	private TextMeshProUGUI m_claimTMP;

	[SerializeField]
	private Image m_promoArt;

	[SerializeField]
	private TextMeshProUGUI m_unclaimedRewardsText;

	private Action m_rewardGivenCallback;

	protected Reward m_reward;

	private new AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	public void ConfigureJigsaw(string clientId, Action rewardGivenCallback = null)
	{
	}

	public override void Configure(Reward reward, Action rewardGivenCallback, object[] metaData)
	{
	}

	public void GiveRewardActions()
	{
	}

	private void ContinueFlow()
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

	private void FadeOutCanvas()
	{
	}
}
