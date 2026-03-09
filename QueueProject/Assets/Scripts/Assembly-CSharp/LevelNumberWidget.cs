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
		UnityEngine.Debug.Log($"[LevelNumberWidget] Start called. m_text={m_text != null} gameObject={gameObject.name} active={gameObject.activeSelf} parent={transform.parent?.name}");
		if (m_text == null)
		{
			UnityEngine.Debug.LogWarning("[LevelNumberWidget] m_text is null!");
			return;
		}

		var gm = GameManager.Instance;
		if (gm == null)
		{
			UnityEngine.Debug.LogWarning("[LevelNumberWidget] GameManager.Instance is null!");
			return;
		}

		// Determine level number (0-based index + 1 for display)
		int levelNum = 1;
		if (gm.LevelOrder != null && gm.CurrentLevelScriptable != null
			&& gm.LevelOrder.levelOrder != null && gm.LevelOrder.levelOrder.levels != null)
		{
			var levels = gm.LevelOrder.levelOrder.levels;
			for (int i = 0; i < levels.Count; i++)
			{
				if (levels[i] == gm.CurrentLevelScriptable)
				{
					levelNum = i + 1;
					break;
				}
			}
		}

		switch (gm.CurrentGameMode)
		{
			case GameManager.GameMode.DAILY_CHALLENGE:
				m_text.text = "Daily Challenge";
				break;
			case GameManager.GameMode.PVP:
				m_text.text = "PVP";
				break;
			case GameManager.GameMode.EXPERT_MODE:
				m_text.text = $"Expert Level {levelNum}";
				break;
			default:
				m_text.text = $"Level {levelNum}";
				break;
		}
		UnityEngine.Debug.Log($"[LevelNumberWidget] Set text to: '{m_text.text}' fontSize={m_text.fontSize} color={m_text.color} enabled={m_text.enabled}");
	}
}
