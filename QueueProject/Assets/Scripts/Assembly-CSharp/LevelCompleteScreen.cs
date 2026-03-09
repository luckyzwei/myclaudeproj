using System;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWUserInterface;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteScreen : KWUserInterface.Screen
{
	private const string ANIM_ANIM_LEVELCOMPLETE_LEADERBOARD_INTRO = "Anim-LevelComplete-Leaderboard-Intro";

	private const string ANIM_ANIM_LEVELCOMPLETE_REWARDS_INTRO = "Anim-LevelComplete-Rewards-Intro";

	private const string ANIM_ANIM_LEVELCOMPLETE_LEVELTIMER_INTRO = "Anim-LevelComplete-LevelTimer-Intro";

	public const string LEVEL_COMPLETE_KEY = "PopupLevelComplete.LevelCompleted";

	public const string CHALLENGE_COMPLETE_KEY = "PopupLevelComplete.DailyChallengeCompleted";

	[Header("Buttons")]
	[SerializeField]
	protected Button m_rvButtonObject;

	[Header("Rewards")]
	[SerializeField]
	protected RewardWidget m_rewardWidget;

	[Header("Game")]
	[SerializeField]
	protected TextMeshProUGUI m_queensNumber;

	[SerializeField]
	protected TextMeshProUGUI m_percentageCompleteText;

	[SerializeField]
	protected string m_percentageCompleteKey;

	[SerializeField]
	protected TextMeshProUGUI m_completeText;

	[SerializeField]
	protected LevelCompleteScreenButtonsController m_buttonController;

	[SerializeField]
	protected CanvasGroup m_canvasGroup;

	[SerializeField]
	private RewardDoubler m_rewardDoubler;

	[SerializeField]
	protected AnimatorHelper m_screenAnimator;

	[SerializeField]
	private CoinWidget m_coinWidget;

	[SerializeField]
	private DailyWinStreakLevelCompleteWidget dailyWinStreakWidgetLevelComplete;

	[SerializeField]
	private DailyMissionAnimatedWidget m_dailyMissionWidget;

	[SerializeField]
	private GameObject m_mainHeader;

	[SerializeField]
	private GameObject m_expertModeHeader;

	protected KPFLevelCompleteScreenAnalytics m_kpfLevelCompleteScreenAnalytics;

	private Reward m_gameReward;

	private bool m_rewardClaimed;

	private bool m_shouldShowNextLevelButton;

	private int m_multiplier;

	private bool m_winStreakFlow;

	private bool m_isMissionRewardPendingToshow;

	private PopupInputBlocker m_popupInputBlocker;

	private void Awake()
	{
	}

	private void InitializeWinStreak()
	{
	}

	private void InitializeButtons()
	{
	}

	private void InitializeRewardsAndMultiplier()
	{
	}

	private void ConfigureDefaultRewardsAndMultiplier()
	{
	}

	private void UpdatePercentageCompleteUI()
	{
	}

	private void ApplyQueensEventRewardsIfNeeded()
	{
	}

	private void HandleSubscriptionState()
	{
	}

	private void SendCurrencyEarnedAnalytics()
	{
	}

	private void HandleDailySubscriptionReward()
	{
	}

	private void PlayIntroAnimation()
	{
	}

	private void ShowBeatenPlayersPercent()
	{
	}

	private void DisplayLeaderboardData(LeaderboardData leaderboardData = null)
	{
	}

	private void AnimEvent_PlayTimeSFX()
	{
	}

	protected string GetSourceAnalyticsString()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void SetInputBlocker()
	{
	}

	private void ShowSpecialOffer(Action finished)
	{
	}

	private void ShowDailyStreak(Action finished)
	{
	}

	private void RemoveInputBlocker(Action finished)
	{
	}

	public void AnimEvent_TryShowSpecialOfferLevelComplete()
	{
	}

	private void OnPlayerMovementDone(bool movement)
	{
	}

	private bool IsQueenLevelReached()
	{
		return false;
	}

	protected virtual void MakeRewardsDouble()
	{
	}

	protected virtual void Start()
	{
	}

	protected void SendLevelCompleteAnalyticStart()
	{
	}

	public void OnRewardRVButtonClicked()
	{
	}

	private void DoubleReward()
	{
	}

	public void OnHomePressed()
	{
	}

	public void OnNextPressed()
	{
	}

	public void ToggleButtons(bool activeState)
	{
	}

	public virtual void Continue(bool goHome)
	{
	}

	protected virtual void OnRewardFlowComplete(bool goHome)
	{
	}

	private void GoNextScreen(bool goHome)
	{
	}

	private void DelayShowButtons()
	{
	}

	public void AnimEvent_PopUpLevelCompleteShowRewards()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void SaveRewards()
	{
	}

	private void ShowRateUs()
	{
	}

	private void CheckForJigsawPuzzle(LevelDifficulty difficulty = LevelDifficulty.NORMAL)
	{
	}

	public void AnimEvent_ShowDailyStreak()
	{
	}

	public void AnimEvent_ForceInterstitial()
	{
	}
}
