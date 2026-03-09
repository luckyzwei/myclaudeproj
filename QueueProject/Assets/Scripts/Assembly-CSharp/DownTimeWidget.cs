using TMPro;
using UnityEngine;

public class DownTimeWidget : MonoBehaviour
{
	[SerializeField]
	private GameObject m_content;

	[SerializeField]
	private TextMeshProUGUI m_timerText;

	private void Awake()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void UpdateTimeText(int timeSeconds)
	{
	}

	private void HideIfTimerFinished()
	{
	}

	private void Update()
	{
	}
}
