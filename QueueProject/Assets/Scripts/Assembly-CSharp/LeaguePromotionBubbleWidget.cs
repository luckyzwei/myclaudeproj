using UnityEngine;

public class LeaguePromotionBubbleWidget : MonoBehaviour
{
	private const float WAIT_TIME = 5f;

	private const string DEMOTION_TEXT_KEY = "Leaderboard.DemotionBubble";

	private const string PROMOTION_TEXT_KEY = "Leaderboard.PromotionBubble";

	private const string NEUTRAL_TEXT_KEY = "Leaderboard.NeutralBubble";

	private const string PROMOTION_TEXT_TOP_LEAGUE_KEY = "Leaderboard.PromotionBubbleTopLeague";

	private const string NEUTRAL_TEXT_TOP_LEAGUE_KEY = "Leaderboard.NeutralBubbleTopLeague";

	private const string ANIM_PROMOTION_INTRO = "Promotion-Intro";

	private const string ANIM_PROMOTION_OUTRO = "Promotion-Outro";

	private const string ANIM_DEMOTION_INTRO = "Demotion-Intro";

	private const string ANIM_DEMOTION_OUTRO = "Demotion-Outro";

	private const string ANIM_NEUTRAL_OUTRO = "Neutral-Outro";

	private const string ANIM_NEUTRAL_INTRO = "Neutral-Intro";

	private AnimatorHelper m_animator;

	private bool m_started;

	private LeagueManager.LeagueResult m_result;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void PlayAnimation(LeagueManager.LeagueResult result)
	{
	}

	private void Setup(string text, int textValue, string intro, string outro)
	{
	}
}
