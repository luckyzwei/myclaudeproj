using System;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class PopupCountdown : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/Popups/Popup-Countdown";

	private const string ANIM_INTRO = "Intro";

	[SerializeField]
	private TMP_Text m_topText;

	public static void Show(Action closedCallback, string topText)
	{
	}

	private void Start()
	{
	}

	private void SetText(string text)
	{
	}

	public void AnimEvent_CountDownStart()
	{
	}
}
