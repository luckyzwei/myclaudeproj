using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyWinStreakPip : MonoBehaviour
{
	public enum StreakPipState
	{
		DEFAULT = 0,
		COMPLETE = 1,
		FAILED = 2,
		SHIELD = 3
	}

	private const string ANIM_WINSTREAK_DAY_DEFAULT = "WinStreak-Day-Default";

	private const string ANIM_WINSTREAK_DAY_FAILED = "WinStreak-Day-Failed";

	private const string ANIM_WINSTREAK_DAY_CURRENT = "WinStreak-Day-Current";

	private const string ANIM_WINSTREAK_DAY_COMPLETE = "WinStreak-Day-Complete";

	private const string ANIM_WINSTREAK_DAY_COMPLETE_TRANSITION = "WinStreak-Day-Complete-Transition";

	private const string ANIM_WINSTREAK_DAY_SHIELD_INTRO = "WinStreak-Day-Shield-Intro";

	private const string ANIM_WINSTREAK_DAY_SHIELD = "WinStreak-Day-Shield";

	[SerializeField]
	private Text m_dayTMP;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Image m_fillImage;

	[SerializeField]
	private Transform m_fillCap;

	private Action m_callback;

	private StreakPipState m_streakPipState;

	public StreakPipState StreakPipCurrentState => default(StreakPipState);

	public void Configure(string day, StreakPipState completed, bool today, PopupDailyWinStreak.StreakState streakState, bool showProgress, Action callback = null)
	{
	}

	public void PlayProgressAnimation(bool showProgress)
	{
	}

	private void CompletePip()
	{
	}

	public void FillProgressBar(Action callback = null)
	{
	}

	public void DepleteProgressBar(Action callback = null)
	{
	}

	public void PlayShieldAnimation()
	{
	}

	private void UpdateFillCapPosition()
	{
	}
}
