using System;
using System.Runtime.CompilerServices;
using Balancy.Models;
using TMPro;
using UnityEngine;

public class LimitedOfferTimer : MonoBehaviour
{
	[Space(10f)]
	[SerializeField]
	private TextMeshProUGUI m_timeText;

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
