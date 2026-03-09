using System;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class DailyWinStreakHomeButton : MonoBehaviour
{
	private const string WIN_STREAK_NOTIFICATION = "win_streak";

	private const string LOCKED_LEVEL_KEY = "SpinWheel.UnlockAt";

	private const string ANIM_ANIM_CHALLENGEUNLOCK_LOCKED = "Anim-ChallengeUnlock-Locked";

	private const string ANIM_ANIM_STREAKFLAME = "Anim-StreakFlame";

	private const string ANIM_ANIM_FLAME_STATIC = "Anim-Flame-Static";

	private const string ANIM_ANIM_FLAME_NOSTREAK = "Anim-Flame-NoStreak";

	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	private const string ANIM_ANIM_WIDGETHOME_ACTIVE = "Anim-WidgetHome-Active";

	[Header("UI Refs")]
	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private TextMeshProUGUI m_lockedLevelTMP;

	private Action m_finishCallback;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	private void OnButtonPressed()
	{
	}
}
