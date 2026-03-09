using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallengeMonthPosterController : MonoBehaviour
{
	[SerializeField]
	private string m_dailyChallengeId;

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private TMP_Text m_monthText;

	[SerializeField]
	private TMP_Text m_yearText;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnMonthChanged(int integer)
	{
	}

	private void SetMonth(int month)
	{
	}
}
