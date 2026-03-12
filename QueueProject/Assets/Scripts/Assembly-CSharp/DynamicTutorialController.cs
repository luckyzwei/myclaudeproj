using KWCore.SaveData;
using KWGameCore.Events;
using UnityEngine;

public class DynamicTutorialController : MonoBehaviour
{
	private const int MAX_AMOUNT_OF_TIMES_TO_SHOW_TUTORIAL = 2;

	private void Awake()
	{
		GameCoreEvents.GameStarted += GameCoreEvents_GameStarted;
	}

	private void OnDestroy()
	{
		GameCoreEvents.GameStarted -= GameCoreEvents_GameStarted;
	}

	private void GameCoreEvents_GameStarted()
	{
		// 第一关一定弹窗"如何玩"，但教学关卡除外
		int levelIndex = KWCore.SaveData.BucketGameCore.ProgressManagerLevelIndex;
		if (levelIndex > 0)
			return;

		if (GameManager.Instance != null && GameManager.Instance.IsPlayingFtue)
			return;

		TutorialPopup.Show();
	}
}
