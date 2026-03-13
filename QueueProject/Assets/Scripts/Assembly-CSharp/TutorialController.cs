using System.Collections.Generic;
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
		bool isPlayingFtue = GameManager.Instance != null && GameManager.Instance.IsPlayingFtue;
		Debug.Log($"[TutorialController] OnGameScreenLoaded - IsPlayingFtue={isPlayingFtue}");

		if (isPlayingFtue)
		{
			// 教学关卡一定出现引导
			bool started = PopupQueensInGameAdaptiveFTUE.TryToStart(OnFtueDone);
			Debug.Log($"[TutorialController] TryToStart returned: {started}");
			if (!started)
			{
				bool showedExtra = ShowExtraTutorial();
				if (!showedExtra)
				{
					// 引导弹窗都无法加载，跳过教学
					Debug.Log("[TutorialController] FTUE popups failed, skipping");
					OnFtueDone();
				}
			}
		}
	}

	private void OnGridConfigured()
	{
		// Grid is ready for interaction
	}

	private void OnFtueDone()
	{
		Debug.Log("[TutorialController] FTUE done");
		if (GameManager.Instance != null)
			GameManager.Instance.MarkFtueCompleted();
	}

	private bool ShowExtraTutorial()
	{
		Debug.Log("[TutorialController] Showing ExtraTutorial fallback");
		m_popUpExtraTutorial = KWCore.UI.PopUpBase.ShowPopup<PopUpExtraTutorial>(PopUpExtraTutorial.PREFAB_NAME, null);
		if (m_popUpExtraTutorial != null)
		{
			m_popUpExtraTutorial.OnDone += ExtraTutorialDone;
			return true;
		}
		return false;
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
