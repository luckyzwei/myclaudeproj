using DG.Tweening;
using UnityEngine;

public class LevelCompleteScreenLeague : LevelCompleteScreen
{
	[SerializeField]
	private GameObject m_makeDoubleButton;

	[SerializeField]
	private GameObject m_doubledBadge;

	[SerializeField]
	private float m_giveCrownsDelay;

	[SerializeField]
	private QueensLiveLeaderboardWidget m_leaderboardWidget;

	private Transform m_crownReceiver;

	private bool m_isPunching;

	private Tween m_punchTween;

	private void GiveCrowns()
	{
	}

	private void PunchScale()
	{
	}

	protected override void MakeRewardsDouble()
	{
	}
}
