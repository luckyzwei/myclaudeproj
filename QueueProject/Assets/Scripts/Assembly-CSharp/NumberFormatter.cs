using System;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class NumberFormatter : MonoBehaviour
{
	[Serializable]
	public class ThresholdData
	{
		public int threshold;

		public string suffix;
	}

	[SerializeField]
	private string m_format;

	[SerializeField]
	private ThresholdData[] m_thresholdData;

	[SerializeField]
	private Text m_targetText;

	private long m_number;

	private void OnValidate()
	{
	}

	public void SetNumber(long number)
	{
	}

	public string FormatNumber(float number)
	{
		return null;
	}

	public long GetNumber()
	{
		return 0L;
	}
}
