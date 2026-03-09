using UnityEngine;
using UnityEngine.UI;

public class ButtonRVReward : MonoBehaviour
{
	[SerializeField]
	protected LevelCompleteScreen m_levelCompleteScreen;

	[SerializeField]
	protected AnimatorHelper m_animator;

	[SerializeField]
	protected Button m_button;

	[SerializeField]
	protected GameObject m_rvApplied;

	private const string ANIM_GENERICBUTTON_INTRO = "GenericButton-Intro";

	private const string ANIM_GENERICBUTTON_IDLE = "GenericButton-Idle";

	private const string ANIM_GENERICBUTTON_OUTRO = "GenericButton-Outro";

	private const string ANIM_GENERICBUTTON_PRESSED = "GenericButton-Pressed";

	private const string ANIM_GENERICBUTTON_REMINDER = "GenericButton-Reminder";

	private const string ANIM_EMPTY = "Empty";

	public void OnDoubleRewardAddButtonPressed()
	{
	}

	private void OnRvSuccess()
	{
	}

	public void OnRvFail()
	{
	}
}
