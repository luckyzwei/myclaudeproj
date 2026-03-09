using System;
using TMPro;
using UnityEngine;

public class QueensEventSchedule : MonoBehaviour
{
	[Serializable]
	public struct TextInfo
	{
		public TMP_Text text;

		public string keyFormat;
	}

	[SerializeField]
	private TextMeshProUGUI m_dayNumbeText;

	[Space]
	[SerializeField]
	private TextMeshProUGUI m_dayInWeekText;

	[SerializeField]
	private string m_startDayFormat;

	[SerializeField]
	private string m_resumeDayFormat;

	[SerializeField]
	private bool m_addNumberSuffix;

	[SerializeField]
	private TextInfo[] m_textInfos;

	private bool m_started;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Config()
	{
	}

	private string GetDayText(int day)
	{
		return null;
	}
}
