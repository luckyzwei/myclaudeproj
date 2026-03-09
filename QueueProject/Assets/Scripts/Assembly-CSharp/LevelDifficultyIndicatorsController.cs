using TMPro;
using UnityEngine;

public class LevelDifficultyIndicatorsController : MonoBehaviour
{
	private const string HARD_LEVEL_KEY = "PopupDifficulty.Hard";

	private const string VERY_HARD_LEVEL_KEY = "PopupDifficulty.VeryHard";

	[SerializeField]
	private GameObject[] m_difficultyIndicators;

	[SerializeField]
	private Color[] m_textColors;

	[SerializeField]
	private TMP_Text[] m_colorTexts;

	[SerializeField]
	private TMP_Text m_hardLevelText;

	[SerializeField]
	private TMP_Text m_veryHardLevelText;

	private void Awake()
	{
	}

	private string LocalizeAndRemoveNewLine(string key)
	{
		return null;
	}
}
