using UnityEngine;

public class HeartWidget : MonoBehaviour
{
	private const string ANIM_IN = "In";

	private const string ANIM_OFF = "Off";

	private const string ANIM_ON = "On";

	private const string ANIM_LOST = "Lost";

	private const string ANIM_WHITE_ON = "White-On";

	private const string ANIM_DARK_ON = "Dark-On";

	private const string ANIM_DARK_OFF = "Dark-Off";

	private const string ANIM_WHITE_OFF = "White-Off";

	private AnimatorHelper m_animatorHelper;

	private void Awake()
	{
		m_animatorHelper = GetComponent<AnimatorHelper>();
	}

	public void LifeLost()
	{
		if (m_animatorHelper != null)
			m_animatorHelper.Play(ANIM_LOST);
	}

	public void Intro()
	{
		if (m_animatorHelper != null)
			m_animatorHelper.Play(ANIM_IN);
	}
}
