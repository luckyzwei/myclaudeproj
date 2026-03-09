using System;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyPopUpController : MonoBehaviour, IQueueableEntity
{
	[Tooltip("These popups should match the difficulty enim size, keep null if you dont want to show a popup for particular difficulty")]
	[SerializeField]
	private PrefabReference[] m_difficultyPopUps;

	[SerializeField]
	private PrefabReference m_percentageCompletePopUp;

	[SerializeField]
	private PrefabReference m_dailyChallengePopUp;

	[SerializeField]
	private bool m_showOnStart;

	[SerializeField]
	private List<GameManager.GameMode> m_allowedGameModes;

	private void Awake()
	{
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}

	public bool TryShowDifficultyPopUp(Action popupClosedCallback)
	{
		return false;
	}
}
