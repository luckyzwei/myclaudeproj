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

	public InputTimerWidget InputTimer => null;

	public LifeCounterWidget HeartsWidget => null;

	public GameObject RulesGameObject => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void FeatureUnlockQueueFinished()
	{
	}

	private void OnLevelLost()
	{
	}

	private bool ShowLimitedOffer()
	{
		return false;
	}

	public void OnPauseClick()
	{
	}

	public void ToggleTopPart(bool value, bool fade = false)
	{
	}

	public void ToggleBottomPart(bool value, bool fade = false)
	{
	}

	private void OnLevelSolved()
	{
	}

	public void SetRulesVisibilty(bool value)
	{
	}

	public void SetHeartsVisibilty(bool value)
	{
	}
}
