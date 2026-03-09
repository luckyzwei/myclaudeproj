using System;
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "QueensDailyChallenge", menuName = "DailyChallenges/QueensDailyChallenge")]
public class QueensDailyChallenge : DailyChallenge
{
	[Serializable]
	public class MonthTrophies
	{
		public Sprite bronze;

		public Sprite silver;

		public Sprite gold;

		public Sprite empty;

		[Space]
		public float startFillValue;

		public float completeFillValue;
	}

	[Serializable]
	public class YearTrophies
	{
		public string title;

		public int year;

		public MonthTrophies[] trophies;
	}

	public const string CLIENT_ID = "dailychallenge";

	[Space(5f)]
	[Header("Cell Date Complete Effect")]
	[SerializeField]
	private CellDateCompleteEffect m_cellDateCompleteEffectPrefab;

	[SerializeField]
	private float m_dateCompleteMoveDelay;

	[SerializeField]
	private float m_dateCompleteMoveDuration;

	[SerializeField]
	private float m_dateCompleteMoveDelayBeforeEach;

	[SerializeField]
	private Ease m_dateCompleteMoveEase;

	[SerializeField]
	private float m_finalDateCompleteScale;

	[Space]
	[SerializeField]
	private YearTrophies[] m_trophies;

	private LevelDataScriptable m_currentPuzzle;

	public override void OnDailyChallengeWidgetUpdated(DCDate date)
	{
	}

	public override void OnChallengeStarted()
	{
	}

	private void SendAnalytics(string state, bool increaseAttempts = false)
	{
	}

	private int GetAttemptsAndIncrease(DCDate date, bool increase)
	{
		return 0;
	}

	private bool IsBefore(DCDate day1, DCDate day2)
	{
		return false;
	}

	private int GetCompletedChallengesCountThisMonth(DCDate date)
	{
		return 0;
	}

	public override void OnChallengeComplete()
	{
	}

	public override void OnChallengeFailed()
	{
	}

	public LevelDataScriptable PickDailyChallengeLevel()
	{
		return null;
	}

	private int GetSeedForDate(DCDate date)
	{
		return 0;
	}

	public void SetPopupInteractible(bool interactible)
	{
	}

	public void FlyEffectToTrophy(int day, Action callback)
	{
	}

	public MonthTrophies GetTrophySprites(int year, int month)
	{
		return null;
	}

	public float GetTrophyFillAmount(float fillAmount, int year, int month)
	{
		return 0f;
	}

	private MonthTrophies FindMonthTrophy(int year, int month)
	{
		return null;
	}
}
