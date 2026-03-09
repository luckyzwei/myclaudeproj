using System;
using DG.Tweening;
using UnityEngine;

public class LeaderboardCellPositionChangeAnimator : ScrollItemPositionChangeAnimator<LeaderboardCell>
{
	[Header("Timings")]
	[SerializeField]
	private float m_scaleUpFactor;

	[SerializeField]
	private float m_scaleUpDuration;

	[SerializeField]
	private Ease m_scaleUpEase;

	[SerializeField]
	private float m_scaleDownDuration;

	[SerializeField]
	private Ease m_scaleDownEase;

	[Header("Counting Animation")]
	[SerializeField]
	private Ease m_rankCountEase;

	[SerializeField]
	private Ease m_scoreCountEase;

	private Tween m_rankCountTween;

	private Tween m_scoreCountTween;

	protected int m_fromPosition;

	protected int m_toPosition;

	protected int m_fromScore;

	protected int m_toScore;

	public virtual void AnimateItem(int fromIndex, int toIndex, int fromPosition, int toPosition, int fromScore, int toScore, float scrollDuration = -1f, float delay = -1f, Action onComplete = null)
	{
	}

	protected override void InitialiseOverlayItem(LeaderboardCell sourceItem)
	{
	}

	protected override void AnimateIntro(Action onComplete = null)
	{
	}

	protected override void ShowTargetCell(LeaderboardCell cell)
	{
	}

	protected override void ScrollStart()
	{
	}

	protected override void AnimateOutro(Action onComplete = null)
	{
	}

	protected override void HideTargetCell(LeaderboardCell cell)
	{
	}

	protected virtual float GetRankCountDuration()
	{
		return 0f;
	}

	protected void AnimateRankCountTween(float duration, float delay = 0f)
	{
	}

	protected void AnimateScoreCountTween(float duration, float delay = 0f)
	{
	}
}
