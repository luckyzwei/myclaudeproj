using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using KWCore.UI;
using KWPlayerProfile.Widget;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace KWPlayerProfile.Popup
{
	public class PopupProfileView : PopUpBase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConfigure_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PopupProfileView _003C_003E4__this;

			public string userId;

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

		private const string PREFAB_NAME = "Prefabs/KWPlayerProfile/Popup-ProfileView";

		[SerializeField]
		private Button m_closeButton;

		[SerializeField]
		private UserProfileInfoWidget m_userProfileInfoWidget;

		[SerializeField]
		private UnityEvent<PublicProfile, bool> m_onProfileViewConfigured;

		[SerializeField]
		private List<GameObject> m_enableWhileLoading;

		[SerializeField]
		private List<GameObject> m_disableWhileLoading;

		private bool m_friendOperationEnabled;

		private string m_userId;

		public static PopupProfileView Open()
		{
			return null;
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CConfigure_003Ed__11))]
		public void Configure(string userId)
		{
		}

		private void ToggleLoadingView(bool enable)
		{
		}

		public void SetFriendOperationEnabled(bool friendOperationEnabled)
		{
		}

		private void OnPlayerProfileChanged(PublicProfile profile)
		{
		}
	}
}
