using Balancy.Models;
using UnityEngine.UI;
using UnityEngine;

public class LevelTimerWidget : MonoBehaviour
{
	private const string ANIM_ANIM_LEVELTIMER_TIMERFLASH = "Anim-LevelTimer-TimerFlash";

	private const string ANIM_ANIM_LEVELTIMER_REWARDCHANGE = "Anim-LevelTimer-RewardChange";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Animator m_clockAnimator;

	[SerializeField]
	private Text m_timerText;

	[SerializeField]
	private Text m_starsText;

	[SerializeField]
	private Text m_starsAltText;

	[SerializeField]
	private bool m_staticTime;

	private LevelTimeStep[] m_data;

	private LevelDifficulty m_currentLevelDifficulty;

	private bool m_isDailyChallenge;

	private int m_index;

	private float m_currentTime;

	private int m_currentStars;

	private int m_nextStars;

	private bool m_lastOne;

	private bool m_isWarning;

	private float m_lastElapsedTime;

	protected void Awake()
	{
	}

	private void SetClockAnimatorEnabled(bool active)
	{
	}

	private void Config(LevelTimeStep[] data)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelSolved()
	{
	}

	private void StopWarning()
	{
	}

	private void SetTimerAndReward(int index)
	{
	}

	private void SetStarsTexts()
	{
	}

	private void Update()
	{
	}

	private void SetTimeText()
	{
	}

	public int GetStars()
	{
		return 0;
	}
}
