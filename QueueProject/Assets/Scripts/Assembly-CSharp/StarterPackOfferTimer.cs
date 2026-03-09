using TMPro;
using UnityEngine;

public class StarterPackOfferTimer : MonoBehaviour
{
	private const float UPDATE_EVERY_X_SECS = 1f;

	[SerializeField]
	private string m_gameEventId;

	[SerializeField]
	private TextMeshProUGUI m_timeText;

	private SpecialOfferData m_specialOfferData;

	private float m_timer;

	private void OnEnable()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void UpdateTimeText(int timeSeconds)
	{
	}

	private void Update()
	{
	}
}
