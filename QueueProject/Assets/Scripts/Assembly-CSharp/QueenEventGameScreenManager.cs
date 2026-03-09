using System;
using UnityEngine;

public class QueenEventGameScreenManager : MonoBehaviour, IQueueableEntity
{
	[SerializeField]
	private bool m_autoOpenIfUnlaimedRewards;

	private const int NUM_TICKS_IN_A_SECOND = 10000000;

	private const int NUM_SECONDS_IN_A_MINUTE = 60;

	private const int MINUTE_DIFFERENCE_THRESHOLD = 5;

	private bool m_isTimeUp;

	private bool m_unclaimedReward;

	private void Awake()
	{
	}

	public void TryShowEventStart()
	{
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}

	private bool HasAlreadySeenPopup()
	{
		return false;
	}

	private int TimeThatEventFinishes()
	{
		return 0;
	}
}
