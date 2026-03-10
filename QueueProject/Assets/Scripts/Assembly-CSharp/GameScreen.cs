using KWCore.UI;
using KWUserInterface;
using UnityEngine;

public class GameScreen : KWUserInterface.Screen
{
	private const float FADE_TIME = 0.75f;

	[SerializeField]
	private GameObject m_rules;

	[SerializeField]
	private GameObject m_rulesParent;

	[SerializeField]
	private LifeCounterWidget m_hearts;

	[SerializeField]
	private InputTimerWidget m_inputTimer;

	[SerializeField]
	private GameObject m_topPart;

	[SerializeField]
	private GameObject m_bottomPart;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private GameObject m_ftueButton;

	[SerializeField]
	private GameObject m_experModeLogo;

	[SerializeField]
	private LimitedOfferWidgetController m_limitedOfferWidgetController;

	public InputTimerWidget InputTimer => m_inputTimer;

	public LifeCounterWidget HeartsWidget => m_hearts;

	public GameObject RulesGameObject => m_rules;

	private void Awake()
	{
		if (m_canvasGroup == null)
			m_canvasGroup = GetComponent<CanvasGroup>();
	}

	private void OnDestroy()
	{
		GameplayEvents.LevelSolved -= OnLevelSolved;
		GameplayEvents.LevelFailed -= OnLevelLost;
	}

	private void Start()
	{
		GameplayEvents.LevelSolved += OnLevelSolved;
		GameplayEvents.LevelFailed += OnLevelLost;

		// Configure hearts if game controller exists
		if (m_hearts != null && QueensGameController.Instance != null)
		{
			m_hearts.Configure(QueensGameController.Instance.NumLivesInThisLevel());
		}

		// Hide expert mode logo by default
		if (m_experModeLogo != null)
			m_experModeLogo.SetActive(GameManager.Instance != null &&
				GameManager.Instance.CurrentGameMode == GameManager.GameMode.EXPERT_MODE);

		// Hide FTUE button
		if (m_ftueButton != null)
			m_ftueButton.SetActive(false);

		// Match emulator: hide non-essential UI
		CleanupUI();

		GameplayEvents.SendGameScreenLoaded();
	}

	private void CleanupUI()
	{
		// TopUI: keep gameplay-relevant elements
		if (m_topPart != null)
		{
			string[] keepNames = { "Text-Level", "Counter-Game-Lives", "Button-Settings",
				"Button-Info", "Buttons-Layout", "QueenEventContainer" };
			for (int i = 0; i < m_topPart.transform.childCount; i++)
			{
				var child = m_topPart.transform.GetChild(i);
				bool keep = System.Array.IndexOf(keepNames, child.name) >= 0;
				if (!keep)
					child.gameObject.SetActive(false);
			}
		}

		// QueenEventContainer: only keep the treasure chest button
		var eventContainer = m_topPart != null ? m_topPart.transform.Find("QueenEventContainer") : null;
		if (eventContainer != null)
		{
			for (int i = 0; i < eventContainer.childCount; i++)
			{
				var child = eventContainer.GetChild(i);
				if (child.name != "Button-Event-QueenGameplay")
					child.gameObject.SetActive(false);
			}
		}

		// Screen-Game root: hide non-essential children
		string[] hideContains = { "NoAds", "PVP", "Interrupt", "Feedback" };
		for (int i = 0; i < transform.childCount; i++)
		{
			var child = transform.GetChild(i);
			string n = child.name;
			foreach (string keyword in hideContains)
			{
				if (n.Contains(keyword))
				{
					child.gameObject.SetActive(false);
					break;
				}
			}
		}
	}

	private void FeatureUnlockQueueFinished()
	{
		// No-op: feature unlock queue not needed for core gameplay
	}

	private void OnLevelLost()
	{
		// Hearts widget already handles life lost via event
	}

	private bool ShowLimitedOffer()
	{
		return false;
	}

	public void OnPauseClick()
	{
		if (QueensGameController.Instance != null)
			QueensGameController.Instance.PauseTimer();
		PopUpBase.ShowPopup<PopupPause>("prefabs/popups/Popup-Pause", OnPausePopupClosed);
	}

	private void OnPausePopupClosed()
	{
		if (QueensGameController.Instance != null)
			QueensGameController.Instance.ResumeTimer();
	}

	public void ToggleTopPart(bool value, bool fade = false)
	{
		if (m_topPart != null)
			m_topPart.SetActive(value);
	}

	public void ToggleBottomPart(bool value, bool fade = false)
	{
		if (m_bottomPart != null)
			m_bottomPart.SetActive(value);
	}

	private void OnLevelSolved()
	{
		// Disable interaction on solve
		if (m_canvasGroup != null)
			m_canvasGroup.interactable = false;
	}

	public void SetRulesVisibilty(bool value)
	{
		if (m_rules != null)
			m_rules.SetActive(value);
		if (m_rulesParent != null)
			m_rulesParent.SetActive(value);
	}

	public void SetHeartsVisibilty(bool value)
	{
		if (m_hearts != null)
			m_hearts.gameObject.SetActive(value);
	}
}
