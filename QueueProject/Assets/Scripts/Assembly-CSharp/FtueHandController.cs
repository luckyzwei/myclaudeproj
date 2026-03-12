using Balancy.Models;
using UnityEngine;

public class FtueHandController : MonoBehaviour
{
	private const string ANIM_ANIM_FTUE_HAND_TAP = "Anim-FTUE-Hand-Tap";

	private const string ANIM_ANIM_FTUE_HAND_DOUBLETAP = "Anim-FTUE-Hand-DoubleTap";

	private const string ANIM_ANIM_FTUE_HAND_HOLD = "Anim-FTUE-Hand-Hold";

	[SerializeField]
	private GameObject m_hand;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	private ControlSchemes m_scheme;

	private bool m_checkForSchemeC;

	private QueensControlSchemeC m_schemeC;

	public void Hide()
	{
		UnityEngine.Debug.Log($"[FtueHandController] Hide() called - m_hand={(m_hand != null ? m_hand.name + " active=" + m_hand.activeSelf : "NULL")}, caller={new System.Diagnostics.StackTrace().GetFrame(1)?.GetMethod()?.DeclaringType?.Name}");

		// 先停止 Animator，防止动画曲线覆盖 SetActive
		if (m_animatorHelper != null)
			m_animatorHelper.StopAnimator();

		if (m_hand != null)
			m_hand.SetActive(false);
	}

	public void Config(QueensGridCell cell)
	{
		UnityEngine.Debug.Log($"[FtueHandController] Config() called - cell={(cell != null ? cell.name + " pos=" + cell.transform.position : "NULL")}");

		if (m_hand != null)
		{
			m_hand.SetActive(true);
			m_hand.transform.position = cell.transform.position;
		}

		// Play appropriate animation based on control scheme
		if (m_animatorHelper != null)
		{
			// 确保 Animator 启用
			var animator = m_animatorHelper.GetAnimator();
			if (animator != null)
				animator.enabled = true;

			switch (m_scheme)
			{
				case ControlSchemes.Scheme_B:
					m_animatorHelper.SetTrigger(ANIM_ANIM_FTUE_HAND_DOUBLETAP);
					break;
				case ControlSchemes.Scheme_C:
					m_animatorHelper.SetTrigger(ANIM_ANIM_FTUE_HAND_HOLD);
					break;
				default:
					m_animatorHelper.SetTrigger(ANIM_ANIM_FTUE_HAND_TAP);
					break;
			}
		}
	}

	private void Update()
	{
		// Check for scheme C hold cancellation
		if (m_checkForSchemeC && m_schemeC != null)
		{
			// Scheme C specific update logic
		}
	}
}
