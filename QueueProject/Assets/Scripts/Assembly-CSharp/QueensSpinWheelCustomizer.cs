using System;
using Balancy.Models.KWSpinWheel;
using UnityEngine;

public class QueensSpinWheelCustomizer : MonoBehaviour, ISpinWheelCustomizer
{
	private const string ANIM_ANIM_SPINWHEELINTRO = "Anim-SpinwheelIntro";

	private const string ANIM_ANIM_SPINWHEELIDLE = "Anim-SpinwheelIdle";

	private const string ANIM_ANIM_SPINWHEELOUTRO = "Anim-SpinwheelOutro";

	[SerializeField]
	private Sprite[] m_permiumSegmentSprites;

	[SerializeField]
	private GameObject[] m_premiumObjects;

	[SerializeField]
	private GameObject[] m_nonPremiumObjects;

	[Header("Timing")]
	[Header("Animate In")]
	[SerializeField]
	private float m_segmentAnimateInInitialDelay;

	[SerializeField]
	private AnimationCurve m_segmentAnimateInCurve;

	[SerializeField]
	private float m_segmentAnimateInDuration;

	[SerializeField]
	private AnimationCurve m_segmentCascadeInCurve;

	[SerializeField]
	private float m_segmentCascadeInDuration;

	[Header("Animate Out")]
	[SerializeField]
	private AnimationCurve m_segmentAnimateOutCurve;

	[SerializeField]
	private float m_segmentAnimateOutDuration;

	[SerializeField]
	private AnimationCurve m_segmentCascadeOutCurve;

	[SerializeField]
	private float m_segmentCascadeOutDuration;

	private AnimatorHelper m_animatorHelper;

	private SpinWheelSegmentsController m_segmentsController;

	private void Awake()
	{
	}

	public void Customize()
	{
	}

	public void AnimateIn(Action callback)
	{
	}

	public void AnimateOut(Action callback)
	{
	}

	public SpinWheelRewards GetCurrentReward()
	{
		return null;
	}

	private bool IsPremium()
	{
		return false;
	}
}
