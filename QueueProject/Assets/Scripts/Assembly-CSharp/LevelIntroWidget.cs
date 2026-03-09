using System.Runtime.CompilerServices;
using Balancy.Models;
using UnityEngine;
using UnityEngine.UI;

public class LevelIntroWidget : MonoBehaviour
{
	private const string ANIM_ANIM_TIMEDLEVELINTRO_TRANSITIONTOGAME = "Anim-TimedLevelIntro-TransitionToGame";

	[SerializeField]
	private TimeStarsRowWidget[] m_rowWidgets;

	[SerializeField]
	private TimeStarsRowWidget m_rowWidgetPrefab;

	[SerializeField]
	private Transform m_rowWidgetsParent;

	[Space]
	[SerializeField]
	private Button m_rvButton;

	[SerializeField]
	private Button m_noThanksButton;

	[SerializeField]
	private GameObject m_rvIcon;

	[Space]
	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private GameObject m_starsInfoGameObject;

	[SerializeField]
	private GameObject m_autoXActivated;

	private LevelDifficulty m_levelDifficulty;

	private bool m_isDailyChallenge;

	private bool m_hasTime;

	private bool m_hasButton;

	private bool m_isFree;

	public event GameplayEvents.BasicDelegate OnClose
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GameplayEvents.BasicDelegate OnFade
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void AutoClose()
	{
	}

	private bool ConfigTimeRows()
	{
		return false;
	}

	private void SetupTimeAndStars(LevelTimeStep[] data)
	{
	}

	private bool ConfigRVButton(bool isTimed)
	{
		return false;
	}

	private void ShowNoThanks()
	{
	}

	private bool HasAutoX()
	{
		return false;
	}

	private bool ShouldOfferAutoX()
	{
		return false;
	}

	private bool HasFreeAutoXLeft()
	{
		return false;
	}

	private void OnRvButtonClicked()
	{
	}

	private void UnlockAutoX()
	{
	}

	private void OnNoThanksClicked()
	{
	}

	private void ClosePopup()
	{
	}

	private void PlayRowsSFX()
	{
	}

	public void FadeAway()
	{
	}
}
