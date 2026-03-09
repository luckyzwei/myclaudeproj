using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using Hiro.System;
using Hiro.Unity;
using KWCore.Utils;
using Nakama;

public class NakamaSystemsInterface : KWCore.Utils.Singleton<NakamaSystemsInterface>
{
	[Serializable]
	public class ExpiryResponse
	{
		public long server_time;

		public Dictionary<string, long> expiries;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDeleteAccountAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

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
	private struct _003CDeleteNotification_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public string idToDelete;

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
	private struct _003CDeleteNotifications_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public IEnumerable<string> idsToDelete;

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
	private struct _003CGetLeaderboardExpiryAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ExpiryResponse> _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public string[] ids;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IApiRpc> _003C_003Eu__2;

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
	private struct _003CGetNotifications_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IApiNotificationList> _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public int limit;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialise_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public HiroConnectionScriptable connectionSettings;

		public bool waitForConnectivityIndefinitely;

		private TaskAwaiter<Systems> _003C_003Eu__1;

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
	private struct _003CPauseResumeAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public bool pauseStatus;

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
	private struct _003CRPCCall_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IApiRpc> _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		public string rpc;

		public string payload;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IApiRpc> _003C_003Eu__2;

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
	private struct _003CReconnect_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		private IEnumerator<ISystem> _003C_003E7__wrap1;

		private ISystem _003Csystem_003E5__3;

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
	private struct _003CRefreshAllSystemsAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

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
	private struct _003CShutdownAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

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
	private struct _003CSystemsInitializeCompletedAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

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
	private struct _003CWakeUpNakama_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSystemsInterface _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private YieldAwaitable.YieldAwaiter _003C_003Eu__2;

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

	public static bool Initialized;

	private const int JITTER_TIME = 3;

	private const string HIRO_GAME_SYSTEM = "HiroGameSystem";

	private const float RECONNECT_WAIT = 5f;

	private HiroConnectionScriptable m_connectionSettings;

	private NetworkMonitor m_monitor;

	private bool m_partialInitialized;

	private bool m_initialising;

	private float m_lastTriedToConnect;

	private Logger m_logger;

	private NakamaSystem m_nakamaSystem;

	private ILogger Logger => null;

	private NakamaSystem NakamaSystem => null;

	private Systems Systems { get; set; }

	private Client Client { get; set; }

	public bool Online => false;

	protected override void Init()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialise_003Ed__26))]
	public void Initialise(HiroConnectionScriptable connectionSettings, bool waitForConnectivityIndefinitely = false)
	{
	}

	[AsyncStateMachine(typeof(_003CWakeUpNakama_003Ed__27))]
	public Task WakeUpNakama()
	{
		return null;
	}

	public T CreateSystem<T>() where T : ISystem
	{
		return default(T);
	}

	private Task<Systems> CreateSystemsAsync(bool waitForConnectivityIndefinitely = false)
	{
		return null;
	}

	private void OnConnectivityChanged(object sender, NetworkMonitorEventArgs eventArgs)
	{
	}

	[AsyncStateMachine(typeof(_003CReconnect_003Ed__31))]
	private Task Reconnect()
	{
		return null;
	}

	private void SystemsInitializeCompleted()
	{
	}

	[AsyncStateMachine(typeof(_003CSystemsInitializeCompletedAsync_003Ed__33))]
	private void SystemsInitializeCompletedAsync()
	{
	}

	private void SystemsInitializeFailed(Exception e)
	{
	}

	[AsyncStateMachine(typeof(_003CRefreshAllSystemsAsync_003Ed__35))]
	public Task RefreshAllSystemsAsync()
	{
		return null;
	}

	public T GetSystem<T>() where T : ISystem
	{
		return default(T);
	}

	[AsyncStateMachine(typeof(_003CPauseResumeAsync_003Ed__37))]
	public void PauseResumeAsync(bool pauseStatus)
	{
	}

	[AsyncStateMachine(typeof(_003CShutdownAsync_003Ed__38))]
	public void ShutdownAsync()
	{
	}

	public void DeleteAccount()
	{
	}

	[AsyncStateMachine(typeof(_003CDeleteAccountAsync_003Ed__40))]
	public Task DeleteAccountAsync()
	{
		return null;
	}

	private static void CheckConnectionStatus()
	{
	}

	private static NakamaSystem.AuthorizerFunc NakamaAuthorizerFunc(INetworkMonitor monitor)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetNotifications_003Ed__43))]
	public Task<IApiNotificationList> GetNotifications(int limit = 10)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDeleteNotification_003Ed__44))]
	public Task DeleteNotification(string idToDelete)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CDeleteNotifications_003Ed__45))]
	public Task DeleteNotifications(IEnumerable<string> idsToDelete)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetLeaderboardExpiryAsync_003Ed__47))]
	public Task<ExpiryResponse> GetLeaderboardExpiryAsync(string[] ids)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRPCCall_003Ed__48))]
	public Task<IApiRpc> RPCCall(string rpc, string payload)
	{
		return null;
	}
}
