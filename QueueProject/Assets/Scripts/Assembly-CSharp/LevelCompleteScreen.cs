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
		m_multiplier = 1;
		m_shouldShowNextLevelButton = true;
		m_rewardClaimed = false;
	}

	private void InitializeWinStreak()
	{
		// Skip - win streak feature
	}

	private void InitializeButtons()
	{
		if (m_buttonController != null)
		{
			// Show next button by default
		}

		// Hide RV button (ads skipped)
		if (m_rvButtonObject != null)
			m_rvButtonObject.gameObject.SetActive(false);
	}

	private void InitializeRewardsAndMultiplier()
	{
		ConfigureDefaultRewardsAndMultiplier();
	}

	private void ConfigureDefaultRewardsAndMultiplier()
	{
		m_multiplier = 1;
	}

	private void UpdatePercentageCompleteUI()
	{
		if (m_percentageCompleteText != null)
			m_percentageCompleteText.gameObject.SetActive(false);
	}

	private void ApplyQueensEventRewardsIfNeeded()
	{
		// Skip - queen event rewards
	}

	private void HandleSubscriptionState()
	{
		// Skip - subscriptions
	}

	private void SendCurrencyEarnedAnalytics()
	{
		// Skip - analytics
	}

	private void HandleDailySubscriptionReward()
	{
		// Skip - subscriptions
	}

	private void PlayIntroAnimation()
	{
		if (m_screenAnimator != null)
		{
			// Play intro animation if available
		}
	}

	private void ShowBeatenPlayersPercent()
	{
		// Skip - server/leaderboard
	}

	private void DisplayLeaderboardData(LeaderboardData leaderboardData = null)
	{
		// Skip - leaderboard
	}

	private void AnimEvent_PlayTimeSFX()
	{
		// Skip - SFX
	}

	protected string GetSourceAnalyticsString()
	{
		if (GameManager.Instance == null) return "standard";
		switch (GameManager.Instance.CurrentGameMode)
		{
			case GameManager.GameMode.DAILY_CHALLENGE: return "daily_challenge";
			case GameManager.GameMode.TOURNAMENT: return "tournament";
			case GameManager.GameMode.EXPERT_MODE: return "expert_mode";
			default: return "standard";
		}
	}

	private void OnDestroy()
	{
	}

	private void SetInputBlocker()
	{
		// Skip - input blocker popup
	}

	private void ShowSpecialOffer(Action finished)
	{
		finished?.Invoke();
	}

	private void ShowDailyStreak(Action finished)
	{
		finished?.Invoke();
	}

	private void RemoveInputBlocker(Action finished)
	{
		finished?.Invoke();
	}

	public void AnimEvent_TryShowSpecialOfferLevelComplete()
	{
		// Skip - special offers
	}

	private void OnPlayerMovementDone(bool movement)
	{
		// Skip - leaderboard movement
	}

	private bool IsQueenLevelReached()
	{
		return false;
	}

	protected virtual void MakeRewardsDouble()
	{
		m_multiplier = 2;
	}

	protected virtual void Start()
	{
		InitializeButtons();
		InitializeRewardsAndMultiplier();
		UpdatePercentageCompleteUI();
		PlayIntroAnimation();

		// Set complete text
		if (m_completeText != null)
		{
			bool isChallenge = GameManager.Instance != null &&
				GameManager.Instance.CurrentGameMode == GameManager.GameMode.DAILY_CHALLENGE;
			m_completeText.text = isChallenge ? "Challenge Complete!" : "Level Complete!";
		}

		// Show expert mode header if applicable
		if (m_mainHeader != null && m_expertModeHeader != null)
		{
			bool isExpert = GameManager.Instance != null &&
				GameManager.Instance.CurrentGameMode == GameManager.GameMode.EXPERT_MODE;
			m_mainHeader.SetActive(!isExpert);
			m_expertModeHeader.SetActive(isExpert);
		}

		// Show level number
		if (m_queensNumber != null && GameManager.Instance != null &&
			GameManager.Instance.CurrentLevelScriptable != null)
		{
			var levelData = GameManager.Instance.CurrentLevelScriptable.data;
			if (levelData != null)
				m_queensNumber.text = levelData.sizeX.ToString();
		}

		GameplayEvents.SendLevelSolved();
	}

	protected void SendLevelCompleteAnalyticStart()
	{
		// Skip - analytics
	}

	public void OnRewardRVButtonClicked()
	{
		// Skip - ads
	}

	private void DoubleReward()
	{
		MakeRewardsDouble();
	}

	public void OnHomePressed()
	{
		Continue(true);
	}

	public void OnNextPressed()
	{
		Continue(false);
	}

	public void ToggleButtons(bool activeState)
	{
		if (m_buttonController != null)
			m_buttonController.gameObject.SetActive(activeState);
	}

	public virtual void Continue(bool goHome)
	{
		OnRewardFlowComplete(goHome);
	}

	protected virtual void OnRewardFlowComplete(bool goHome)
	{
		SaveRewards();
		GoNextScreen(goHome);
	}

	private void GoNextScreen(bool goHome)
	{
		if (goHome)
		{
			if (GameManager.Instance != null)
				GameManager.Instance.ReturnToHomeScreen();
		}
		else
		{
			// Start next level
			if (GameManager.Instance != null)
			{
				var nextLevel = GameManager.Instance.GetNextLevelScriptable();
				if (nextLevel != null)
					GameManager.Instance.StartGame(GameManager.Instance.CurrentGameMode, nextLevel);
				else
					GameManager.Instance.ReturnToHomeScreen();
			}
		}
	}

	private void DelayShowButtons()
	{
		ToggleButtons(true);
	}

	public void AnimEvent_PopUpLevelCompleteShowRewards()
	{
		// Rewards display animation event
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void SaveRewards()
	{
		m_rewardClaimed = true;
	}

	private void ShowRateUs()
	{
		// Skip - rating
	}

	private void CheckForJigsawPuzzle(LevelDifficulty difficulty = LevelDifficulty.NORMAL)
	{
		// Skip - jigsaw puzzle feature
	}

	public void AnimEvent_ShowDailyStreak()
	{
		// Skip - daily streak
	}

	public void AnimEvent_ForceInterstitial()
	{
		// Skip - ads
	}
}
