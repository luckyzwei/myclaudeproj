using UnityEngine;
using UnityEngine.Serialization;

public class HomeScreenWidgetController : MonoBehaviour
{
	[FormerlySerializedAs("m_queensEventWidget")]
	[SerializeField]
	private GameObject m_treasureEventWidget;

	[SerializeField]
	private GameObject m_tournamentEventWidget;

	[SerializeField]
	private GameObject m_jigsawWidget;

	[SerializeField]
	private GameObject m_noEventActive;

	private bool m_initialized;

	private static bool s_royalTournamentAnalyticsSent;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnQueenEventTimerFinished()
	{
	}

	private void Setup()
	{
	}

	private void ShowNoEventActive()
	{
	}

	private void ShowTreasureEvent()
	{
	}

	private void ShowTournamentEvent()
	{
	}

	private void ShowJigsaw()
	{
	}

	private void HideAllWidgets()
	{
	}

	private void OnClaimedAllTreasureEventRewards()
	{
	}
}
