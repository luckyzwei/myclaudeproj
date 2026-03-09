using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupDailyWinStreak : PopUpBase
{
	public enum StreakState
	{
		STILL = 0,
		ANIMATE = 1,
		BREAK = 2
	}

	public const string PREFAB_NAME = "Prefabs/Popups/Popup-WinStreak";

	private const string ANIM_ANIM_WINSTREAKPOPUP_STREAKBROKEN = "Anim-WinStreakPopup-StreakBroken";

	private const string ANIM_ANIM_WINSTREAKPOPUP_DEFAULT = "Anim-WinstreakPopup-Default";

	private const string ANIM_ANIM_WINSTREAKPOPUP_STREAKBROKEN_TRANSITION = "Anim-WinStreakPopup-StreakBroken-Transition";

	[SerializeField]
	private TextMeshProUGUI m_playerNameTMP;

	[SerializeField]
	private TextMeshProUGUI m_winStreakTMP;

	[SerializeField]
	private TextMeshProUGUI m_levelTMP;

	[SerializeField]
	private TextMeshProUGUI m_winRateTMP;

	[SerializeField]
	private TextMeshProUGUI m_maxStreakTMP;

	[SerializeField]
	private DailyWinStreakWidget dailyWinStreakWidget;

	[SerializeField]
	private DailyWinStreakBadge[] m_winStreakBadges;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Button m_closeButton;

	[SerializeField]
	private Button m_backgroundCloseButton;

	public void Configure(StreakState streakState = StreakState.STILL)
	{
	}

	private void OnStreakBrokenAnimationDone()
	{
	}

	public void OnPlaySFXAnimEvent()
	{
	}

	public void ClosePopupWithInterstitial()
	{
	}
}
