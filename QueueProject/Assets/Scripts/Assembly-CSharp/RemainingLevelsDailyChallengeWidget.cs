using TMPro;
using UnityEngine;

public class RemainingLevelsDailyChallengeWidget : MonoBehaviour
{
	[SerializeField]
	private string m_widgetID;

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private string m_formatKey;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnMonthChange(int integer)
	{
	}

	private void Start()
	{
	}

	private void RefreshText()
	{
	}

	private int GetLevelsUntilNextReward()
	{
		return 0;
	}
}
