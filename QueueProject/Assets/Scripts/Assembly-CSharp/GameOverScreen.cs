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
		if (m_canvasGroup == null)
			m_canvasGroup = GetComponent<CanvasGroup>();
	}

	public void RetryLevel()
	{
		FadeOut();
		if (GameManager.Instance != null)
			GameManager.Instance.Restart();
	}

	private void GoToNextScreen()
	{
		FadeOut();
		if (GameManager.Instance != null)
			GameManager.Instance.ReturnToHomeScreen();
	}

	private void FadeOut()
	{
		if (m_canvasGroup != null)
		{
			m_canvasGroup.alpha = 0f;
			m_canvasGroup.interactable = false;
			m_canvasGroup.blocksRaycasts = false;
		}
	}
}
