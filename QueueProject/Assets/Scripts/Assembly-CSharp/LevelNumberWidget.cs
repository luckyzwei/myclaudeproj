using KWCore.SaveData;
using UnityEngine.UI;
using UnityEngine;

public class LevelNumberWidget : MonoBehaviour
{
	private const string DAILY_CHALLENGE_KEY = "GameScreen.DailyChallengeText";

	private const string LEVEL_TEXT = "GameScreen.LevelText";

	private const string PVP_KEY = "GameScreen.LevelTextPVP";

	private const string EXPERT_MODE_KEY = "GameScreen.LevelTextExpertMode";

	[SerializeField]
	private Text m_text;

	private void Start()
	{
		if (m_text == null) return;

		var gm = GameManager.Instance;
		if (gm == null) return;

		// FTUE 教学关卡检测
		if (!BucketGameplay.FtueGameplayCompleted)
		{
			m_text.text = Kwalee.GetLocalisedText("GameScreen.TutorialLevel");
			// 如果本地化没有该 key，回退到中文
			if (m_text.text == "GameScreen.TutorialLevel")
				m_text.text = "教学关卡";
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

		string text;
		switch (gm.CurrentGameMode)
		{
			case GameManager.GameMode.DAILY_CHALLENGE:
				text = Kwalee.GetLocalisedText(DAILY_CHALLENGE_KEY, "");
				break;
			case GameManager.GameMode.PVP:
				text = Kwalee.GetLocalisedText(PVP_KEY);
				break;
			case GameManager.GameMode.EXPERT_MODE:
				text = Kwalee.GetLocalisedText(EXPERT_MODE_KEY, levelNum);
				break;
			default:
				text = Kwalee.GetLocalisedText(LEVEL_TEXT, levelNum);
				break;
		}
		m_text.text = text;
	}
}
