using System;
using UnityEngine;

namespace KWPlayerProfile.Widget
{
	public class FriendOperationsWidget : MonoBehaviour
	{
		[SerializeField]
		private GameObject m_addFriendObject;

		[SerializeField]
		private GameObject m_removeFriendObject;

		[SerializeField]
		private GameObject m_pendingFriendRequestObject;

		[SerializeField]
		private GameObject m_sentFriendRequestObject;

		[SerializeField]
		private GameObject m_blockedFriendObject;

		[Header("Optional")]
		[PrefabReferenceRequiredComponent(typeof(PopupActionConfirmation))]
		[SerializeField]
		protected PrefabReference m_popup;

		[SerializeField]
		private GameObject m_dismissButtonObject;

		[SerializeField]
		private GameObject m_dismissUserObject;

		[SerializeField]
		private string m_removeFriendLocalisationKey;

		[SerializeField]
		private string m_context;

		private string m_displayName;

		private string m_userId;

		private void Awake()
		{
		}

		public void Configure(string userId, string displayName)
		{
		}

		private void DisableAllButtons()
		{
		}

		private void UpdateButtons()
		{
		}

		public void AddFriendPressed()
		{
		}

		public void RemoveFriendPressed()
		{
		}

		public void AcceptFriendRequestPressed()
		{
		}

		public void DeclineFriendRequestPressed()
		{
		}

		public void BlockUserPressed()
		{
		}

		public void UnblockUserPressed()
		{
		}

		public void DismissUserPressed()
		{
		}

		private void OnFriendListUpdated()
		{
		}

		private void OpenConfirmationPopUp(string descriptionKey, Action confirm, Action deny)
		{
		}
	}
}
