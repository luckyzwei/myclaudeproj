using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using Nakama;

public abstract class NakamaSocialLogin
{
	public enum ResultCode
	{
		SUCCESS = 0,
		NAKAMA_ERROR = 1,
		PLATFORM_ERROR = 2
	}

	public struct ConnectionResult
	{
		public ResultCode code;

		public string message;

		public ConnectionResult(ResultCode code)
		{
			this.code = default(ResultCode);
			message = null;
		}

		public ConnectionResult(ResultCode code, string message)
		{
			this.code = default(ResultCode);
			this.message = null;
		}
	}

	public delegate void HandleAccountClashResultDelegate(bool keepMyDeviceProgress);

	public delegate void HandleAccountClashDelegate(HandleAccountClashResultDelegate result);

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAuthenticateIntoExistingAccount_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSocialLogin _003C_003E4__this;

		public string token;

		private string _003CmyDeviceId_003E5__2;

		private ISession _003CotherDeviceSession_003E5__3;

		private Session _003CmyDeviceSession_003E5__4;

		private TaskAwaiter<ISession> _003C_003Eu__1;

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
	private struct _003CHandleDeviceClash_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaSocialLogin _003C_003E4__this;

		public string token;

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
	private struct _003CLogOutAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSocialLogin _003C_003E4__this;

		public Action<ConnectionResult> resultCallback;

		public string location;

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
	private struct _003COnSuccessLogin_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSocialLogin _003C_003E4__this;

		public string token;

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
	private struct _003CResult_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ConnectionResult result;

		public NakamaSocialLogin _003C_003E4__this;

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
	private struct _003CUnlinkOtherAndLinkCurrent_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaSocialLogin _003C_003E4__this;

		public string token;

		private TaskAwaiter<ISession> _003C_003Eu__1;

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

	protected const long ALREADY_EXIST_ERROR_CODE = 409L;

	protected Action<ConnectionResult> m_loginResultCallback;

	protected NakamaSystem m_nakamaSystem;

	private string m_analyticLocation;

	private HandleAccountClashDelegate m_handleAccountClash;

	protected abstract Task LinkSocial(ISession session, string token);

	protected abstract Task UnlinkSocial(ISession session);

	protected abstract Task<ISession> AuthSocial(string token);

	protected abstract void PlatformLogin();

	public abstract string PlatformName();

	protected abstract void PlatformFinishedActions(ConnectionResult result);

	public void Login(Action<ConnectionResult> resultCallback, string location = null, HandleAccountClashDelegate handleAccountClash = null)
	{
	}

	public void Logout(Action<ConnectionResult> resultCallback, string location = null)
	{
	}

	[AsyncStateMachine(typeof(_003CLogOutAsync_003Ed__17))]
	private void LogOutAsync(Action<ConnectionResult> resultCallback, string location)
	{
	}

	[AsyncStateMachine(typeof(_003CResult_003Ed__18))]
	protected void Result(ConnectionResult result)
	{
	}

	[AsyncStateMachine(typeof(_003COnSuccessLogin_003Ed__19))]
	protected void OnSuccessLogin(string token)
	{
	}

	[AsyncStateMachine(typeof(_003CUnlinkOtherAndLinkCurrent_003Ed__20))]
	private protected void UnlinkOtherAndLinkCurrent(string token)
	{
	}

	[AsyncStateMachine(typeof(_003CAuthenticateIntoExistingAccount_003Ed__21))]
	private protected void AuthenticateIntoExistingAccount(string token)
	{
	}

	[AsyncStateMachine(typeof(_003CHandleDeviceClash_003Ed__22))]
	private Task HandleDeviceClash(string token)
	{
		return null;
	}
}
