using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyChallengeWithProgressReward", menuName = "DailyChallenges/DailyChallengeWithProgressReward")]
public class DailyChallengeWithProgressReward : DailyChallenge
{
	[Space(5f)]
	[Header("Cell Date Complete Effect")]
	[SerializeField]
	private CellDateCompleteEffect m_cellDateCompleteEffectPrefab;

	[SerializeField]
	private float m_dateCompleteMoveDelay;

	[SerializeField]
	private float m_dateCompleteMoveDuration;

	[SerializeField]
	private Ease m_dateCompleteMoveEase;

	[SerializeField]
	private float m_finalDateCompleteScale;

	public override void ShowDailyChallengePopup(bool firstShow = true)
	{
	}

	protected virtual void MoveDateCompleteCellToProgressWidget()
	{
	}

	public override void OnDailyChallengeWidgetUpdated(DCDate date)
	{
	}
}
