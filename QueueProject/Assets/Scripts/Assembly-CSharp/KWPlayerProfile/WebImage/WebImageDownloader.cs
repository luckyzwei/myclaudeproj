using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace KWPlayerProfile.WebImage
{
	public static class WebImageDownloader
	{
		public struct ProgressResponse
		{
			public float progress;

			public bool isDone;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadImageAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			public string url;

			public Action<float> progressCallback;

			public float requestTimeout;

			private UnityWebRequest _003Crequest_003E5__2;

			private UnityWebRequestAsyncOperation _003Coperation_003E5__3;

			private float _003Ctimer_003E5__4;

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

		[AsyncStateMachine(typeof(_003CDownloadImageAsync_003Ed__1))]
		public static Task<Texture2D> DownloadImageAsync(string url, Action<float> progressCallback = null, float requestTimeout = 30f)
		{
			return null;
		}
	}
}
