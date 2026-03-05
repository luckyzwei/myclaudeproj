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

	public bool InitAdmob { get { return false; } }

	public void Init()
	{
		IsInitAppsflyer = false;
		IsIAAUser = false;
		WaitUserData = false;
		onReview = false;
		appOpenAvailable = false;
		initMax = false;
		initAdmob = false;
		InitCallback();
		InitAppOpenAvailable();
	}

	private void InitTapjoy()
	{
		if (TapjoyProp == null) return;
		// Tapjoy initialization handled by SDK
	}

	public void InitMax(Action InitAction = null)
	{
		if (initMax) return;
		initMax = true;
		if (ADProp != null)
		{
			// Initialize MAX ad SDK
		}
		InitAction?.Invoke();
	}

	public ulong StartRecordingLoadingEvent(int sceneIndex)
	{
		// Firebase Performance monitoring - start loading trace
		return (ulong)sceneIndex;
	}

	public ulong StartRecordingLoadingGroup()
	{
		// Firebase Performance monitoring - start group trace
		return 0uL;
	}

	public void StopRecordingLoadingEvent(ulong handle)
	{
		// Firebase Performance monitoring - stop loading trace
	}

	public void StopRecordingLoadingGroup(ulong handle)
	{
		// Firebase Performance monitoring - stop group trace
	}

	public void InitImmersiveAD()
	{
		if (ImmersiveADProp == null) return;
		// Initialize immersive in-game ad
	}

	private void AppsFlyerOnRequestResponse(object sender, EventArgs e)
	{
		IsInitAppsflyer = true;
	}

	public void AppsflyerInviteUrl(Action<string> onCallback)
	{
		if (!IsInitAppsflyer)
		{
			onCallback?.Invoke(string.Empty);
			return;
		}
		// Generate AppsFlyer invite link
		AppsFlyer.generateUserInviteLink(new Dictionary<string, string>(), null);
		onCallback?.Invoke(string.Empty);
	}

	public void OnDeepLink(object sender, EventArgs e)
	{
		if (e == null) return;
		var deepLinkEventArgs = e as DeepLinkEventsArgs;
		if (deepLinkEventArgs == null) return;
		var paramDict = GetDeepLinkParamsDictionary(deepLinkEventArgs);
		if (paramDict == null) return;
		// Process deep link parameters (friend invite, etc.)
	}

	private Dictionary<string, object> GetDeepLinkParamsDictionary(DeepLinkEventsArgs deepLinkEventArgs)
	{
		if (deepLinkEventArgs == null || deepLinkEventArgs.deepLink == null) return null;
		try
		{
			var dict = new Dictionary<string, object>();
			// Parse deep link data
			return dict;
		}
		catch
		{
			return null;
		}
	}

	[IteratorStateMachine(typeof(_003CPostInviteFriend_003Ed__43))]
	private IEnumerator PostInviteFriend(string user_id)
	{
		var data = new InviteFriendData
		{
			user_id = BackEndProp != null ? "" : "",
			friend_user_id = user_id
		};
		string jsonData = UnityEngine.JsonUtility.ToJson(data);
		using (var request = UnityWebRequest.Post(InviteFriendServerURL, jsonData))
		{
			request.SetRequestHeader("Content-Type", "application/json");
			yield return request.SendWebRequest();
			if (request.result != UnityWebRequest.Result.Success)
			{
				UnityEngine.Debug.LogWarning("PostInviteFriend failed: " + request.error);
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetFriendCount_003Ed__45))]
	public IEnumerator GetFriendCount(Action callBack = null)
	{
		var data = new GetFriendCountData
		{
			user_id = BackEndProp != null ? "" : ""
		};
		string jsonData = UnityEngine.JsonUtility.ToJson(data);
		using (var request = UnityWebRequest.Post(GetFriendCountServerURL, jsonData))
		{
			request.SetRequestHeader("Content-Type", "application/json");
			yield return request.SendWebRequest();
			if (request.result == UnityWebRequest.Result.Success)
			{
				// Parse friend count from response
			}
			callBack?.Invoke();
		}
	}

	private void InitTapjoyCallbackMgr()
	{
		// Register Tapjoy callback manager
	}

	public void Update()
	{
		// Update ad SDK if needed
	}

	[IteratorStateMachine(typeof(_003CcoEndReview_003Ed__49))]
	private IEnumerator coEndReview()
	{
		yield return new UnityEngine.WaitForSeconds(0.5f);
		onReview = false;
	}

	public void StartReview()
	{
		if (onReview) return;
		onReview = true;
		_reviewManager = new ReviewManager();
		UnityEngine.MonoBehaviour mb = UnityEngine.Camera.main?.GetComponent<UnityEngine.MonoBehaviour>();
		if (mb != null) mb.StartCoroutine(ReviewInProgressBefore());
	}

	[IteratorStateMachine(typeof(_003CReviewInProgressBefore_003Ed__51))]
	private IEnumerator ReviewInProgressBefore()
	{
		var requestFlowOperation = _reviewManager.RequestReviewFlow();
		yield return requestFlowOperation;
		if (requestFlowOperation.Error != ReviewErrorCode.NoError)
		{
			onReview = false;
			yield break;
		}
		_playReviewInfo = requestFlowOperation.GetResult();
		UnityEngine.MonoBehaviour mb = UnityEngine.Camera.main?.GetComponent<UnityEngine.MonoBehaviour>();
		if (mb != null) mb.StartCoroutine(ReviewInProgressAfter());
	}

	[IteratorStateMachine(typeof(_003CReviewInProgressAfter_003Ed__52))]
	private IEnumerator ReviewInProgressAfter()
	{
		var launchFlowOperation = _reviewManager.LaunchReviewFlow(_playReviewInfo);
		yield return launchFlowOperation;
		_playReviewInfo = null;
		UnityEngine.MonoBehaviour mb = UnityEngine.Camera.main?.GetComponent<UnityEngine.MonoBehaviour>();
		if (mb != null) mb.StartCoroutine(coEndReview());
	}

	private void InitCallback()
	{
		UnityEngine.Application.focusChanged += OnHideUnity;
	}

	private void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown)
		{
			// App went to background
		}
		else
		{
			// App came to foreground
			ShowAppOpenAdIfAvailable();
		}
	}

	public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
	{
		if (token != null)
		{
			UnityEngine.Debug.Log("FCM Token: " + token.Token);
		}
	}

	public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
		if (e != null && e.Message != null)
		{
			UnityEngine.Debug.Log("FCM Message: " + e.Message.Notification?.Title);
		}
	}

	public void OnApplicationPause(bool value)
	{
		if (!value)
			ShowAppOpenAdIfAvailable();
	}

	public void ShowAppOpenAdIfAvailable()
	{
		if (!appOpenAvailable) return;
		if (ADProp == null) return;
		// Show app open ad via MAX SDK
	}

	private void InitAppOpenAvailable()
	{
		appOpenAvailable = true;
	}
}
