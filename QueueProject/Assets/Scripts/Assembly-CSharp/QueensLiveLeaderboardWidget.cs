using UnityEngine;

public class QueensLiveLeaderboardWidget : LeaderboardWidget
{
	[SerializeField]
	private float m_scrollDelayFor1Star;

	[SerializeField]
	private float m_scrollDelayForMultipleStars;

	[SerializeField]
	private string m_location;

	private bool m_animationRequested;

	private bool m_dataReady;

	protected override void OnEnable()
	{
	}

	private void Start()
	{
	}

	protected override void OnDisable()
	{
	}

	public void DoAnimate()
	{
	}

	protected override string GetLeadeboardID()
	{
		return null;
	}

	protected override void ContinueInitialization(LeaderboardData leaderboardData)
	{
	}

	private void TryStartAnimation()
	{
	}

	protected override void UpdateViewState()
	{
	}

	private void AnimateLeaderboard()
	{
	}

	protected override bool CanShowRankChangeAnimation()
	{
		return false;
	}
}
