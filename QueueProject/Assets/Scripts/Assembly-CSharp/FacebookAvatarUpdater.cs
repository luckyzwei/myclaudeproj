using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;

public class FacebookAvatarUpdater
{
	[Serializable]
	private class AvatarResponse
	{
		public AvatarData data;
	}

	[Serializable]
	private class AvatarData
	{
		public string url;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CUpdateAvatar_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FacebookAvatarUpdater _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
	private struct _003CUpdateClientPlayerAvatar_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string avatarUrl;

		private NakamaSystem _003Csystem_003E5__2;

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

	private const string GRAPH_API_ENDPOINT = "/me/picture?type=large&redirect=false";

	[AsyncStateMachine(typeof(_003CUpdateAvatar_003Ed__1))]
	public void UpdateAvatar()
	{
	}

	private Task<string> FetchLargerAvatar()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CUpdateClientPlayerAvatar_003Ed__3))]
	private Task UpdateClientPlayerAvatar(string avatarUrl)
	{
		return null;
	}
}
