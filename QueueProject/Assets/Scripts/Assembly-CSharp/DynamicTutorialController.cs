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
		// Don't show tutorial reminder if the main FTUE is still in progress
		if (!BucketGameplay.FtueGameplayCompleted)
			return;

		// Show tutorial if player hasn't seen it enough times
		int shownCount = BucketGameplay.GetShownTutorialAmount();
		if (shownCount < MAX_AMOUNT_OF_TIMES_TO_SHOW_TUTORIAL)
		{
			TutorialPopup.Show();
			BucketGameplay.IncrementAndSetShownTutorialAmount();
		}
	}
}
