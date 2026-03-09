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

	public void Config(QueensGridCell cell)
	{
	}

	private void Update()
	{
	}
}
