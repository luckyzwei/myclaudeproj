using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DailyMissionTimerWidget : MonoBehaviour
{
	private const int TIME_TO_REFRESH = 60;

	[SerializeField]
	private TMP_Text m_text;

	private int m_lastWrittenTime;

	private float m_startRemainingTime;

	private float m_elapsedTime;

	public event GameplayEvents.BasicDelegate OnTimeOut
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

	private void Reset()
	{
	}

	private void Update()
	{
	}
}
