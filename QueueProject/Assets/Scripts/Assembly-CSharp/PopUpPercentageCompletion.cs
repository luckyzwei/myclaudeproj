using System;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class PopUpPercentageCompletion : PopUpBase
{
	private static float s_percentageCalculated;

	private const float PERCENTAGE_NOISE = 0.1f;

	[SerializeField]
	private TMP_Text m_tmpText;

	[SerializeField]
	private string m_percentageCompletionTextKey;

	[SerializeField]
	private float m_delayBeforeClose;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	private const string ANIM_INTRO_1 = "Intro-1";

	private bool m_isClosing;

	private float m_time;

	public static float PercentageComplete => 0f;

	private void Start()
	{
	}

	public static float GetPercentage()
	{
		return 0f;
	}

	public void PlayAnim(bool alreadyShowingDifficultyPopup)
	{
	}

	private void FinishedAnimation()
	{
	}

	public void SetPercentage(float percentage)
	{
	}

	private void PlayAnimation(string animation, Action callback)
	{
	}
}
