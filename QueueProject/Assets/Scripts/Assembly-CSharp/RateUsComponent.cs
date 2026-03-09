using System;
using UnityEngine;

public class RateUsComponent : MonoBehaviour, IQueueableEntity
{
	private void Awake()
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

	public void StartProcess(Action finishCallback)
	{
	}
}
