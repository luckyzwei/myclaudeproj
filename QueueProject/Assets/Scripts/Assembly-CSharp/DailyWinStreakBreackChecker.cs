using System;
using UnityEngine;

public class DailyWinStreakBreackChecker : MonoBehaviour, IQueueableEntity
{
	private void Awake()
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
}
