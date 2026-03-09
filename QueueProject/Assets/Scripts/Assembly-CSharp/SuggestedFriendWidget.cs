using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Nakama;
using UnityEngine;

public class SuggestedFriendWidget : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSearchAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SuggestedFriendWidget _003C_003E4__this;

		private TaskAwaiter<List<IApiUser>> _003C_003Eu__1;

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

	[SerializeField]
	private int m_suggestedFriendCount;

	[SerializeField]
	private GameObject m_userCellContainer;

	[SerializeField]
	private UserCellWidget m_userCellWidgetPrefab;

	private List<UserCellWidget> m_userCellWidgets;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetCells()
	{
	}

	private void OnShowSuggestedFriends()
	{
	}

	[AsyncStateMachine(typeof(_003CSearchAsync_003Ed__8))]
	private void SearchAsync()
	{
	}
}
