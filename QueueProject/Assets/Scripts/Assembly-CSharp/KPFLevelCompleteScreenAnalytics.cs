using System.Collections;
using UnityEngine;

public class KPFLevelCompleteScreenAnalytics : MonoBehaviour
{
	private const string COMPLETE_SCREEN_START = "kpf_level_complete_screen_start";

	private const string COMPLETE_SCREEN_END = "kpf_level_complete_screen_end";

	private Hashtable m_rewardHashtable;

	private int m_numTaps;

	private float m_startTime;

	public void SendCompleteScreenStartEvent(string context)
	{
	}

	public void SendLevelCompleteScreenEndEvent(string context, bool multiplierUsed)
	{
	}

	private void IncrementTaps()
	{
	}
}
