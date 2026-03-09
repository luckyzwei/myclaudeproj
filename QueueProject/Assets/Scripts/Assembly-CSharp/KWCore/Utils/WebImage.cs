using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace KWCore.Utils
{
	public class WebImage
	{
		public struct ServerImage
		{
			public Texture2D texture;

			public bool isCached;
		}

		private struct CacheImage
		{
			public WeakReference weakReference;

			public bool isCached;

			public DateTime timeStamp;
		}

		[CompilerGenerated]
		private sealed class _003CGetImage_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string cancelKey;

			public string url;

			public Action<ServerImage> successCallback;

			public ulong codedURL;

			public Action<ProgressResponse> progressCallback;

			public Action<string> failedCallback;

			public bool imageOnDisk;

			public float requestTimeout;

			private WWW _003Cwww_003E5__2;

			private Texture2D _003Ctexture_003E5__3;

			private float _003Ctimer_003E5__4;

			private bool _003CforceEnterWhile_003E5__5;

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
			public _003CGetImage_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CLoadImageFromDiskInternal_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string filePath;

			public string cancelKey;

			public ulong codedURL;

			public Action<ServerImage> successCallback;

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
			public _003CLoadImageFromDiskInternal_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CSaveImage_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ulong codedURL;

			public byte[] data;

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
			public _003CSaveImage_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CUpdateImageProgress_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityWebRequest webRequest;

			public bool ignoreFileSize;

			public Action<ProgressResponse> progressCallback;

			private bool _003CeventSent_003E5__2;

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
			public _003CUpdateImageProgress_003Ed__23(int _003C_003E1__state)
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

		private const double DEFAULT_CACHE_TIMEOUT = 4320.0;

		private const int ANALYTICS_TRIGGER_SIZE_DEFAULT = 204800;

		private static Dictionary<ulong, CacheImage> s_cachedImages;

		private static Dictionary<string, Dictionary<ulong, UnityWebRequest>> s_onGoingRequests;

		private static Dictionary<string, List<Action<ServerImage>>> s_callbacks;

		public const string FB_IMAGE_URL = "http://graph.facebook.com/";

		public const string FB_IMAGE_SIZE_LARGE = "/picture?type=large";

		public const string DEFAULT_URL_CANCEL_KEY = "default_url";

		public const string DEFAULT_DISK_CANCEL_KEY = "default_disk";

		private const string ORIENTATION_SUBSTRING = "?ori";

		private const int MAX_SIZE_BYTES = 1048576;

		private const int MAX_IO_OPERATIONS_PER_FRAME = 5;

		private static int s_IO_OperationsCounter;

		private static string m_prefixURL;

		public static void SetPrefixURL(string prefix)
		{
		}

		public static void Request(string url, Action<ServerImage> successCallback, Action<string> failedCallback = null, Action<ProgressResponse> progressCallback = null, string cancelKey = "default_url", float requestTimeout = -1f)
		{
		}

		public static void LoadImageFromDisk(string filePath, Action<ServerImage> successCallback, Action<string> failedCallback = null, Action<ProgressResponse> progressCallback = null, string cancelKey = "default_disk")
		{
		}

		[IteratorStateMachine(typeof(_003CLoadImageFromDiskInternal_003Ed__19))]
		private static IEnumerator LoadImageFromDiskInternal(string filePath, ulong codedURL, Action<ServerImage> successCallback, string cancelKey)
		{
			return null;
		}

		private static void FinaliseTexture(string url, ulong codedURL, Texture2D tex, Action<ServerImage> successCallback, string cancelKey)
		{
		}

		[IteratorStateMachine(typeof(_003CGetImage_003Ed__21))]
		private static IEnumerator GetImage(string url, ulong codedURL, Action<ServerImage> successCallback, Action<ProgressResponse> progressCallback, Action<string> failedCallback, string cancelKey, bool imageOnDisk, float requestTimeout)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSaveImage_003Ed__22))]
		public static IEnumerator SaveImage(byte[] data, ulong codedURL, string cancelKey)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CUpdateImageProgress_003Ed__23))]
		private static IEnumerator UpdateImageProgress(UnityWebRequest webRequest, Action<ProgressResponse> progressCallback, Action<string> failCallback, bool ignoreFileSize)
		{
			return null;
		}

		private static void AddImageToCache(CacheImage image, ulong codedURL)
		{
		}

		public static void CancelRequest(string key)
		{
		}

		private static void AddRequest(string key, ulong codedURL, UnityWebRequest request)
		{
		}

		private static bool RemoveRequest(string key, ulong codedURL)
		{
			return false;
		}

		public static void ClearCache()
		{
		}

		public static ulong GetHashCodeInt64(string input)
		{
			return 0uL;
		}
	}
}
