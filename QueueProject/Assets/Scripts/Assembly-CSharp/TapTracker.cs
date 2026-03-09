using System;
using UnityEngine;

public class TapTracker : MonoBehaviour
{
	private int m_numTaps;

	private Action m_onTapCallback;

	private bool m_isTracking;

	private void Start()
	{
	}

	public void StartTracking(Action onTap)
	{
	}

	public int GetTotalTaps()
	{
		return 0;
	}

	private void Update()
	{
	}
}
