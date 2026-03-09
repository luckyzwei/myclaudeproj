using System.Collections.Generic;
using UnityEngine;

public class FriendListWidget : MonoBehaviour
{
	[Header("Containers")]
	[SerializeField]
	protected GameObject m_pendingRequestsContainer;

	[SerializeField]
	protected GameObject m_currentFriendsContainer;

	[SerializeField]
	protected GameObject m_nothingToShowContainer;

	[Header("Prefabs")]
	[SerializeField]
	protected UserCellWidget m_pendingReqCellWidgetPrefab;

	[SerializeField]
	protected UserCellWidget m_userCellWidgetPrefab;

	[Header("Optional Parameters")]
	[Tooltip("Enabling this will send an RPC for refreshing friend list")]
	[SerializeField]
	protected bool m_syncFriendsOnStart;

	[SerializeField]
	protected GameObject m_pendingRequestsText;

	[SerializeField]
	protected GameObject m_currentFriendText;

	[SerializeField]
	protected List<NakamaFriends.FriendState> m_overrideFriendStates;

	[SerializeField]
	protected List<NakamaFriends.FriendState> m_overridePendingStates;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnFriendListUpdated()
	{
	}

	private void OnCachedUsersUpdated(List<string> updatedCachedUserIds)
	{
	}

	private void RefreshContainers()
	{
	}

	private void UpdateFriendContainers()
	{
	}

	protected virtual void FillFriendContainer(List<Friend> friends)
	{
	}

	protected virtual void FillPendingContainer(List<Friend> pendingRequests)
	{
	}

	private void ClearFriendContainers()
	{
	}

	public virtual void FillContainer(List<Friend> userList, UserCellWidget cellPrefab, GameObject textObject, GameObject containerObject, string emptyMessage)
	{
	}
}
