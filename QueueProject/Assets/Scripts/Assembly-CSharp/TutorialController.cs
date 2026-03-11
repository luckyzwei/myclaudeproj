using System.Collections.Generic;
using KWCore.SaveData;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
	private List<QueensGridCell> m_neighborCells;

	private PopUpExtraTutorial m_popUpExtraTutorial;

	private int m_toturialType;

	private void Start()
	{
		Debug.Log("[TutorialController] Start() - subscribing to events");
		GameplayEvents.GameScreenLoaded += OnGameScreenLoaded;
		GameplayEvents.GridIntroDone += OnGridConfigured;
	}

	private void OnDestroy()
	{
		GameplayEvents.GameScreenLoaded -= OnGameScreenLoaded;
		GameplayEvents.GridIntroDone -= OnGridConfigured;
	}

	private void OnGameScreenLoaded()
	{
		Debug.Log($"[TutorialController] OnGameScreenLoaded - FtueCompleted={BucketGameplay.FtueGameplayCompleted}");
		if (!BucketGameplay.FtueGameplayCompleted)
		{
			bool started = PopupQueensInGameAdaptiveFTUE.TryToStart(OnFtueDone);
			Debug.Log($"[TutorialController] TryToStart returned: {started}");
			if (!started)
			{
				// Fallback: show extra tutorial hand animation
				ShowExtraTutorial();
			}
		}
	}

	private void OnGridConfigured()
	{
		// Grid is ready for interaction
	}

	private void OnFtueDone()
	{
		Debug.Log("[TutorialController] FTUE done, marking complete and loading Level 1");
		BucketGameplay.SetFtueGameplayCompleted(true);

		// After FTUE completes, load the real Level 1
		if (GameManager.Instance != null)
		{
			GameManager.Instance.StartGame(GameManager.GameMode.STANDARD);
		}
	}

	private void ShowExtraTutorial()
	{
		Debug.Log("[TutorialController] Showing ExtraTutorial fallback");
		m_popUpExtraTutorial = KWCore.UI.PopUpBase.ShowPopup<PopUpExtraTutorial>(PopUpExtraTutorial.PREFAB_NAME, null);
		if (m_popUpExtraTutorial != null)
		{
			m_popUpExtraTutorial.OnDone += ExtraTutorialDone;
		}
	}

	private void ExtraTutorialDone()
	{
		if (m_popUpExtraTutorial != null)
		{
			m_popUpExtraTutorial.OnDone -= ExtraTutorialDone;
			m_popUpExtraTutorial = null;
		}
		OnFtueDone();
	}
}
