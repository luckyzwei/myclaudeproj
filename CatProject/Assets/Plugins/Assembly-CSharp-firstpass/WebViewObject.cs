using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WebViewObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCallOnRequestFileChooserPermissionsResult_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WebViewObject _003C_003E4__this;

		public bool granted;

		private int _003Ci_003E5__2;

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
		public _003CCallOnRequestFileChooserPermissionsResult_003Ed__30(int _003C_003E1__state)
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

	private Action<string> onJS;

	private Action<string> onError;

	private Action<string> onHttpError;

	private Action<string> onStarted;

	private Action<string> onLoaded;

	private Action<string> onHooked;

	private Action<string> onCookies;

	private bool paused;

	private bool visibility;

	private bool alertDialogEnabled;

	private bool scrollBounceEnabled;

	private int mMarginLeft;

	private int mMarginTop;

	private int mMarginRight;

	private int mMarginBottom;

	private bool mMarginRelative;

	private float mMarginLeftComputed;

	private float mMarginTopComputed;

	private float mMarginRightComputed;

	private float mMarginBottomComputed;

	private bool mMarginRelativeComputed;

	private AndroidJavaObject webView;

	private bool mVisibility;

	private int mKeyboardVisibleHeight;

	private float mResumedTimestamp;

	private int mLastScreenHeight;

	public bool IsKeyboardVisible => false;

	private void OnApplicationPause(bool paused)
	{
	}

	private void Update()
	{
	}

	public void SetKeyboardVisible(string keyboardVisibleHeight)
	{
	}

	public void RequestFileChooserPermissions()
	{
	}

	[IteratorStateMachine(typeof(_003CCallOnRequestFileChooserPermissionsResult_003Ed__30))]
	private IEnumerator CallOnRequestFileChooserPermissionsResult(bool granted)
	{
		return null;
	}

	public int AdjustBottomMargin(int bottom)
	{
		return 0;
	}

	private bool BottomAdjustmentDisabled()
	{
		return false;
	}

	private void Awake()
	{
	}

	public static bool IsWebViewAvailable()
	{
		return false;
	}

	public void Init(Action<string> cb = null, Action<string> err = null, Action<string> httpErr = null, Action<string> ld = null, Action<string> started = null, Action<string> hooked = null, Action<string> cookies = null, bool transparent = false, bool zoom = true, string ua = "", int radius = 0, int androidForceDarkMode = 0, bool enableWKWebView = true, int wkContentMode = 0, bool wkAllowsLinkPreview = true, bool wkAllowsBackForwardNavigationGestures = true, bool separated = false)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetCenterPositionWithScale(Vector2 center, Vector2 scale)
	{
	}

	public void SetMargins(int left, int top, int right, int bottom, bool relative = false)
	{
	}

	public void SetVisibility(bool v)
	{
	}

	public bool GetVisibility()
	{
		return false;
	}

	public void SetScrollbarsVisibility(bool v)
	{
	}

	public void SetInteractionEnabled(bool enabled)
	{
	}

	public void SetAlertDialogEnabled(bool e)
	{
	}

	public bool GetAlertDialogEnabled()
	{
		return false;
	}

	public void SetScrollBounceEnabled(bool e)
	{
	}

	public bool GetScrollBounceEnabled()
	{
		return false;
	}

	public void SetCameraAccess(bool allowed)
	{
	}

	public void SetMicrophoneAccess(bool allowed)
	{
	}

	public bool SetURLPattern(string allowPattern, string denyPattern, string hookPattern)
	{
		return false;
	}

	public void LoadURL(string url)
	{
	}

	public void LoadHTML(string html, string baseUrl)
	{
	}

	public void EvaluateJS(string js)
	{
	}

	public int Progress()
	{
		return 0;
	}

	public bool CanGoBack()
	{
		return false;
	}

	public bool CanGoForward()
	{
		return false;
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void Reload()
	{
	}

	public void CallOnError(string error)
	{
	}

	public void CallOnHttpError(string error)
	{
	}

	public void CallOnStarted(string url)
	{
	}

	public void CallOnLoaded(string url)
	{
	}

	public void CallFromJS(string message)
	{
	}

	public void CallOnHooked(string message)
	{
	}

	public void CallOnCookies(string cookies)
	{
	}

	public void AddCustomHeader(string headerKey, string headerValue)
	{
	}

	public string GetCustomHeaderValue(string headerKey)
	{
		return null;
	}

	public void RemoveCustomHeader(string headerKey)
	{
	}

	public void ClearCustomHeader()
	{
	}

	public void ClearCookies()
	{
	}

	public void SaveCookies()
	{
	}

	public void GetCookies(string url)
	{
	}

	public void SetBasicAuthInfo(string userName, string password)
	{
	}

	public void ClearCache(bool includeDiskFiles)
	{
	}

	public void SetTextZoom(int textZoom)
	{
	}
}
