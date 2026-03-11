using UnityEngine;
using UnityEngine.UI;

public class WidgetChallengeButton : MonoBehaviour
{
	private const float CHECK_DATA_INTERVAL = 1f;

	private const string ANIM_ANIM_CHALLENGEPLAYER_INTRO = "Anim-ChallengePlayer-Intro";

	private const string ANIM_ANIM_CHALLENGEPLAYER_LOCKED = "Anim-ChallengePlayer-Locked";

	private const string UNLOCK_AT_LEVEL_KEY = "Unlock.UnlockAfter";

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Text m_unlockAtLevelTMP;

	[SerializeField]
	private GameObject m_loading;

	private bool m_dataLoaded;

	private float m_timer;

	private void Awake()
	{
	}

	private void CheckForDataLoaded()
	{
	}

	private void OnButtonClick()
	{
	}

	private void Update()
	{
	}
}
