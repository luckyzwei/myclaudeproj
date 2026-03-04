using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class FreecashSystem
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public AndroidJavaObject task;

		internal bool _003CGetAndroidAsidAsync_003Eb__0()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetAndroidAsidAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public float timeoutSec;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private AndroidJavaClass _003CunityPlayer_003E5__2;

		private AndroidJavaObject _003CcurrentActivity_003E5__3;

		private AndroidJavaClass _003CappSet_003E5__4;

		private AndroidJavaObject _003Cclient_003E5__5;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003CGetIdfaAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public float timeoutSec;

		private UniTask<(string id, bool enabled, string error)>.Awaiter _003C_003Eu__1;

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
	private struct _003CIsLinkedReq_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<(FreecashIsLinkedResArg arg, UnityWebRequest.Result ret)> _003C_003Et__builder;

		public string url;

		public FreecashIsLinkedReqArg arg;

		private FreecashIsLinkedResArg _003Cresp_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

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
	private struct _003COpenUrl_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public FreecashSystem _003C_003E4__this;

		private UniTask<string>.Awaiter _003C_003Eu__1;

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
	private struct _003COpenUrl_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

		public string account;

		private DateTime _003CtotalStartTime_003E5__2;

		private string _003Ccampaign_003E5__3;

		private string _003Csub_003E5__4;

		private string _003CbaseUrl_003E5__5;

		private string _003Cclick_id_003E5__6;

		private string _003Cgaid_003E5__7;

		private UniTask<string>.Awaiter _003C_003Eu__1;

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
	private struct _003CSendIsLinkedReq_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<(FreecashIsLinkedResArg arg, UnityWebRequest.Result ret)> _003C_003Et__builder;

		public FreecashSystem _003C_003E4__this;

		private UniTask<(FreecashIsLinkedResArg arg, UnityWebRequest.Result ret)>.Awaiter _003C_003Eu__1;

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
	private struct _003CSendIsLinkedReq_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<(FreecashIsLinkedResArg arg, UnityWebRequest.Result ret)> _003C_003Et__builder;

		public string _account;

		public FreecashSystem _003C_003E4__this;

		private UniTask<(FreecashIsLinkedResArg arg, UnityWebRequest.Result ret)>.Awaiter _003C_003Eu__1;

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

	private Subject<Unit> OnInit;

	private Subject<bool> OnRecvIsLinkedRes;

	private string account;

	private string mediaSource;

	public IObservable<Unit> OnInitObservable { get { return null; } }

	public IObservable<bool> OnRecvIsLinkedResObservable { get { return null; } }

	public void Init(string _account)
	{
	}

	public static bool IsAllowCountryCode(string countryCode)
	{
		return false;
	}

	public static bool IsBoostTargetCountry(string countryCode)
	{
		return false;
	}

	public static bool IsBlockedCountry(string countryCode)
	{
		return false;
	}

	public bool IsFromFreecashInternal()
	{
		return false;
	}

	public void SetMediaSource(string _mediaSource)
	{
	}

	[AsyncStateMachine(typeof(_003CSendIsLinkedReq_003Ed__14))]
	public UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> SendIsLinkedReq()
	{
		return default(UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)>);
	}

	[AsyncStateMachine(typeof(_003CSendIsLinkedReq_003Ed__15))]
	public UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> SendIsLinkedReq(string _account)
	{
		return default(UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)>);
	}

	[AsyncStateMachine(typeof(_003CIsLinkedReq_003Ed__16))]
	public static UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> IsLinkedReq(string url, FreecashIsLinkedReqArg arg)
	{
		return default(UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)>);
	}

	[AsyncStateMachine(typeof(_003COpenUrl_003Ed__17))]
	public UniTask<string> OpenUrl()
	{
		return default(UniTask<string>);
	}

	[AsyncStateMachine(typeof(_003COpenUrl_003Ed__18))]
	public static UniTask<string> OpenUrl(string account)
	{
		return default(UniTask<string>);
	}

	private static string GetAndroidGaid()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetAndroidAsidAsync_003Ed__20))]
	private static UniTask<string> GetAndroidAsidAsync(float timeoutSec)
	{
		return default(UniTask<string>);
	}

	[AsyncStateMachine(typeof(_003CGetIdfaAsync_003Ed__21))]
	private static UniTask<string> GetIdfaAsync(float timeoutSec)
	{
		return default(UniTask<string>);
	}
}
