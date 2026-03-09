using System;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;

public class TrophyCollectionPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/Popup-TrophyCollection";

	[SerializeField]
	private TrophyCollectionHeader m_headerPrefab;

	[SerializeField]
	private Transform m_trophyCollectionPrefab;

	[SerializeField]
	private TrophyWidget m_trophyWidgetPrefab;

	[SerializeField]
	private Transform m_parent;

	[Space]
	[SerializeField]
	private TrophyCollectionHeader m_initialHeader;

	[SerializeField]
	private Transform m_initialTrophyCollection;

	[SerializeField]
	private QueensDailyChallenge m_queensDailyChallenge;

	public event Action<int, int> MonthClick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void SendAnalytics()
	{
	}

	public void Config()
	{
	}

	private Sprite GetEarnedTrophySpriteForDays(int completedDays, int totalDays, QueensDailyChallenge.MonthTrophies trophySprites)
	{
		return null;
	}

	private void OnWidgetClicked(int year, int month)
	{
	}
}
