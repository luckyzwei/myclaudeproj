using KWUserInterface;
using UnityEngine;

public class HomeScreen : KWUserInterface.Screen
{
	private const int LEADERBOARD_TAB_INDEX = 3;

	[SerializeField]
	private float m_maxScreenRatio;

	[SerializeField]
	private RectTransform m_verticalLayout;

	[SerializeField]
	private RectTransform m_dailyChallengeButtonTransform;

	[SerializeField]
	private TabToolbar m_tabToolbar;

	[SerializeField]
	private SubScreenManager m_subScreenManager;

	private FeatureUpdateController m_featureUpdateController;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void TryShowFeatureUpdatePopup()
	{
	}

	public void StartGame()
	{
	}

	private void StartGameCallback()
	{
	}

	public void ShowBoosterUnlockPopup()
	{
	}

	public RectTransform GetDailyChallengesButton()
	{
		return null;
	}

	public void LeaderboardClicked()
	{
	}

	private void UIEventsOnPopUpClosed(int x)
	{
	}

	private void TryToShowQueue()
	{
	}
}
