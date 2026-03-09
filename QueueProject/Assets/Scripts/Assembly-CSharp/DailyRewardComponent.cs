using System;
using KWCore.UI;
using UnityEngine;

public class DailyRewardComponent : MonoBehaviour, IQueueableEntity
{
	private Action m_callback;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
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
