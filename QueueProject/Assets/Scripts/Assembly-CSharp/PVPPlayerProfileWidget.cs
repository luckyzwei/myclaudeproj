using UnityEngine;
using UnityEngine.UI;

public class PVPPlayerProfileWidget : MonoBehaviour
{
	[SerializeField]
	private Text m_PlayerNameText;

	[SerializeField]
	private AvatarContainer m_avatarContainer;

	[SerializeField]
	private bool m_autoSetOpponentProfile;

	[SerializeField]
	private Image m_badgeIcon;

	private void Start()
	{
	}

	public void Config(LeaderboardData.User userOponnent)
	{
	}
}
