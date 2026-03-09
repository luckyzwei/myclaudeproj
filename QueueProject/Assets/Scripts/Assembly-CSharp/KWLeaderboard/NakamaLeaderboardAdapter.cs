using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Nakama;

namespace KWLeaderboard
{
	public class NakamaLeaderboardAdapter : ILeaderboardAdapter
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetLeaderboardData_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string leaderboardId;

			public bool aroundOwner;

			public NakamaLeaderboardAdapter _003C_003E4__this;

			public Action<LeaderboardData> callback;

			public int overrideLimit;

			public string region;

			private string _003CrequestKey_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<IApiLeaderboardRecordList> _003C_003Eu__2;

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
		private struct _003CPostPlayerScore_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string leaderboardId;

			public string avatarUrl;

			public string displayName;

			public Dictionary<string, object> metaData;

			public long score;

			public string region;

			public NakamaLeaderboardAdapter _003C_003E4__this;

			public Action<LeaderboardData.User> callback;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<IApiLeaderboardRecord> _003C_003Eu__2;

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
		private struct _003CRequestLeaderboardFromServerAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IApiLeaderboardRecordList> _003C_003Et__builder;

			public bool aroundOwner;

			public string leaderboardId;

			public int limit;

			public string region;

			private TaskAwaiter<IApiLeaderboardRecordList> _003C_003Eu__1;

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

		private const string AVATAR_URL_KEY = "avatarUrl";

		private const string DISPLAY_NAME_KEY = "displayName";

		private LeaderboardsRepository m_repository;

		private Dictionary<string, List<Action<LeaderboardData>>> m_requestsInProgress;

		public NakamaLeaderboardAdapter(LeaderboardsRepository repository)
		{
		}

		private void NakamaConnected(NakamaSystemsInterface nakamaSystems)
		{
		}

		private void CreateNakamaSystems()
		{
		}

		private LeaderboardData.User CreateLeaderboardUser(IApiLeaderboardRecord record)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetLeaderboardData_003Ed__8))]
		public Task GetLeaderboardData(string leaderboardId, string region, Action<LeaderboardData> callback, bool aroundOwner = true, int overrideLimit = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestLeaderboardFromServerAsync_003Ed__9))]
		private Task<IApiLeaderboardRecordList> RequestLeaderboardFromServerAsync(string leaderboardId, string region, int limit, bool aroundOwner = true)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPostPlayerScore_003Ed__10))]
		public Task PostPlayerScore(string leaderboardId, long score, string region = null, string avatarUrl = null, string displayName = null, Dictionary<string, object> metaData = null, Action<LeaderboardData.User> callback = null)
		{
			return null;
		}

		private static string BuildMetadataJson(string avatarUrl, string displayName, Dictionary<string, object> additionalMetadata = null)
		{
			return null;
		}
	}
}
