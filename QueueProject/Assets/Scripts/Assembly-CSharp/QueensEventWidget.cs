using Balancy.Models.SmartObjects;
using UnityEngine.UI;
using UnityEngine;

public class QueensEventWidget : MonoBehaviour
{
	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	private const string ANIM_ANIM_WIDGETHOME_INACTIVE = "Anim-WidgetHome-Inactive";

	private const string ANIM_ANIM_WIDGETHOME_IDLE = "Anim-WidgetHome-Idle";

	private const string ANIM_ANIM_CHALLENGEUNLOCK_LOCKED = "Anim-ChallengeUnlock-Locked";

	private const string ANIM_ANIM_WIDGETHOME_ACTIVE = "Anim-WidgetHome-Active";

	private const string ANIM_ANIM_WIDGETHOME_FTUE_INTRO = "Anim-WidgetHome-Ftue-Intro";

	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedNotActiveGameobjects;

	[SerializeField]
	private GameObject[] m_activeGameObjects;

	[SerializeField]
	private Text m_lockText;

	[SerializeField]
	private string m_lockTextFormatKey;

	[SerializeField]
	private GameObject m_timerEndsIn;

	[SerializeField]
	private GameObject m_gemCounter;

	[SerializeField]
	private string m_location;

	private GameEvent m_queenEvent;

	private AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetAnimatorLockedState()
	{
	}

	private void OnEnable()
	{
	}

	private int TimeLeft()
	{
		return 0;
	}

	private void Update()
	{
	}

	public void QueensEventOpenButton()
	{
	}

	private bool IsUnlocked()
	{
		return false;
	}

	private void ShowQueenEventNotActiveYetPopup()
	{
	}

	private void ShowQueenEventProgression()
	{
	}

	private static void ToggleGameObject(GameObject[] gameObjects, bool toggle)
	{
	}
}
