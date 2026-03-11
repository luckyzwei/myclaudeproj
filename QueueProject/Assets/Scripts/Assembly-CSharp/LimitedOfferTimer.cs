using System;
using System.Runtime.CompilerServices;
using Balancy.Models;
using UnityEngine.UI;
using UnityEngine;

public class LimitedOfferTimer : MonoBehaviour
{
	[Space(10f)]
	[SerializeField]
	private Text m_timeText;

	private LimitedOffer m_offer;

	private LimitedOfferGameEvent m_event;

	private bool m_eventFired;

	public event Action OnTimeFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Configure(LimitedOffer offer)
	{
	}

	private void UpdateTimeText(int timeSeconds)
	{
	}

	private void Update()
	{
	}
}
