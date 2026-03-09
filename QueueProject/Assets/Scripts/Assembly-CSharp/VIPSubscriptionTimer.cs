using System.Runtime.CompilerServices;
using KWLocalisation.Localisation;
using UnityEngine;

public class VIPSubscriptionTimer : MonoBehaviour
{
	[SerializeField]
	private TextWrapper m_timerText;

	[SerializeField]
	private bool m_disableIfNoDiscount;

	[SerializeField]
	private string m_timerPrefix;

	private const float UPDATE_EVERY_X_SECS = 1f;

	private float m_timer;

	public event GameplayEvents.BasicDelegate TimeOut
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

	private void Start()
	{
	}

	private string GetTimeAsString()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateTimerText()
	{
	}

	private string GetFormattedTime(int totalSeconds)
	{
		return null;
	}
}
