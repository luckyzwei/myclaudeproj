using UnityEngine;
using UnityEngine.UI;

public class AvatarUpdater : MonoBehaviour
{
	[SerializeField]
	private Image m_avatarImage;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameplayEvents_AvatarChanged(Sprite sprite)
	{
	}
}
