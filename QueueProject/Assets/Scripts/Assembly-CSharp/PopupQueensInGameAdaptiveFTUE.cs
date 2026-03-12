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
		string prefabName = GetPrefabName();
		return StartFTUEPopUp(prefabName, finishCallback);
	}

	public static bool TryToStartExpert(Action finishCallback)
	{
		string prefabName = GetExpertPrefabName();
		return StartFTUEPopUp(prefabName, finishCallback);
	}

	private static bool StartFTUEPopUp(string prefabName, Action finishCallback)
	{
		UnityEngine.Debug.Log($"[FTUE] StartFTUEPopUp prefab={prefabName}");
		var popup = ShowPopup<PopupQueensInGameAdaptiveFTUE>(prefabName, null);
		UnityEngine.Debug.Log($"[FTUE] ShowPopup returned: {(popup != null ? popup.name : "NULL")}");
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
		UnityEngine.Debug.Log($"[FTUE] Start() - m_steps={m_steps?.Length ?? -1}, m_continueButton={m_continueButton != null}, m_hintButton={m_hintButton != null}");

		if (m_continueButton != null)
			m_continueButton.onClick.AddListener(ContinueButtonPressed);
		if (m_hintButton != null)
			m_hintButton.onClick.AddListener(HintButtonPressed);

		// Find grid
		if (QueensGameController.Instance != null)
			m_grid = QueensGameController.Instance.Grid;

		UnityEngine.Debug.Log($"[FTUE] Grid={m_grid != null}, QueensGameController.Instance={QueensGameController.Instance != null}");

		// Debug: check popup visibility
		var rt = GetComponent<RectTransform>();
		UnityEngine.Debug.Log($"[FTUE] Popup pos={transform.position}, localPos={transform.localPosition}, siblingIndex={transform.GetSiblingIndex()}, parent={transform.parent?.name}, childCount={transform.childCount}");
		if (rt != null) UnityEngine.Debug.Log($"[FTUE] RectTransform size={rt.sizeDelta}, anchors=({rt.anchorMin},{rt.anchorMax}), pivot={rt.pivot}");
		var cg = GetComponent<CanvasGroup>();
		if (cg != null) UnityEngine.Debug.Log($"[FTUE] CanvasGroup alpha={cg.alpha}, interactable={cg.interactable}, blocksRaycasts={cg.blocksRaycasts}");
		var canvas = GetComponent<Canvas>();
		if (canvas != null) UnityEngine.Debug.Log($"[FTUE] Canvas overrideSorting={canvas.overrideSorting}, sortingOrder={canvas.sortingOrder}");
		else UnityEngine.Debug.Log("[FTUE] No Canvas component on popup root - may be behind GameScreen!");

		// Force to front
		transform.SetAsLastSibling();

		// Let clicks pass through to the grid/ControlPad underneath
		var canvasGroup = GetComponent<CanvasGroup>();
		if (canvasGroup == null)
			canvasGroup = gameObject.AddComponent<CanvasGroup>();
		canvasGroup.blocksRaycasts = false;

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
		UnityEngine.Debug.Log($"[FTUE] PlayNextStep - step={m_step}, m_steps={(m_steps != null ? m_steps.Length.ToString() : "NULL")}");
		if (m_steps == null || m_step >= m_steps.Length)
		{
			UnityEngine.Debug.Log("[FTUE] No more steps, finishing");
			OnStepFinished();
			return;
		}

		m_continue = false;

		var step = m_steps[m_step];
		UnityEngine.Debug.Log($"[FTUE] Playing step {m_step}: {(step != null ? step.name : "NULL")}");
		if (step != null)
		{
			step.Play(m_grid, () =>
			{
				m_continue = true;
				m_step++;
				PlayNextStep();
			});
		}
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
		if (m_continue)
			return; // Step already completed and auto-advanced, ignore duplicate

		// 通知当前 step 的 ContinueButtonFtueAction
		if (m_steps != null && m_step >= 0 && m_step < m_steps.Length)
		{
			var step = m_steps[m_step];
			if (step != null)
			{
				// 调用当前步骤的 ContinuePressed，让 action 正常完成
				// 这会触发 action callback → step callback → 自动推进
				var actions = step.GetComponentsInChildren<ContinueButtonFtueAction>(true);
				if (actions != null && actions.Length > 0)
				{
					// 重新禁用 raycasts
					var cg = GetComponent<CanvasGroup>();
					if (cg != null)
						cg.blocksRaycasts = false;

					for (int i = 0; i < actions.Length; i++)
						actions[i].ContinuePressed();
					return;
				}
			}
		}

		// 备用路径：没有 ContinueButtonFtueAction 时直接推进
		m_continue = true;
		var canvasGroup = GetComponent<CanvasGroup>();
		if (canvasGroup != null)
			canvasGroup.blocksRaycasts = false;

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
