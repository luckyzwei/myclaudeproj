using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using Nakama;

namespace KWPlayerProfile
{
	public class NakamaPlayerProfileAdapter : IPlayerProfilesAdapter
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Action<PublicProfile> callback;

			internal void _003CGetPublicProfile_003Eb__0(List<PublicProfile> list)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPublicProfile_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NakamaPlayerProfileAdapter _003C_003E4__this;

			public Action<PublicProfile> callback;

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
		private struct _003CGetPublicProfile_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Action<PublicProfile> callback;

			public NakamaPlayerProfileAdapter _003C_003E4__this;

			public string playerId;

			private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

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
		private struct _003CGetPublicProfiles_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string[] userIds;

			public NakamaPlayerProfileAdapter _003C_003E4__this;

			public Action<List<PublicProfile>> callback;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<IApiUsers> _003C_003Eu__2;

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
		private struct _003CUpdatePublicProfile_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PublicProfile profile;

			public Action<PublicProfile> callback;

			public NakamaPlayerProfileAdapter _003C_003E4__this;

			private NakamaSystem _003CnakamaSystem_003E5__2;

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

		[AsyncStateMachine(typeof(_003CGetPublicProfile_003Ed__0))]
		public Task GetPublicProfile(Action<PublicProfile> callback)
		{
			return null;
		}

		private PublicProfile GetPublicProfile(IApiUser apiUser)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPublicProfile_003Ed__2))]
		public Task GetPublicProfile(string playerId, Action<PublicProfile> callback)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPublicProfiles_003Ed__3))]
		public Task GetPublicProfiles(string[] userIds, Action<List<PublicProfile>> callback)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdatePublicProfile_003Ed__4))]
		public Task UpdatePublicProfile(PublicProfile profile, Action<PublicProfile> callback)
		{
			return null;
		}
	}
}
