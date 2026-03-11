using UnityEngine.UI;
using UnityEngine;

public class TimeStarsRowWidget : MonoBehaviour
{
	[SerializeField]
	private Text m_timeText;

	[SerializeField]
	private Text m_starsText;

	[Space]
	[SerializeField]
	private GameObject m_timeLayout;

	[SerializeField]
	private GameObject m_infinityLayout;

	public void Config(int time, int stars)
	{
	}
}
