using UnityEngine;

public class CalendarAutomationDataGenerator : MonoBehaviour
{
	[SerializeField]
	private Transform m_buttonsParent;

	[SerializeField]
	private QueensDailyChallenge m_queensDailyChallenge;

	private GameObject[] m_gameObjects;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnCalendarPlayButtonUpdated()
	{
	}
}
