using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using KWCore.Utils;
using Nakama;

public class NakamaUserNotificationTracker : Singleton<NakamaUserNotificationTracker>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRetrieveNotifications_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IApiNotificationList> _003C_003Eu__2;

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

	public static Action<IApiNotification> OnUserNotificationReceived;

	protected override void Init()
	{
	}

	[AsyncStateMachine(typeof(_003CRetrieveNotifications_003Ed__2))]
	public void RetrieveNotifications()
	{
	}

	public void AknowledgeNotificationHandled(IApiNotification n)
	{
	}
}
