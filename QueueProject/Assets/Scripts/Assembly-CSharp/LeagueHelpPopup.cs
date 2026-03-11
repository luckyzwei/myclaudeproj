using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class LeagueHelpPopup : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWLeaderboard/PopUp-LeagueHelp";

	private const string DEMOTION_TEXT_KEY = "Leaderboard.HelperText4";

	private const string PROMOTION_TEXT_KEY = "Leaderboard.HelperText3";

	private const string PROMOTION_LAST_LEAGUE_TEXT_KEY = "Leaderboard.HelperText3Alt";

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Text m_leaguePromotionText;

	[SerializeField]
	private Text m_leagueDemotionText;

	protected void Start()
	{
	}

	public void OnContinuePressed()
	{
	}
}
