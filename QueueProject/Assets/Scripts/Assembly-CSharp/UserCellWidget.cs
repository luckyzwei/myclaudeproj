using KWPlayerProfile.WebImage;
using KWPlayerProfile.Widget;
using Nakama;
using TMPro;
using UI.Widgets.Buttons;
using UnityEngine;
using UnityEngine.Events;

public class UserCellWidget : MonoBehaviour
{
	[Header("Texts")]
	[SerializeField]
	protected TMP_Text m_userName;

	[SerializeField]
	protected TMP_Text m_className;

	[SerializeField]
	protected TMP_Text m_clanName;

	[Header("Widgets")]
	[SerializeField]
	protected WebImageWidget m_avatarWebImage;

	[SerializeField]
	protected ButtonViewProfile m_buttonViewProfile;

	[Header("Optional")]
	[SerializeField]
	protected FriendOperationsWidget m_friendOps;

	[SerializeField]
	protected UnityEvent<IApiUser> m_onUserConfigured;

	public virtual void Configure(IApiUser apiUser)
	{
	}

	protected virtual void SetupUI(string userName, string className = "", string clanName = "")
	{
	}

	private void SetupFriendOpsButton(IApiUser apiUser)
	{
	}
}
