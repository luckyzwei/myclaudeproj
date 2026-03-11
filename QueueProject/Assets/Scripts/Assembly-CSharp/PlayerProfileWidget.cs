using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class PlayerProfileWidget : MonoBehaviour
{
	[Header("All params are optional")]
	[SerializeField]
	private EditablePlayerNameContainer m_editablePlayerNameContainer;

	[SerializeField]
	private Text m_PlayerNameText;

	[SerializeField]
	private AvatarContainer m_avatarContainer;

	private string m_userID;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnPlayerProfileChanged(PublicProfile profile)
	{
	}

	private void UpdateUI(PublicProfile profile)
	{
	}

	public void OnProfilePressed()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}
}
