using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AppsFlyerSDK;
using Firebase.Messaging;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine.Networking;

public class PluginSystem
{
	public class InviteFriendData
	{
		public string user_id;

		public string friend_user_id;
	}

	public class GetFriendCountData
	{
		public string user_id;
	}

	[CompilerGenerated]
	private sealed class _003CGetFriendCount_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callBack;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetFriendCount_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPostInviteFriend_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PluginSystem _003C_003E4__this;

		public string user_id;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPostInviteFriend_003Ed__43(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CReviewInProgressAfter_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PluginSystem _003C_003E4__this;

		private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003ClaunchFlowOperation_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CReviewInProgressAfter_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CReviewInProgressBefore_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PluginSystem _003C_003E4__this;

		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CrequestFlowOperation_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CReviewInProgressBefore_003Ed__51(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CcoEndReview_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PluginSystem _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CcoEndReview_003Ed__49(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static readonly string googleStoreURL;

	public static readonly string InviteFriendServerURL;

	public static readonly string GetFriendCountServerURL;

	public TpMaxProp ADProp;

	public TpAnalyticsProp AnalyticsProp;

	public TpPlatformLoginProp LoginProp;

	public TpFirebaseDataProp DataProp;

	public TpTapjoyProp TapjoyProp;

	public TpAnzuProp AnzuProp;

	private string AmazonAppID;

	private ReviewManager _reviewManager;

	private PlayReviewInfo _playReviewInfo;

	public bool IsInitAppsflyer;

	private bool initMax;

	private bool initAdmob;

	private const string APPSFLYER_DEV_KEY = "B3E3DvVKsFLfGWrNg4WtWU";

	private const string APPSFLYER_APP_ID = "6471960010";

	public TpImmersiveInGameProp ImmersiveADProp;

	public bool IsIAAUser;

	public bool WaitUserData;

	private bool onReview;

	private bool appOpenAvailable;

	public TpBackEndProp BackEndProp { get; set; }

	public bool IsInitFacebook { get; private set; }

	public bool InitAdmob => false;

	public void Init()
	{
	}

	private void InitTapjoy()
	{
	}

	public void InitMax(Action InitAction = null)
	{
	}

	public ulong StartRecordingLoadingEvent(int sceneIndex)
	{
		return 0uL;
	}

	public ulong StartRecordingLoadingGroup()
	{
		return 0uL;
	}

	public void StopRecordingLoadingEvent(ulong handle)
	{
	}

	public void StopRecordingLoadingGroup(ulong handle)
	{
	}

	public void InitImmersiveAD()
	{
	}

	private void AppsFlyerOnRequestResponse(object sender, EventArgs e)
	{
	}

	public void AppsflyerInviteUrl(Action<string> onCallback)
	{
	}

	public void OnDeepLink(object sender, EventArgs e)
	{
	}

	private Dictionary<string, object> GetDeepLinkParamsDictionary(DeepLinkEventsArgs deepLinkEventArgs)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPostInviteFriend_003Ed__43))]
	private IEnumerator PostInviteFriend(string user_id)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetFriendCount_003Ed__45))]
	public IEnumerator GetFriendCount(Action callBack = null)
	{
		return null;
	}

	private void InitTapjoyCallbackMgr()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CcoEndReview_003Ed__49))]
	private IEnumerator coEndReview()
	{
		return null;
	}

	public void StartReview()
	{
	}

	[IteratorStateMachine(typeof(_003CReviewInProgressBefore_003Ed__51))]
	private IEnumerator ReviewInProgressBefore()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReviewInProgressAfter_003Ed__52))]
	private IEnumerator ReviewInProgressAfter()
	{
		return null;
	}

	private void InitCallback()
	{
	}

	private void OnHideUnity(bool isGameShown)
	{
	}

	public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
	{
	}

	public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
	}

	public void OnApplicationPause(bool value)
	{
	}

	public void ShowAppOpenAdIfAvailable()
	{
	}

	private void InitAppOpenAvailable()
	{
	}
}
