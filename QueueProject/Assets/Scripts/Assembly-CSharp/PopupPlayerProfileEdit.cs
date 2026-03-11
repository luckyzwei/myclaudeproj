using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class PopupPlayerProfileEdit : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWPlayerProfile/Popup-PlayerProfileEdit";

	private const string PLAYER_ID_LOC_KEY = "PlayerProfile.PlayerIDDisplay";

	[SerializeField]
	protected ButtonAvatarPickContainer m_avatarButtonPrefab;

	[SerializeField]
	protected Transform m_container;

	[SerializeField]
	private EditablePlayerNameContainer m_nameInputContainer;

	[SerializeField]
	private Text m_serverIdText;

	public static void Open()
	{
	}

	private void Start()
	{
	}

	protected void UpdateUI()
	{
	}

	protected virtual void CreateProfileImages()
	{
	}

	protected void OnAvatarButtonPressed(AvatarData icon)
	{
	}

	public void OnEditNamePressed()
	{
	}

	public void OnClosePressed()
	{
	}
}
