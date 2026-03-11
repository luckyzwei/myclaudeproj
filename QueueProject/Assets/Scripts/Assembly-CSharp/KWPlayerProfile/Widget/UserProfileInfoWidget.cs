using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using KWPlayerProfile.WebImage;
using UnityEngine;
using UnityEngine.UI;

namespace KWPlayerProfile.Widget
{
	public class UserProfileInfoWidget : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConfigure_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public bool isPlayer;

			public PublicProfile userPublicProfile;

			public UserProfileInfoWidget _003C_003E4__this;

			public bool showFriendOperationButton;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[Header("Texts")]
		[SerializeField]
		private Text m_userName;

		[SerializeField]
		private Text m_className;

		[SerializeField]
		private Text m_clanName;

		[SerializeField]
		private Text m_uniqueUserId;

		[Header("Containers")]
		[SerializeField]
		private GameObject m_userNameContainer;

		[SerializeField]
		private GameObject m_classNameContainer;

		[SerializeField]
		private GameObject m_clanNameContainer;

		[SerializeField]
		private GameObject m_uniqueIdContainer;

		[Header("Button")]
		[SerializeField]
		private GameObject m_editProfile;

		[SerializeField]
		private Button m_editProfileButton;

		[Header("Widgets")]
		[SerializeField]
		private WebImageWidget m_avatarImageWidget;

		[SerializeField]
		private FriendOperationsWidget m_friendOperationsWidget;

		[AsyncStateMachine(typeof(_003CConfigure_003Ed__12))]
		public void Configure(PublicProfile userPublicProfile, bool isPlayer, bool showFriendOperationButton = true)
		{
		}

		public void Configure(string userId, string userName, string className, string clanName, string uniqueId)
		{
		}

		private void SetText(Text textComponent, string value, GameObject container)
		{
		}
	}
}
