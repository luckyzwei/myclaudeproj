using System;
using Balancy.Models.LiveOps.Store;
using KWLocalisation.Localisation;
using UnityEngine;

public class StoreProductCellTimer : MonoBehaviour
{
	private const int TIMER_REFRESH_RATE = 1;

	[SerializeField]
	private TextWrapper m_textWrapper;

	private Slot m_slot;

	private bool m_timerSubscribed;

	private Action m_timerCompleteAction;

	public void ConfigureTimer(Slot slot, Action onTimerCompleteAction)
	{
	}

	private void OnDisable()
	{
	}

	public bool CheckShouldTimerBeActive()
	{
		return false;
	}

	private void SetTimerText()
	{
	}

	private void UpdateTimer()
	{
	}
}
