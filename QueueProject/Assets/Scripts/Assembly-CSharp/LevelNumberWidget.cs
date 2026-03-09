using TMPro;
using UnityEngine;

public class LevelNumberWidget : MonoBehaviour
{
	private const string DAILY_CHALLENGE_KEY = "GameScreen.DailyChallengeText";

	private const string LEVEL_TEXT = "GameScreen.LevelText";

	private const string PVP_KEY = "GameScreen.LevelTextPVP";

	private const string EXPERT_MODE_KEY = "GameScreen.LevelTextExpertMode";

	[SerializeField]
	private TextMeshProUGUI m_text;

	private void Start()
	{
	}
}
