using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AvatarContainer : MonoBehaviour
{
	[SerializeField]
	private Image m_image;

	private void ValidateAvatarImageReference()
	{
	}

	private void SetProfilePicture(Sprite sprite)
	{
	}

	public void UpdateAvatar(AvatarData avatarData)
	{
	}

	public void UpdateAvatar(Sprite sprite)
	{
	}

	public void UpdateAvatar(string avatarUrl)
	{
	}

	public void UpdateAvatarAsPlayerAvatar()
	{
	}

	public void UpdateAvatarWithPlayerId()
	{
	}

	public void UpdateAvatarByIndex(int index)
	{
	}

	public void UpdateAvatarByRandomIndex()
	{
	}

	public void UpdateAvatarByDefaultAvatar()
	{
	}
}
