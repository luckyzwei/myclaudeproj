using System;
using TMPro;
using UnityEngine;

public class DailyWinStreakLevelCompleteWidget : MonoBehaviour
{
	private const float DELAY_ANIMATION_OUTRO = 1.5f;

	private const float DELAY_ANIMATION_TRANSITION = 1.5f;

	private const float DELAY_UPDATE_WIN_STREAK = 0.5f;

	private const string ANIM_ANIM_LEVELCOMPLETE_STREAKINTRO = "Anim-LevelComplete-StreakIntro";

	private const string ANIM_ANIM_LEVELCOMPLETE_STREAKOUTRO = "Anim-LevelComplete-StreakOutro";

	private const string ANIM_ANIM_WINSTREAK_TRANSITION = "Anim-Winstreak-Transition";

	[SerializeField]
	private AnimatorHelper m_winStreakContainerAnimatorHelper;

	[SerializeField]
	private DailyWinStreakWidget dailyWinStreakWidget;

	[SerializeField]
	private TextMeshProUGUI m_streakDaysTMP;

	private Action m_finishCallback;

	public void StartFlow(Action finishCallback = null)
	{
	}

	private void OnIntroAnimationDone()
	{
	}

	private void PlayTransition()
	{
	}

	private void TransitionFlow()
	{
	}

	private void PlayOutroAnimation()
	{
	}
}
