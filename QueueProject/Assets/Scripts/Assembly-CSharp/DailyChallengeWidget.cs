using TMPro;
using UnityEngine;

public class DailyChallengeWidget : MonoBehaviour
{
	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	private const string ANIM_ANIM_WIDGETHOME_INACTIVE = "Anim-WidgetHome-Inactive";

	private const string ANIM_ANIM_WIDGETHOME_IDLE = "Anim-WidgetHome-Idle";

	[SerializeField]
	private string m_dailyChallengeID;

	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedGameobjects;

	[Header("Lock Text")]
	[SerializeField]
	private TextMeshProUGUI m_lockText;

	private bool m_canOpenDailyChallenge;

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

	private void SetupOpenButton()
	{
	}

	private void TryShowNotification()
	{
	}

	public void DailyChallengeOpenButton()
	{
	}

	private static void ToggleGameObject(GameObject[] gameObjects, bool toggle)
	{
	}
}
