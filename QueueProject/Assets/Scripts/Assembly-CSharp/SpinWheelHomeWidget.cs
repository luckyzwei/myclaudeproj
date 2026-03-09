using TMPro;
using UnityEngine;

public class SpinWheelHomeWidget : MonoBehaviour
{
	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	private const string ANIM_ANIM_WIDGETHOME_INACTIVE = "Anim-WidgetHome-Inactive";

	private const string ANIM_ANIM_WIDGETHOME_IDLE = "Anim-WidgetHome-Idle";

	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedGameobjects;

	[Header("Lock Text")]
	[SerializeField]
	private TextMeshProUGUI m_lockText;

	[SerializeField]
	private string m_lockPrefixKey;

	[SerializeField]
	private int m_unlockLevelOffset;

	[Space(5f)]
	[SerializeField]
	private GameObject m_startingSpinGroup;

	[Space(5f)]
	[SerializeField]
	private GameObject m_rvIcon;

	[SerializeField]
	private NextSpinTimerWidget m_nextSpinTimerWidget;

	private AnimatorHelper m_animatorHelper;

	private bool m_firstOpen;

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

	public void SetupWidget()
	{
	}

	private void SetupTimerWidget()
	{
	}

	public void SpinWheelWidgetButtonPressed()
	{
	}

	private static void ToggleGameObject(GameObject[] gameObjects, bool toggle)
	{
	}
}
