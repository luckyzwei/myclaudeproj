using Balancy.Models.KWSpinWheel;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SpinWheelSegment : MonoBehaviour
{
	private const string ANIM_ANIM_SPINWHEELSEGMENT_IDLE = "Anim-SpinWheelSegment-Idle";

	private const string ANIM_ANIM_SPINWHEELSEGMENT_FLASH = "Anim-SpinWheelSegment-Flash";

	private static readonly string TINT_PROPERTY;

	[SerializeField]
	private Image m_fillImage;

	[SerializeField]
	private RectTransform m_rectTransform;

	[SerializeField]
	private RectTransform m_segmentArc;

	[SerializeField]
	private RectTransform m_rewardGroupRect;

	[SerializeField]
	protected Text m_rewardText;

	[SerializeField]
	protected Image m_rewardSprite;

	[SerializeField]
	private Image m_segmentSprite;

	[SerializeField]
	protected string m_rewardPrefix;

	[Header("Flash")]
	[SerializeField]
	private float m_maxIntensity;

	[SerializeField]
	private float m_duration;

	private Tween m_flashTween;

	private Color m_baseColor;

	private AnimatorHelper m_animatorHelper;

	private Material m_segmentMaterial;

	public void SetupSegment(float halfSegmentAngle, float rotationZ, float fillAmount, Sprite segmentSprite, SpinWheelRewardData spinWheelRewardData, float segmentRewardGroupScale)
	{
	}

	public void SwapSprite(Sprite segmentSprite)
	{
	}

	protected virtual void SetReward(SpinWheelRewardData rewardData)
	{
	}

	public void PlayIdle()
	{
	}

	public void PlayFlash()
	{
	}
}
