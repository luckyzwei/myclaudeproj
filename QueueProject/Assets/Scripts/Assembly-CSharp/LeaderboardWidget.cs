using System;
using UnityEngine;

public class LeaderboardWidget : ScrollRectRecycler<LeaderboardCell>
{
	[Header("Configuration")]
	[SerializeField]
	private GameObject m_loadingWidget;

	[SerializeField]
	protected string m_leaderboardID;

	[SerializeField]
	protected bool m_isRegional;

	[Header("Animation Settings")]
	[SerializeField]
	protected bool m_enableAutoScrollToPlayer;

	[SerializeField]
	protected bool m_jumpToPlayerOnStart;

	[SerializeField]
	protected bool m_animateLosingPositions;

	[Header("Data Loading Settings")]
	[SerializeField]
	protected bool m_loadDataAroundOwner;

	[SerializeField]
	protected bool m_allowDataUpdates;

	[Header("Optional Components")]
	[SerializeField]
	protected LeaderboardCellPositionChangeAnimator m_playerCellPositionChangeAnimator;

	protected LeaderboardData m_leaderboardData;

	private bool m_isInitialized;

	protected int m_previousPlayerRank;

	protected int m_currentPlayerRank;

	private int m_animationStartIndex;

	private bool m_isScrollingToPlayer;

	private bool m_bigJump;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected override void OnItemRecycled(int recycledDataIndex, int updatedDataIndex, LeaderboardCell cell)
	{
	}

	private void UpdateCellData(LeaderboardCell cell, LeaderboardData.User record)
	{
	}

	private void InitializeLeaderboard()
	{
	}

	protected virtual string GetLeadeboardID()
	{
		return null;
	}

	private void HandleLeaderboardUpdate(LeaderboardData leaderboardData)
	{
	}

	protected virtual void ContinueInitialization(LeaderboardData leaderboardData)
	{
	}

	private void ToggleLoadingWidget(bool isLoading)
	{
	}

	protected virtual void UpdateViewState()
	{
	}

	protected void ScrollToPlayer(Action finishedCallback = null)
	{
	}

	protected virtual void OnScrollToPlayerFinished()
	{
	}

	protected virtual bool CanShowRankChangeAnimation()
	{
		return false;
	}

	protected virtual bool CanAutoScrollToPlayer()
	{
		return false;
	}

	protected void AnimateRankChange()
	{
	}

	private void OnOverlayItemInitialised(LeaderboardCell sourceItemCell)
	{
	}

	protected override void OnUserScrollEnded()
	{
	}

	protected override void OnAutoScrollEnded()
	{
	}

	private void TryUpdateProfilePictures()
	{
	}

	private int GetIndexForRank(int rank)
	{
		return 0;
	}
}
