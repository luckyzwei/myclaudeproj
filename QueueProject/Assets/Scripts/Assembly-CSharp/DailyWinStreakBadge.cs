using UnityEngine.UI;
using UnityEngine;

public class DailyWinStreakBadge : MonoBehaviour
{
	private const string DAYS_KEY = "DailyWinStreak.MilestoneDays";

	private const string ANIM_ANIM_ACHIEVEMENTBADGE_DEFAULT = "Anim-AchievementBadge-Default";

	private const string ANIM_ANIM_ACHIEVEMENTBADGE_UNLOCKED = "Anim-AchievementBadge-Unlocked";

	private const string ANIM_ANIM_ACHIEVEMENTBADGE_TRANSITION = "Anim-AchievementBadge-Transition";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Text m_milestoneTMP;

	public void Configure(int milestone)
	{
	}
}
