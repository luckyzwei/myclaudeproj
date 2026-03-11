using UnityEngine;
using UnityEngine.UI;

public class ExpertModeHomeWidget : MonoBehaviour
{
	private const string EXPERT_IAP_CLIENT_ID = "expert_mode";

	private const string ANIM_GENERICBUTTON_INTRO = "GenericButton-Intro";

	private const string ANIM_GENERICBUTTON_IDLE = "GenericButton-Idle";

	private const string ANIM_GENERICBUTTON_OUTRO = "GenericButton-Outro";

	private const string ANIM_GENERICBUTTON_PRESSED = "GenericButton-Pressed";

	private const string ANIM_GENERICBUTTON_REMINDER = "GenericButton-Reminder";

	private const string ANIM_EMPTY = "Empty";

	private const string ANIM_ANIM_GENERICBUTTON_LOCKED = "Anim-GenericButton-Locked";

	[SerializeField]
	private GameObject[] m_lockedObjects;

	[SerializeField]
	private GameObject[] m_unlockedObjects;

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private Text m_levelText;

	[SerializeField]
	private Text m_headerText;

	[SerializeField]
	private Text m_lockedText;

	[SerializeField]
	private bool m_showAdOnClick;

	private AnimatorHelper m_animatorHelper;

	public int UnlockLevel => 0;

	private void Start()
	{
	}

	private void ResetButton()
	{
	}

	private void OnButtonPressed()
	{
	}

	private bool IsUnlocked()
	{
		return false;
	}

	private bool CanShow()
	{
		return false;
	}

	public static bool DoesOwn()
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
