using KWUserInterface;
using UnityEngine;

public class GameOverScreen : KWUserInterface.Screen
{
	private const string ANIM_ANIM_LEVELFAILEDOVERLAY_IN = "Anim-LevelFailedOverlay-In";

	private const string ANIM_ANIM_LEVELFAILEDOVERLAY_OUT = "Anim-LevelFailedOverlay-Out";

	private const float WAIT_TIME_FOR_LEVEL_LOAD = 0.1f;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private GameOverPopUp m_gameOverPopUp;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private GameObject m_timePaused;

	private void Awake()
	{
	}

	public void RetryLevel()
	{
	}

	private void GoToNextScreen()
	{
	}

	private void FadeOut()
	{
	}
}
