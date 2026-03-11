using UnityEngine;
using UnityEngine.UI;

public class RoyalTournamentAvatarWidget : MonoBehaviour
{
	private const string ANIM_AVATARIDLE = "AvatarIdle";

	private const string ANIM_AVATARINTRO = "AvatarIntro";

	private const float AUDIO_DELAY = 0.1f;

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private AnimatorHelper m_animator;

	[SerializeField]
	private Text m_playerNameText;

	private static float s_audioTimestamp;

	private static float s_pitchCounter;

	public void Setup(LeaderboardData.User user)
	{
	}

	public void PlayIntroAnimation()
	{
	}

	public static void ResetAudio()
	{
	}

	private void PlayAudio()
	{
	}
}
