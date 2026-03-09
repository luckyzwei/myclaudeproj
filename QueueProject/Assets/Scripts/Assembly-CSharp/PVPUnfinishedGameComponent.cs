using System;
using UnityEngine;

public class PVPUnfinishedGameComponent : MonoBehaviour, IQueueableEntity
{
	private Action m_finishCallback;

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

	private void Finished()
	{
	}
}
