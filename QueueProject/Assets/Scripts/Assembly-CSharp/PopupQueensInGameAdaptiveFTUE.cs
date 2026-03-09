using System;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupQueensInGameAdaptiveFTUE : PopUpBase
{
	private const string PREFAB_NAME_A = "Prefabs/Popups/Popup-FTUE-SchemeA";

	private const string PREFAB_NAME_B = "Prefabs/Popups/Popup-FTUE-SchemeB";

	private const string PREFAB_NAME_C = "Prefabs/Popups/Popup-FTUE-SchemeC";

	private const string PREFAB_NAME_EXPERT = "Prefabs/Popups/Popup-FTUE-Expert";

	[SerializeField]
	private FtueStep[] m_steps;

	[SerializeField]
	private Button m_hintButton;

	[SerializeField]
	private Button m_continueButton;

	[SerializeField]
	private bool m_autoCompleteLevelOnComplete;

	private bool m_continue;

	private int m_crossCount;

	private int m_step;

	private QueensGrid m_grid;

	private Action m_finishCallback;

	public static bool TryToStart(Action finishCallback)
	{
		return false;
	}

	public static bool TryToStartExpert(Action finishCallback)
	{
		return false;
	}

	private static bool StartFTUEPopUp(string prefabName, Action finishCallback)
	{
		return false;
	}

	public static void Resume(int stepIndex, Action finishCallback)
	{
	}

	private static string GetPrefabName()
	{
		return null;
	}

	private static string GetExpertPrefabName()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnLevelSolved()
	{
	}

	private void Config(int stepIndex)
	{
	}

	private void ToggleGameScreenParts(bool value)
	{
	}

	private void PlayNextStep()
	{
	}

	private void OnStepFinished()
	{
	}

	public void HintButtonPressed()
	{
	}

	public void ContinueButtonPressed()
	{
	}

	public int GetStepIndex()
	{
		return 0;
	}

	public Action GetFinishCallback()
	{
		return null;
	}
}
