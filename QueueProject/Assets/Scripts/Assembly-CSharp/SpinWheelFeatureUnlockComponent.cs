using System;
using UnityEngine;

public class SpinWheelFeatureUnlockComponent : FeatureUnlockComponent
{
	private const string ANIM_ANIM_SPINWHEEL_UNLOCK = "Anim-SpinWheel-Unlock";

	private const string ANIM_ANIM_SPINWHEEL_LOOP = "Anim-SpinWheel-Loop";

	private const string ANIM_ANIM_SPINWHEEL_DEFAULT = "Anim-SpinWheel-Default";

	private const string ANIM_ANIM_WIDGETHOME_FTUE_INTRO = "Anim-WidgetHome-Ftue-Intro";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private AnimatorHelper m_widgetAnimatorHelper;

	private void Start()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	protected override int UnlockLevel()
	{
		return 0;
	}

	protected override bool IsFeatureUnlocked()
	{
		return false;
	}

	protected override void SetFeatureUnlocked()
	{
	}

	public override void ShowFeatureUnlockPopup(Action onFeatureUnlockComplete)
	{
	}
}
