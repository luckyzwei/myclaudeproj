using System;
using KWCore.UI;
using UnityEngine;

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

	public static void Show(Action closeCallback = null)
	{
	}

	private void Start()
	{
	}

	public void OnNextPressed()
	{
	}

	public void OnPrevPressed()
	{
	}

	private void Configure()
	{
	}
}
