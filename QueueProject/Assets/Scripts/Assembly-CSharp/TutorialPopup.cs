using System;
using System.Collections;
using KWCore.UI;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class TutorialPopup : PopUpBase
{
	private const string PREFAB_NAME_A = "Prefabs/Popups/PopUp-Tutorial-SchemeA";

	private const string PREFAB_NAME_B = "Prefabs/Popups/PopUp-Tutorial-SchemeB";

	private const string PREFAB_NAME_C = "Prefabs/Popups/PopUp-Tutorial-SchemeC";

	private const string PREFAB_NAME_EXPERT = "Prefabs/Popups/PopUp-Tutorial-Expert";

	private const string ANIM_ACTIVE = "Active";

	private const string ANIM_DISABLED = "Disabled";

	private const string NEXT = "Next";

	private const string DONE = "Got it";

	[SerializeField]
	private PlayableDirectorHelper[] m_steps;

	[SerializeField]
	private AnimatorHelper[] m_pipAnimators;

	[SerializeField]
	private GameObject m_nextButton;

	[SerializeField]
	private GameObject m_prevButton;

	[SerializeField]
	private GameObject m_finishButton;

	private PlayableDirectorHelper m_currentAnimation;

	private int m_currentStep;

	private Action m_closeCallback;

	public static void Show(Action closeCallback = null)
	{
		// Default to scheme A for now
		var popup = ShowPopup<TutorialPopup>(PREFAB_NAME_A, null);
		if (popup != null)
		{
			popup.m_closeCallback = closeCallback;
		}
	}

	private void Start()
	{
		m_currentStep = 0;

		Debug.Log($"[TutorialPopup] Start() — m_steps={m_steps != null}, length={m_steps?.Length ?? 0}, " +
			$"nextBtn={m_nextButton != null}, prevBtn={m_prevButton != null}, finishBtn={m_finishButton != null}");

		// Wire up button click events in code (prefab events may be lost from AssetRipper export)
		BindButton(m_nextButton, OnNextPressed);
		BindButton(m_prevButton, OnPrevPressed);
		BindButton(m_finishButton, OnFinishPressed);

		// Stop any auto-playing PlayableDirectors in children before we take control
		StopAllChildDirectors();

		// Deactivate all step GameObjects first, then configure step 0
		if (m_steps != null)
		{
			for (int i = 0; i < m_steps.Length; i++)
			{
				Debug.Log($"[TutorialPopup] m_steps[{i}] = {(m_steps[i] != null ? m_steps[i].gameObject.name : "NULL")}");
				if (m_steps[i] != null)
					m_steps[i].gameObject.SetActive(false);
			}
		}

		Configure();
	}

	private void StopAllChildDirectors()
	{
		var directors = GetComponentsInChildren<PlayableDirector>(true);
		Debug.Log($"[TutorialPopup] StopAllChildDirectors — found {directors.Length} directors");
		for (int i = 0; i < directors.Length; i++)
		{
			Debug.Log($"[TutorialPopup]   director[{i}]: '{directors[i].gameObject.name}' state={directors[i].state} asset={directors[i].playableAsset?.name ?? "NULL"}");
			directors[i].Stop();
		}
	}

	private void BindButton(GameObject buttonObj, UnityEngine.Events.UnityAction callback)
	{
		if (buttonObj == null) return;
		var btn = buttonObj.GetComponent<Button>();
		if (btn != null)
			btn.onClick.AddListener(callback);
	}

	public void OnNextPressed()
	{
		Debug.Log($"[TutorialPopup] OnNextPressed — currentStep={m_currentStep}, stepsLength={m_steps?.Length ?? 0}");
		if (m_steps == null) return;
		if (m_currentStep < m_steps.Length - 1)
		{
			m_currentStep++;
			Configure();
		}
	}

	public void OnPrevPressed()
	{
		Debug.Log($"[TutorialPopup] OnPrevPressed — currentStep={m_currentStep}");
		if (m_currentStep > 0)
		{
			m_currentStep--;
			Configure();
		}
	}

	public void OnFinishPressed()
	{
		Debug.Log("[TutorialPopup] OnFinishPressed");
		m_closeCallback?.Invoke();
		Close();
	}

	private void Configure()
	{
		Debug.Log($"[TutorialPopup] Configure — step={m_currentStep}");

		// Stop and deactivate previous step
		if (m_currentAnimation != null)
		{
			Debug.Log($"[TutorialPopup]   stopping previous: '{m_currentAnimation.gameObject.name}'");
			m_currentAnimation.Stop();
			m_currentAnimation.gameObject.SetActive(false);
		}

		// Activate and play new step (with one-frame delay so PlayableDirector can rebuild graph)
		if (m_steps != null && m_currentStep >= 0 && m_currentStep < m_steps.Length)
		{
			m_currentAnimation = m_steps[m_currentStep];
			if (m_currentAnimation != null)
			{
				Debug.Log($"[TutorialPopup]   activating & playing: '{m_currentAnimation.gameObject.name}'");
				m_currentAnimation.gameObject.SetActive(true);
				StartCoroutine(PlayStepDelayed(m_currentAnimation));
			}
			else
			{
				Debug.LogWarning($"[TutorialPopup]   m_steps[{m_currentStep}] is NULL!");
			}
		}

		// Update pip indicators
		if (m_pipAnimators != null)
		{
			for (int i = 0; i < m_pipAnimators.Length; i++)
			{
				if (m_pipAnimators[i] != null)
					m_pipAnimators[i].SetTrigger(i == m_currentStep ? ANIM_ACTIVE : ANIM_DISABLED);
			}
		}

		// Update navigation buttons
		bool isLastStep = m_steps != null && m_currentStep >= m_steps.Length - 1;
		if (m_prevButton != null)
			m_prevButton.SetActive(m_currentStep > 0);
		if (m_nextButton != null)
			m_nextButton.SetActive(!isLastStep);
		if (m_finishButton != null)
			m_finishButton.SetActive(isLastStep);
	}

	private IEnumerator PlayStepDelayed(PlayableDirectorHelper step)
	{
		// Wait one frame for PlayableDirector to rebuild its playable graph after GameObject activation
		yield return null;
		if (step != null && step.gameObject.activeInHierarchy)
		{
			Debug.Log($"[TutorialPopup] PlayStepDelayed — playing '{step.gameObject.name}'");
			step.Play();
		}
		else
		{
			Debug.LogWarning($"[TutorialPopup] PlayStepDelayed — step is null or inactive!");
		}
	}
}
