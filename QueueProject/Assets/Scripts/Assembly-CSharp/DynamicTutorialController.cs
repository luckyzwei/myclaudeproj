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
		// currentLevel=1 是第一关，弹"如何玩"；0是教学关卡不弹，>1也不弹
		int levelIndex = KWCore.SaveData.BucketGameCore.ProgressManagerLevelIndex;
		if (levelIndex != 1)
			return;

		TutorialPopup.Show();
	}
}
