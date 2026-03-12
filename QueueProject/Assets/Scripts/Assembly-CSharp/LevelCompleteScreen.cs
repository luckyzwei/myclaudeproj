using System;
using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.SmartObjects;
using KWUserInterface;
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
	protected Text m_queensNumber;

	[SerializeField]
	protected Text m_percentageCompleteText;

	[SerializeField]
	protected string m_percentageCompleteKey;

	[SerializeField]
	protected Text m_completeText;

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

	// Names to hide only when they are direct children of "Content-Size Fitted !!"
	private static readonly HashSet<string> s_contentSizeFittedHideNames = new HashSet<string>
	{
		"Header",
		"Collection",
		"Collection-LayoutGroup",
	};

	// Top-level containers to hide (server/social features that don't work offline)
	private static readonly HashSet<string> s_hideNames = new HashSet<string>
	{
		"Widget-Challenged [Please Keep This Active]",
		"WinStreak-Container",
		"Widget-WinStreak-Notification",
		"Widget-WeekDayStreak",
		"Button-StreakRepair",
		"Widget-LiveLeaderboard",
		"League",
		"Button-VIP",
		"Widget-VIPEventTimer",
		"Button-NoAdsOfferParent",
		"Button-QueenEvent",
		"Widget-QueensEventCounter",
		"Widget-Notification",
		"Widget-Bank-Currency",
		"Widget-DailyMissions-Animated",
		"Button-DailyChallenge",
		"Button-DailyChallengeRV",
		"Button-RVReward",
		"Button-Play-ExpertModeNext",
		"Button-Play-ExpertModeBuy",
		"Button-Play-Hard",
		"Button-Play-VeryHard",
		"Button-Accept",
		"Button-Accept with auto X",
		"Text-Difficulty",
	};

	private void Awake()
	{
		m_multiplier = 1;
		m_shouldShowNextLevelButton = true;
		m_rewardClaimed = false;
	}

	private void InitializeWinStreak()
	{
	}

	private void InitializeButtons()
	{
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
		m_multiplier = 2;
	}

	protected virtual void Start()
	{
		// Step 1: Disable Animator so it doesn't fight our layout
		var animator = GetComponent<Animator>();
		if (animator != null)
			animator.enabled = false;

		// Step 2: Recursively show all descendants
		ForceShowAllRecursive(transform);

		// Step 3: Hide specific unwanted containers
		HideUnwantedRecursive(transform);

		// Step 3b: Hide Header/Collection only under "Content-Size Fitted !!"
		HideContentSizeFittedChildren();

		// Step 4: Ensure CanvasGroup is visible
		if (m_canvasGroup != null)
		{
			m_canvasGroup.alpha = 1f;
			m_canvasGroup.interactable = true;
			m_canvasGroup.blocksRaycasts = true;
		}

		// Step 5: Setup content
		InitializeButtons();
		InitializeRewardsAndMultiplier();
		UpdatePercentageCompleteUI();

		// Set complete text
		if (m_completeText != null)
		{
			bool isChallenge = GameManager.Instance != null &&
				GameManager.Instance.CurrentGameMode == GameManager.GameMode.DAILY_CHALLENGE;
			string key = isChallenge ? CHALLENGE_COMPLETE_KEY : LEVEL_COMPLETE_KEY;
			string text = Kwalee.GetLocalisedText(key);
			m_completeText.text = !string.IsNullOrEmpty(text) ? text : (isChallenge ? "挑战完成！" : "关卡完成！");
		}

		// Expert mode header
		if (m_mainHeader != null && m_expertModeHeader != null)
		{
			bool isExpert = GameManager.Instance != null &&
				GameManager.Instance.CurrentGameMode == GameManager.GameMode.EXPERT_MODE;
			m_mainHeader.SetActive(!isExpert);
			m_expertModeHeader.SetActive(isExpert);
		}

		// Queen count
		if (m_queensNumber != null && GameManager.Instance != null &&
			GameManager.Instance.CurrentLevelScriptable != null)
		{
			var levelData = GameManager.Instance.CurrentLevelScriptable.data;
			if (levelData != null)
				m_queensNumber.text = levelData.sizeX.ToString();
		}

		// Fix "Collected Pieces" label text on Rewards component
		FixRewardsText();

		// Center button text alignment
		FixButtonTextAlignment();

		// Wire up buttons in code (prefab UnityEvents may be broken from AssetRipper)
		BindButtons();

		// Populate rewards display
		PopulateRewards();

		GameplayEvents.SendLevelSolved();
	}

	private void FixRewardsText()
	{
		// Find all Text components and clear the "Collected Pieces" label
		var allTexts = GetComponentsInChildren<Text>(true);
		for (int i = 0; i < allTexts.Length; i++)
		{
			if (allTexts[i] != null && allTexts[i].text == "Collected Pieces")
				allTexts[i].text = "";
		}
	}

	private void BindButtons()
	{
		// 只确保按钮可交互，不再 AddListener（prefab 序列化 onClick 已绑定 OnNextPressed/OnHomePressed）
		var buttonNext = FindChildRecursive(transform, "Button-Next");
		if (buttonNext != null)
		{
			var btn = buttonNext.GetComponent<Button>();
			if (btn != null)
				btn.interactable = true;
		}

		var buttonHome = FindChildRecursive(transform, "Button-Home");
		if (buttonHome != null)
		{
			var btn = buttonHome.GetComponent<Button>();
			if (btn != null)
				btn.interactable = true;
		}
	}

	private void FixButtonTextAlignment()
	{
		// Center text in all nav buttons
		string[] buttonNames = { "Button-Home", "Button-Next", "Button-GotIt" };
		for (int b = 0; b < buttonNames.Length; b++)
		{
			var btn = FindChildRecursive(transform, buttonNames[b]);
			if (btn != null)
			{
				var texts = btn.GetComponentsInChildren<Text>(true);
				for (int i = 0; i < texts.Length; i++)
				{
					if (texts[i] != null)
						texts[i].alignment = TextAnchor.MiddleCenter;
				}
			}
		}
	}

	private void PopulateRewards()
	{
		// Determine coin reward based on level size
		int coinReward = 10;
		if (GameManager.Instance != null && GameManager.Instance.CurrentLevelScriptable != null)
		{
			var levelData = GameManager.Instance.CurrentLevelScriptable.data;
			if (levelData != null)
				coinReward = levelData.sizeX * 10;
		}

		Debug.Log($"[LevelCompleteScreen] PopulateRewards: coinReward={coinReward}, m_rewardWidget={m_rewardWidget != null}");

		// Find the Rewards node under Content-Size Fitted (inner Rewards with RewardWidget)
		var csf = FindChildRecursive(transform, "Content-Size Fitted !!");
		if (csf == null) return;

		var rewardsNode = FindChildDirect(csf, "Rewards");
		if (rewardsNode == null) return;

		// Get the RewardWidget on this node
		var rewardWidget = rewardsNode.GetComponent<RewardWidget>();
		if (rewardWidget == null)
		{
			Debug.Log("[LevelCompleteScreen] No RewardWidget on inner Rewards node");
			return;
		}

		// Find Reward-LayoutGroup recursively under Rewards
		var layoutTransform = FindChildRecursive(rewardsNode, "Reward-LayoutGroup");
		if (layoutTransform == null)
		{
			Debug.Log("[LevelCompleteScreen] Reward-LayoutGroup not found, using rewardsNode directly");
			layoutTransform = rewardsNode;
		}

		// Try to get ItemWithAmountCellPrefab via reflection
		var prefabField = typeof(RewardWidget).GetField("m_ItemWithAmountCellPrefab",
			System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
		var cellPrefab = prefabField?.GetValue(rewardWidget) as ItemWithAmountCell;

		if (cellPrefab != null)
		{
			Debug.Log("[LevelCompleteScreen] Spawning reward cell from prefab");
			var cellInstance = Instantiate(cellPrefab, layoutTransform);
			cellInstance.gameObject.SetActive(true);

			// Set the amount text on the spawned cell
			var amountText = cellInstance.GetComponentInChildren<Text>(true);
			if (amountText != null)
				amountText.text = coinReward.ToString();

			// Make sure the icon is visible
			var images = cellInstance.GetComponentsInChildren<Image>(true);
			for (int i = 0; i < images.Length; i++)
				if (images[i] != null) images[i].gameObject.SetActive(true);
		}
		else
		{
			Debug.Log("[LevelCompleteScreen] No cell prefab, creating reward text");
			CreateRewardText(layoutTransform, coinReward);
		}
	}

	private void CreateRewardText(Transform parent, int coinReward)
	{
		// Icon + text row
		var rowGO = new GameObject("RewardRow");
		rowGO.transform.SetParent(parent, false);
		var rowRT = rowGO.AddComponent<RectTransform>();
		rowRT.sizeDelta = new Vector2(300, 80);
		var hlg = rowGO.AddComponent<HorizontalLayoutGroup>();
		hlg.childAlignment = TextAnchor.MiddleCenter;
		hlg.spacing = 10;
		hlg.childForceExpandWidth = false;
		hlg.childForceExpandHeight = false;

		// Coin icon - try to find an existing coin sprite from CoinWidget or similar
		var iconGO = new GameObject("Icon");
		iconGO.transform.SetParent(rowGO.transform, false);
		var iconImg = iconGO.AddComponent<Image>();
		// Try loading a coin sprite from resources
		var coinSprite = Resources.Load<Sprite>("UI/icon_coin");
		if (coinSprite == null)
			coinSprite = Resources.Load<Sprite>("icons/coin");
		if (coinSprite != null)
			iconImg.sprite = coinSprite;
		else
			iconImg.color = new Color(1f, 0.84f, 0f); // Gold color as fallback
		var iconLE = iconGO.AddComponent<LayoutElement>();
		iconLE.preferredWidth = 60;
		iconLE.preferredHeight = 60;

		// Amount text
		var textGO = new GameObject("Amount");
		textGO.transform.SetParent(rowGO.transform, false);
		var amountText = textGO.AddComponent<Text>();
		amountText.text = $"+{coinReward}";
		amountText.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
		amountText.fontSize = 48;
		amountText.alignment = TextAnchor.MiddleLeft;
		amountText.color = Color.white;
		amountText.horizontalOverflow = HorizontalWrapMode.Overflow;
		var textLE = textGO.AddComponent<LayoutElement>();
		textLE.preferredWidth = 200;
		textLE.preferredHeight = 60;
	}

	private Transform FindChildRecursive(Transform parent, string name)
	{
		for (int i = 0; i < parent.childCount; i++)
		{
			var child = parent.GetChild(i);
			if (child.name == name)
				return child;
			var found = FindChildRecursive(child, name);
			if (found != null)
				return found;
		}
		return null;
	}

	private void ForceShowAllRecursive(Transform parent)
	{
		for (int i = 0; i < parent.childCount; i++)
		{
			var child = parent.GetChild(i);
			child.gameObject.SetActive(true);
			child.localScale = Vector3.one;

			var cg = child.GetComponent<CanvasGroup>();
			if (cg != null)
				cg.alpha = 1f;

			ForceShowAllRecursive(child);
		}
	}

	private void HideContentSizeFittedChildren()
	{
		var csf = FindChildRecursive(transform, "Content-Size Fitted !!");
		if (csf == null)
		{
			Debug.Log("[LevelCompleteScreen] Content-Size Fitted !! not found");
			return;
		}
		Debug.Log($"[LevelCompleteScreen] Found Content-Size Fitted !!, childCount={csf.childCount}");
		for (int i = 0; i < csf.childCount; i++)
		{
			var child = csf.GetChild(i);
			Debug.Log($"[LevelCompleteScreen] CSF child[{i}]: {child.name} active={child.gameObject.activeSelf}");
			if (s_contentSizeFittedHideNames.Contains(child.name))
			{
				child.gameObject.SetActive(false);
				Debug.Log($"[LevelCompleteScreen] Hiding CSF child: {child.name}");
			}
		}

		// In the Buttons container under CSF, only keep Button-Home and Button-Next
		var buttons = FindChildDirect(csf, "Buttons");
		if (buttons != null)
		{
			Debug.Log($"[LevelCompleteScreen] Found Buttons under CSF, childCount={buttons.childCount}");
			for (int i = 0; i < buttons.childCount; i++)
			{
				var child = buttons.GetChild(i);
				if (child.name == "Button-Home" || child.name == "Button-Next")
				{
					child.gameObject.SetActive(true);
					Debug.Log($"[LevelCompleteScreen] Keeping button: {child.name}");
				}
				else
				{
					child.gameObject.SetActive(false);
					Debug.Log($"[LevelCompleteScreen] Hiding button: {child.name}");
				}
			}
			// Make sure Buttons container itself is visible
			buttons.gameObject.SetActive(true);
			var buttonsCG = buttons.GetComponent<CanvasGroup>();
			if (buttonsCG != null) buttonsCG.alpha = 1f;
		}
		else
		{
			Debug.Log("[LevelCompleteScreen] Buttons not found as direct child of CSF");
		}
	}

	private Transform FindChildDirect(Transform parent, string name)
	{
		for (int i = 0; i < parent.childCount; i++)
		{
			if (parent.GetChild(i).name == name)
				return parent.GetChild(i);
		}
		return null;
	}

	private void HideUnwantedRecursive(Transform parent)
	{
		for (int i = 0; i < parent.childCount; i++)
		{
			var child = parent.GetChild(i);
			if (s_hideNames.Contains(child.name))
			{
				child.gameObject.SetActive(false);
				// Don't recurse into hidden objects
			}
			else
			{
				HideUnwantedRecursive(child);
			}
		}
	}

	protected void SendLevelCompleteAnalyticStart()
	{
	}

	public void OnRewardRVButtonClicked()
	{
	}

	private void DoubleReward()
	{
		MakeRewardsDouble();
	}

	public void OnHomePressed()
	{
		Debug.Log("[LevelCompleteScreen] OnHomePressed called!");
		Continue(true);
	}

	public void OnNextPressed()
	{
		Debug.Log("[LevelCompleteScreen] OnNextPressed called!");
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
		Debug.Log($"[LevelCompleteScreen] GoNextScreen goHome={goHome}, GameManager={GameManager.Instance != null}");
		if (goHome)
		{
			if (GameManager.Instance != null)
				GameManager.Instance.ReturnToHomeScreen();
		}
		else
		{
			if (GameManager.Instance != null)
				GameManager.Instance.StartGame(GameManager.Instance.CurrentGameMode);
		}
	}

	private void DelayShowButtons()
	{
		ToggleButtons(true);
	}

	public void AnimEvent_PopUpLevelCompleteShowRewards()
	{
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
