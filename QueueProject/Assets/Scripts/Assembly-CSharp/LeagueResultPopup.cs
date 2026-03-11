using System;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LeagueResultPopup : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/KWLeaderboard/PopUp-Leagues-Result";

	[SerializeField]
	private LeagueHeaderWidget m_header;

	[SerializeField]
	private LeaguePodiumWidget m_podium;

	[SerializeField]
	private LeagueRewardWidget m_leagueReward;

	[SerializeField]
	private LeaderboardCell m_cell;

	[SerializeField]
	private Image m_nextLeague;

	[SerializeField]
	private UnityEngine.UI.Extensions.Gradient m_nextLeagueGradient;

	[SerializeField]
	private Text m_nextLeagueName;

	[SerializeField]
	private GameObject m_promotionObject;

	[SerializeField]
	private GameObject m_demotionObject;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardFlowPopup;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardBoxPopup;

	protected Action m_rewardedCallback;

	protected Reward m_reward;

	public static void Show(Action rewardedCallback, Action closedCallback)
	{
	}

	private void Initialize(Action callback)
	{
	}

	private void ConfigureNextLeague()
	{
	}

	public void OnContinuePressed()
	{
	}

	private void FinishAndClose()
	{
	}

	protected virtual void GiveRewards(Action onFinished)
	{
	}
}
