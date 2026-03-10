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
		// FTUE tutorial - skip for now, just invoke callback
		finishCallback?.Invoke();
		return false;
	}

	public static bool TryToStartExpert(Action finishCallback)
	{
		finishCallback?.Invoke();
		return false;
	}

	private static bool StartFTUEPopUp(string prefabName, Action finishCallback)
	{
		var popup = ShowPopup<PopupQueensInGameAdaptiveFTUE>(prefabName, null);
		if (popup != null)
		{
			popup.m_finishCallback = finishCallback;
			return true;
		}
		return false;
	}

	public static void Resume(int stepIndex, Action finishCallback)
	{
		// Resume FTUE from step
		var prefabName = GetPrefabName();
		if (string.IsNullOrEmpty(prefabName)) return;
		var popup = ShowPopup<PopupQueensInGameAdaptiveFTUE>(prefabName, null);
		if (popup != null)
		{
			popup.m_finishCallback = finishCallback;
			popup.Config(stepIndex);
		}
	}

	private static string GetPrefabName()
	{
		return PREFAB_NAME_A;
	}

	private static string GetExpertPrefabName()
	{
		return PREFAB_NAME_EXPERT;
	}

	private void Start()
	{
		if (m_continueButton != null)
			m_continueButton.onClick.AddListener(ContinueButtonPressed);
		if (m_hintButton != null)
			m_hintButton.onClick.AddListener(HintButtonPressed);

		// Find grid
		if (QueensGameController.Instance != null)
			m_grid = QueensGameController.Instance.Grid;

		Config(0);
	}

	private void OnLevelSolved()
	{
		// Level solved during FTUE - finish
		m_finishCallback?.Invoke();
		Close();
	}

	private void Config(int stepIndex)
	{
		m_step = stepIndex;
		PlayNextStep();
	}

	private void ToggleGameScreenParts(bool value)
	{
		// Toggle game screen visibility during tutorial steps
	}

	private void PlayNextStep()
	{
		if (m_steps == null || m_step >= m_steps.Length)
		{
			OnStepFinished();
			return;
		}

		var step = m_steps[m_step];
		if (step != null)
			step.Play(m_grid, () => { m_continue = true; });

		m_continue = false;
	}

	private void OnStepFinished()
	{
		// All steps complete
		if (m_grid != null)
			m_grid.ClearFtueMode();
		m_finishCallback?.Invoke();
		Close();
	}

	public void HintButtonPressed()
	{
		// Show hint for current step
		if (m_grid != null)
			m_grid.HintBooster();
	}

	public void ContinueButtonPressed()
	{
		m_continue = true;
		m_step++;
		if (m_steps != null && m_step < m_steps.Length)
			PlayNextStep();
		else
			OnStepFinished();
	}

	public int GetStepIndex()
	{
		return m_step;
	}

	public Action GetFinishCallback()
	{
		return m_finishCallback;
	}
}
