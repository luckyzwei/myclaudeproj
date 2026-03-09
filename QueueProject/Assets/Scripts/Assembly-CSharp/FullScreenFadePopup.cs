using System;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenFadePopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-FullScreenFade";

	private const string ANIM_IDLE = "Idle";

	private const string ANIM_FADEIN = "FadeIn";

	private const string ANIM_FADEOUT = "FadeOut";

	private AnimatorHelper m_animator;

	private bool m_doingFade;

	private Image m_image;

	private void Awake()
	{
	}

	public static FullScreenFadePopup FadeInFadeOut(Action afterFadeInCallback, Action finishedCallBack = null)
	{
		return null;
	}

	public static FullScreenFadePopup FadeIn(Action afterFadeInCallback = null)
	{
		return null;
	}

	public static FullScreenFadePopup FadeOut(Action afterFadeInCallback, bool close = true)
	{
		return null;
	}

	private void DoFadeInOut(Action afterFadeInCallback, Action finishedCallBack = null)
	{
	}

	private void DoFadeIn(Action afterFadeInCallback)
	{
	}

	private void DoFadeOut(Action afterFadeInCallback, bool close = true)
	{
	}

	public FullScreenFadePopup SetAnimationSpeed(float speed)
	{
		return null;
	}

	public FullScreenFadePopup SetColor(Color color)
	{
		return null;
	}
}
