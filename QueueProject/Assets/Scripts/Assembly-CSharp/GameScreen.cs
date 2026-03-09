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

		// Hide non-essential UI elements to clean up layout
		CleanupUI();

		GameplayEvents.SendGameScreenLoaded();
	}

	private void CleanupUI()
	{
		// In TopUI, only keep essential elements: Text-Level, Counter-Game-Lives, Button-Settings
		// Hide everything else
		if (m_topPart != null)
		{
			string[] keepNames = new string[]
			{
				"Text-Level",
				"Counter-Game-Lives",
				"Button-Settings",
			};

			for (int i = 0; i < m_topPart.transform.childCount; i++)
			{
				var child = m_topPart.transform.GetChild(i);
				bool keep = false;
				foreach (string keepName in keepNames)
				{
					if (child.name == keepName)
					{
						keep = true;
						break;
					}
				}
				if (!keep)
					child.gameObject.SetActive(false);
			}
		}

		// Hide non-essential root-level children of Screen-Game
		// Keep: TopUI (m_topPart), Control Pad, and the grid-related elements
		for (int i = 0; i < transform.childCount; i++)
		{
			var child = transform.GetChild(i);
			string n = child.name;
			// Keep TopUI and Control Pad, hide everything else that's not essential
			if (n == "TopUI" || n == "Control Pad" || n == "White Overlay")
				continue;
			if (n.Contains("Event") || n.Contains("Notification") ||
				n.Contains("NoAds") || n.Contains("Offer") ||
				n.Contains("Tournament") || n.Contains("PVP") ||
				n.Contains("Bank") || n.Contains("Dificulty"))
			{
				child.gameObject.SetActive(false);
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
