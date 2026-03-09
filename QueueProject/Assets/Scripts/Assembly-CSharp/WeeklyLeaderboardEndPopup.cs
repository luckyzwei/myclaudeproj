using System;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class WeeklyLeaderboardEndPopup : PopUpBase
{
	private const string POPUP_NAME = "Prefabs/KWLeaderboard/Popup-WeeklyLeaderboard-End";

	private const string ANIM_WEEKLYLEADERBOARDEND_TOPMEDALS_INTRO = "WeeklyLeaderboardEnd-TopMedals-Intro";

	private const string ANIM_WEEKLYLEADERBOARDEND_OUTRO = "WeeklyLeaderboardEnd-Outro";

	private const string ANIM_WEEKLYLEADERBOARDEND_NOMEDALS_INTRO = "WeeklyLeaderboardEnd-NoMedals-Intro";

	private const string ANIM_WEEKLYLEADERBOARDEND_MIDMEDALS_INTRO = "WeeklyLeaderboardEnd-MidMedals-Intro";

	[SerializeField]
	private TextMeshProUGUI m_textPosition;

	[SerializeField]
	private TextMeshProUGUI m_textButton;

	[SerializeField]
	private TextMeshProUGUI m_textScore;

	[SerializeField]
	private TextMeshProUGUI m_textYourAreCool;

	[SerializeField]
	private GameObject m_rewardContainer;

	[SerializeField]
	private GameObject[] m_rewardIcons;

	[SerializeField]
	private ParticleSystem m_fillParticles;

	[SerializeField]
	private Color[] m_fillColors;

	private QueensLeaderboardManager.WeeklyRewardData m_rewardData;

	private GameObject m_rewardIcon;

	private Action m_customFinishCallback;

	private new AnimatorHelper m_animatorHelper;

	public static void Show(QueensLeaderboardManager.WeeklyRewardData reward, Action finishCallback, Action popupClosed)
	{
	}

	private void Config(QueensLeaderboardManager.WeeklyRewardData reward, Action finishCallback)
	{
	}

	public void OnContinuePressed()
	{
	}
}
