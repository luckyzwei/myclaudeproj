using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using KWCore.Utils;
using Nakama;

public class NakamaUsers : Singleton<NakamaUsers>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public IApiUser apiUser;

		public Action<IApiUser> onSuccess;

		internal void _003CGetUserById_003Eb__0(List<IApiUser> apiUsersList)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CFetchUsersFromServerAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<IApiUser>> _003C_003Et__builder;

		public List<string> userIds;

		private TaskAwaiter<IApiUsers> _003C_003Eu__1;

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
	private struct _003CGetSuggestedFriendUsers_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<IApiUser>> _003C_003Et__builder;

		public int suggestedFriendCount;

		public NakamaUsers _003C_003E4__this;

		public Action<List<IApiUser>> onSuccess;

		public Action onFail;

		private NakamaSystem _003CnakamaSystem_003E5__2;

		private TaskAwaiter<IApiRpc> _003C_003Eu__1;

		private TaskAwaiter<List<IApiUser>> _003C_003Eu__2;

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
	private struct _003CGetUserById_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IApiUser> _003C_003Et__builder;

		public Action<IApiUser> onSuccess;

		public string userId;

		public NakamaUsers _003C_003E4__this;

		public Action onFail;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetUserIdsFromPayload_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<IApiUser>> _003C_003Et__builder;

		public string payload;

		public NakamaSystem nakamaSystem;

		public NakamaUsers _003C_003E4__this;

		public Action<List<IApiUser>> onSuccess;

		public Action onFail;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetUsersByIds_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<IApiUser>> _003C_003Et__builder;

		public List<string> userIds;

		public NakamaUsers _003C_003E4__this;

		public Action onFail;

		public Action<List<IApiUser>> onSuccess;

		private List<string> _003CidsToFetch_003E5__2;

		private List<IApiUser> _003Cusers_003E5__3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSearchUsersWithId_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<IApiUser>> _003C_003Et__builder;

		public string findUserId;

		public NakamaUsers _003C_003E4__this;

		public Action<List<IApiUser>> onSuccess;

		public Action onFail;

		private NakamaSystem _003CnakamaSystem_003E5__2;

		private TaskAwaiter<IApiRpc> _003C_003Eu__1;

		private TaskAwaiter<List<IApiUser>> _003C_003Eu__2;

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

	private const string ID_REQUEST_PAYLOAD_KEY = "Id";

	private const string USERS_RESPONSE_PAYLOAD_LIST_KEY = "users";

	private const string ID_RESPONSE_PAYLOAD_PROPERTY_KEY = "id";

	private const string FIND_USER_RPC_ID = "find_friends";

	private const string SUGGESTED_FRIENDS_RPC_ID = "suggest_friends";

	private const string SUGGESTED_FRIENDS_REQUEST_ID = "count";

	private const long DEFAULT_VALID_DURATION_IN_SECONDS = 60L;

	private readonly Dictionary<string, CachedUser> m_users;

	private long m_cacheValidDuration;

	public static event Action<List<string>> CachedUsersUpdated
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

	public static void SendCachedUsersUpdated(List<string> updatedIds)
	{
	}

	protected override void Init()
	{
	}

	public void SetCacheValidDuration(long validDurationInSeconds)
	{
	}

	public void InvalidateCachedUser(string userId)
	{
	}

	public void InvalidateAllCachedUsers()
	{
	}

	public void UpdateCachedUser(IApiUser apiUser)
	{
	}

	[AsyncStateMachine(typeof(_003CGetUserById_003Ed__18))]
	public Task<IApiUser> GetUserById(string userId, Action<IApiUser> onSuccess = null, Action onFail = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetUsersByIds_003Ed__19))]
	public Task<List<IApiUser>> GetUsersByIds(List<string> userIds, Action<List<IApiUser>> onSuccess = null, Action onFail = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetSuggestedFriendUsers_003Ed__20))]
	public Task<List<IApiUser>> GetSuggestedFriendUsers(int suggestedFriendCount, Action<List<IApiUser>> onSuccess = null, Action onFail = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSearchUsersWithId_003Ed__21))]
	public Task<List<IApiUser>> SearchUsersWithId(string findUserId, Action<List<IApiUser>> onSuccess = null, Action onFail = null)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetUserIdsFromPayload_003Ed__22))]
	private Task<List<IApiUser>> GetUserIdsFromPayload(string payload, Action<List<IApiUser>> onSuccess, Action onFail, NakamaSystem nakamaSystem)
	{
		return null;
	}

	private bool TryGetUserFromCache(string userId, out IApiUser cachedUser)
	{
		cachedUser = null;
		return false;
	}

	[AsyncStateMachine(typeof(_003CFetchUsersFromServerAsync_003Ed__24))]
	private Task<List<IApiUser>> FetchUsersFromServerAsync(List<string> userIds)
	{
		return null;
	}

	private static List<string> ExtractPropertyFromPayload(string jsonPayload, string listKey, string propertyKey)
	{
		return null;
	}
}
