using TMPro;
using UnityEngine;

public class TimeStarsRowWidget : MonoBehaviour
{
	[SerializeField]
	private TMP_Text m_timeText;

	[SerializeField]
	private TMP_Text m_starsText;

	[Space]
	[SerializeField]
	private GameObject m_timeLayout;

	[SerializeField]
	private GameObject m_infinityLayout;

	public void Config(int time, int stars)
	{
	}
}
