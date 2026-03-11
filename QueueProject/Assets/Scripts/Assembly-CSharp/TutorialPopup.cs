using System;
using KWCore.UI;
using UnityEngine;
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

		// Wire up button click events in code (prefab events may be lost from AssetRipper export)
		BindButton(m_nextButton, OnNextPressed);
		BindButton(m_prevButton, OnPrevPressed);
		BindButton(m_finishButton, OnFinishPressed);

		Configure();
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
		if (m_steps == null) return;
		if (m_currentStep < m_steps.Length - 1)
		{
			m_currentStep++;
			Configure();
		}
	}

	public void OnPrevPressed()
	{
		if (m_currentStep > 0)
		{
			m_currentStep--;
			Configure();
		}
	}

	public void OnFinishPressed()
	{
		m_closeCallback?.Invoke();
		Close();
	}

	private void Configure()
	{
		// Update step animations
		if (m_currentAnimation != null)
			m_currentAnimation.Stop();

		if (m_steps != null && m_currentStep >= 0 && m_currentStep < m_steps.Length)
		{
			m_currentAnimation = m_steps[m_currentStep];
			if (m_currentAnimation != null)
				m_currentAnimation.Play();
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
}
