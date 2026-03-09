using KWHaptics.Haptics;
using UnityEngine;

public class SpinWheelPointer : MonoBehaviour
{
	private const float FULL_ROTATION = 360f;

	private const string ANIM_SPINTICK = "SpinTick";

	private const string ANIM_IDLETICK = "IdleTick";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private SpinWheelSpinner m_spinWheelSpinner;

	[SerializeField]
	private float m_tickBeforeAnglePercent;

	[SerializeField]
	private bool m_playIdleTick;

	private HapticsTickerComponent m_hapticsTickerComponent;

	private int m_lastSegmentCrossed;

	private int m_segments;

	private float m_lastHapticTimeMS;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
