using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using KWCore.Utils;
using Nakama;

public class NakamaFriends : Singleton<NakamaFriends>
{
	public enum FriendState
	{
		FRIENDS = 0,
		REQUEST_SENT = 1,
		REQUEST_PENDING = 2,
		BLOCKED = 3,
		NOT_A_FRIEND = 4
	}

	public enum FriendOperation
	{
		ADD = 0,
		REMOVE = 1,
		BLOCK = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAcceptFriendRequestAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddFriendAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddFriendsAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string[] userIds;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CBlockFriendAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CBlockFriendsAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string[] userIds;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDeclineFriendRequestAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoFriendOperationAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] userIds;

		public Action onFail;

		public FriendOperation operation;

		public FriendActionEvent.Action friendAction;

		public NakamaFriends _003C_003E4__this;

		public string locationContext;

		public Action onSuccess;

		private Action _003CeventToInvokeOnComplete_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRemoveFriendAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRemoveFriendsAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string[] userIds;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSyncFriendListAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public Action onSuccess;

		public Action onFail;

		private TaskAwaiter<IApiFriendList> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTrySendFriendActionAnalytics_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] userIds;

		public FriendActionEvent.Action friendAction;

		public string locationContext;

		private TaskAwaiter<IApiUser> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CUnblockFriendAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaFriends _003C_003E4__this;

		public string userId;

		public Action onSuccess;

		public Action onFail;

		public string locationContext;

		private TaskAwaiter _003C_003Eu__1;

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

	private Dictionary<FriendState, List<Friend>> m_friendsDictionary;

	private int m_friendRpcRequestLimit;

	public static event Action FriendListUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action FriendAdded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action FriendRemoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action FriendBlocked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[AsyncStateMachine(typeof(_003CAddFriendAsync_003Ed__16))]
	public Task AddFriendAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CAddFriendsAsync_003Ed__17))]
	public Task AddFriendsAsync(string[] userIds, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRemoveFriendAsync_003Ed__18))]
	public Task RemoveFriendAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRemoveFriendsAsync_003Ed__19))]
	public Task RemoveFriendsAsync(string[] userIds, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBlockFriendAsync_003Ed__20))]
	public Task BlockFriendAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBlockFriendsAsync_003Ed__21))]
	public Task BlockFriendsAsync(string[] userIds, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CAcceptFriendRequestAsync_003Ed__22))]
	public Task AcceptFriendRequestAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDeclineFriendRequestAsync_003Ed__23))]
	public Task DeclineFriendRequestAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUnblockFriendAsync_003Ed__24))]
	public Task UnblockFriendAsync(string userId, Action onSuccess = null, Action onFail = null, string locationContext = null)
	{
		return null;
	}

	public List<Friend> GetAllFriends()
	{
		return null;
	}

	public FriendState GetFriendStateForUserId(string userId)
	{
		return default(FriendState);
	}

	public List<Friend> GetFriendsWithState(FriendState state)
	{
		return null;
	}

	public List<Friend> GetFriendsWithStates(List<FriendState> states)
	{
		return null;
	}

	public void SetFriendRpcRequestLimit(int limit)
	{
	}

	public void SyncFriendList(Action onSuccess = null, Action onFail = null)
	{
	}

	protected override void Init()
	{
	}

	[AsyncStateMachine(typeof(_003CSyncFriendListAsync_003Ed__32))]
	private Task SyncFriendListAsync(Action onSuccess = null, Action onFail = null)
	{
		return null;
	}

	private void UpdateFriendsDictionary(IApiFriendList apiFriendList)
	{
	}

	[AsyncStateMachine(typeof(_003CDoFriendOperationAsync_003Ed__34))]
	private Task DoFriendOperationAsync(string[] userIds, FriendOperation operation, Action onSuccess, Action onFail, FriendActionEvent.Action friendAction, string locationContext)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CTrySendFriendActionAnalytics_003Ed__35))]
	private Task TrySendFriendActionAnalytics(string[] userIds, FriendActionEvent.Action friendAction, string locationContext)
	{
		return null;
	}

	public List<IApiUser> RemoveFriendsFromSearch(List<IApiUser> results)
	{
		return null;
	}
}
