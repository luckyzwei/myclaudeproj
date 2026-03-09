using System;
using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LeaguePromotionPopup : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/KWLeaderboard/PopUp-Leagues-Promotion";

	private const string ANIM_PROMOTION = "Promotion";

	private const string ANIM_DEMOTION = "Demotion";

	private const string ANIM_PROMOTION_OUTRO = "Promotion-Outro";

	private const string ANIM_DEMOTION_OUTRO = "Demotion-Outro";

	[SerializeField]
	private Image m_nextLeagueIcon;

	[SerializeField]
	private TextMeshProUGUI m_nextLeagueName;

	[SerializeField]
	private TextMeshProUGUI m_titleText;

	[SerializeField]
	private UnityEngine.UI.Extensions.Gradient m_headerGradient;

	private LeagueManager.LeagueResult m_leagueResult;

	private Action m_callback;

	private bool m_animFinished;

	private AnimatorHelper m_animationHelper;

	private void Awake()
	{
	}

	public static void Show(int leagueIndex, LeagueManager.LeagueResult result, Action callback = null)
	{
	}

	private void Initialize(int leagueIndex, LeagueManager.LeagueResult result, Action callback)
	{
	}

	public void OnContinueButtonPressed()
	{
	}

	private void FinishedAnimation()
	{
	}
}
