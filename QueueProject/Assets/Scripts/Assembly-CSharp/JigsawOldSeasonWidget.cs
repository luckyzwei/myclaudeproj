using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JigsawOldSeasonWidget : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI m_titleTMP;

	[SerializeField]
	private TextMeshProUGUI m_completedPuzzlesTMP;

	[SerializeField]
	private Image m_backgroundImage;

	private string m_eventId;

	public void Configure(string clientId)
	{
	}

	public void OnButtonPressed()
	{
	}
}
