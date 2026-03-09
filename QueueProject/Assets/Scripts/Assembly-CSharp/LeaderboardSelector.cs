using UnityEngine;
using UnityEngine.UI;

public class LeaderboardSelector : MonoBehaviour
{
	private enum LeaderboardType
	{
		WEEKLY = 0,
		LEGENDS = 1
	}

	[Header("Settings")]
	[SerializeField]
	private LeaderboardType m_defaultLeaderboardType;

	[SerializeField]
	private bool m_showTabs;

	[Header("UI Containers")]
	[SerializeField]
	private GameObject m_tabsPanel;

	[SerializeField]
	private GameObject m_weeklyLeaderboard;

	[SerializeField]
	private GameObject m_legendsLeaderboard;

	[Header("Buttons")]
	[SerializeField]
	private Button m_weeklyButton;

	[SerializeField]
	private Button m_legendsButton;

	private void Start()
	{
	}

	private void InitializeUI()
	{
	}

	public void OnWeeklyPressed()
	{
	}

	public void OnLegendsPressed()
	{
	}

	private void SetLeaderboard(LeaderboardType type)
	{
	}

	public void OnInfoPressed()
	{
	}
}
