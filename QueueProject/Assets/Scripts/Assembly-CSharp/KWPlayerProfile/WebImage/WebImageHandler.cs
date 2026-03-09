using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace KWPlayerProfile.WebImage
{
	public static class WebImageHandler
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadFromResources_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string resourcePath;

			public int timeout;

			public Action<float> progressCallback;

			public Action<string> failedCallback;

			public Action<Sprite> successCallback;

			private ResourceRequest _003Crequest_003E5__2;

			private float _003Celapsed_003E5__3;

			private float _003CtimeOut_003E5__4;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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
		private struct _003CLoadFromWeb_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string imageUrl;

			public Action<Sprite> successCallback;

			public Action<string> failedCallback;

			public Action<float> progressCallback;

			public int timeout;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private struct _003CLoadImageFromDiskAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			public string filePath;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			private TaskAwaiter<byte[]> _003C_003Eu__2;

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
		private struct _003CRequestSpriteAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string url;

			public Action<string> failedCallback;

			public Action<float> progressCallback;

			public int timeout;

			public Action<Sprite> successCallback;

			private TaskAwaiter<Texture2D> _003C_003Eu__1;

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
		private struct _003CRequestTextureAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			public string url;

			public Action<Texture2D> successCallback;

			public int timeout;

			public Action<float> progressCallback;

			public Action<string> failedCallback;

			private ulong _003ChashKey_003E5__2;

			private string _003CfilePath_003E5__3;

			private TaskAwaiter<Texture2D> _003C_003Eu__1;

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
		private struct _003CTryGetSprite_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public string url;

			public Action<Sprite> successCallback;

			public Action<string> failedCallback;

			public Action<float> progressCallback;

			public int timeout;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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

		public const int DEFAULT_CACHE_TIMEOUT_SECONDS = 4320;

		private const int MIN_REQUEST_TIMEOUT_SECONDS = 10;

		private const int MAX_IO_OPERATIONS_PER_FRAME = 5;

		private const float TIMEOUT_FOR_RESOURCE_LOAD = 5f;

		private static int s_ioOperationsCounter;

		[AsyncStateMachine(typeof(_003CTryGetSprite_003Ed__5))]
		public static Task<Sprite> TryGetSprite(string url, Action<Sprite> successCallback = null, Action<string> failedCallback = null, Action<float> progressCallback = null, int timeout = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadFromResources_003Ed__6))]
		private static Task<Sprite> LoadFromResources(string resourcePath, Action<Sprite> successCallback = null, Action<string> failedCallback = null, Action<float> progressCallback = null, int timeout = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadFromWeb_003Ed__7))]
		private static Task<Sprite> LoadFromWeb(string imageUrl, Action<Sprite> successCallback = null, Action<string> failedCallback = null, Action<float> progressCallback = null, int timeout = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestSpriteAsync_003Ed__8))]
		public static Task<Sprite> RequestSpriteAsync(string url, Action<Sprite> successCallback = null, Action<string> failedCallback = null, Action<float> progressCallback = null, int timeout = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestTextureAsync_003Ed__9))]
		public static Task<Texture2D> RequestTextureAsync(string url, Action<Texture2D> successCallback = null, Action<string> failedCallback = null, Action<float> progressCallback = null, int timeout = -1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadImageFromDiskAsync_003Ed__10))]
		private static Task<Texture2D> LoadImageFromDiskAsync(string filePath)
		{
			return null;
		}

		private static void SaveToDisk(string filePath, Texture2D texture)
		{
		}

		private static string GetCacheFilePath(ulong hashKey)
		{
			return null;
		}

		private static bool IsCacheValid(string filePath)
		{
			return false;
		}

		private static ulong GetHashCodeInt64(string input)
		{
			return 0uL;
		}
	}
}
